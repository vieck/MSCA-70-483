using System;
using System.Threading;

namespace Multithreading
{
	//Creating a thread with the thread class
    class MainClass
    {
		public static void CreateThread() {
			Thread thread = new Thread(new ThreadStart(SleepThread));
			thread.Start();
		}

		private static void SleepThread() {
			for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sleeping Thread: " + i);
                Thread.Sleep(0);
            }
		}

        public static void Main(string[] args)
        {
			CreateThread();
        }
    }
}
