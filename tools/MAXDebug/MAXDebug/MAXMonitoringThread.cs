using System;
using System.Net.Sockets;   // TCP-streaming
using System.Threading;     // the sleeping part...
using System.Text;
using System.Collections.Generic;

namespace MAXDebug
{
	public class MAXMonitoringThread
	{
		private String Hostname;
		private Int32 Port;
		public House theHouse;
		private Dictionary<String,IMAXDevice> previousHouse;
		private static bool keepRunning = true;
		public bool running = true;
		private Int32 MAXUpdateTime;

		public MAXMonitoringThread(String _Hostname, Int32 _Port, Int32 UpdateTime = 10000)
		{
			Hostname = _Hostname;
			Port = _Port;
			MAXUpdateTime = UpdateTime;
		}

		// this is the ELV MAX! Cube monitoring script
		public void Run()
        {
			while(running)
			{
				#region Update House
				try
				{
					if (theHouse != null)
					{
						previousHouse = theHouse.GetAllDevicesInADictionary();
					}

					theHouse = new House();

					// we obviously have enough paramteres, go on and try to connect
					TcpClient client = new TcpClient();
					client.Connect(Hostname,Port);
					NetworkStream stream = client.GetStream();

					// the read buffer (chosen quite big)
					byte[] myReadBuffer = new byte[4096*8];
					List<String> Messages = new List<string>();

					// to build the complete message
					StringBuilder myCompleteMessage = new StringBuilder();
					int numberOfBytesRead = 0;

					MAXEncodeDecode DecoderEncoder = new MAXEncodeDecode();
					keepRunning = true;
					// Incoming message may be larger than the buffer size.
					do
					{
						myCompleteMessage = new StringBuilder();
						stream.ReadTimeout = 1000;
						try
						{
							numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);
							myCompleteMessage.AppendFormat("{0}", Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead));

							Messages.Add(myCompleteMessage.ToString());
						}
						catch(Exception)
						{
							keepRunning = false;
						}
					}
					while(keepRunning);

					List<String> PreProcessedMessages = new List<string>();
					// preprocess
					foreach(String _Message in Messages)
					{
						if (_Message.Remove(_Message.Length-2).Contains("\r\n"))
						{
							String[] PMessages = _Message.Remove(_Message.Length-2).Split(new char[1] { '\n' },StringSplitOptions.RemoveEmptyEntries);
							foreach(String pmessage in PMessages)
							{
								PreProcessedMessages.Add(pmessage.Replace("\r","")+"\r\n");
							}
						}
						else
							PreProcessedMessages.Add(_Message);
					}			
					// Analyze and Output Messages
					foreach(String _Message in PreProcessedMessages)
					{
						IMAXMessage Message = DecoderEncoder.ProcessMessage(_Message.ToString(), theHouse);
	/*					if (Message != null)
						{
							ConsoleOutputLogger.WriteLine(_Message.ToString());
							ConsoleOutputLogger.WriteLine(Message.ToString());
							ConsoleOutputLogger.WriteLine("");
						}*/
					}
					stream.Close();
					client.Close();
				}
				catch(Exception)
				{
				}
				#endregion

				#region Diff the house
				if (previousHouse != null)
				{
					// only if we already got two houses in here...
					List<IDeviceDiffSet> differences = DiffHouse.CalculateDifferences(previousHouse,theHouse.GetAllDevicesInADictionary());
					if (differences.Count != 0)
					{
						foreach(IDeviceDiffSet _difference in differences)
						{
							StringBuilder sb = new StringBuilder();

							sb.Append("S\t"+_difference.DeviceName+"\t"+_difference.DeviceType);

							if (_difference.DeviceType == DeviceTypes.HeatingThermostat)
							{
								HeatingThermostatDiff _heating = (HeatingThermostatDiff)_difference;

								ConsoleOutputLogger.WriteLine(_heating.ToString());
							}

							if (_difference.DeviceType == DeviceTypes.ShutterContact)
							{
								ShutterContactDiff _shutter = (ShutterContactDiff)_difference;

								ConsoleOutputLogger.WriteLine(_shutter.ToString());
							}
						}
					}
				}
				#endregion
				Thread.Sleep (MAXUpdateTime);
			}
		}

	}
}

