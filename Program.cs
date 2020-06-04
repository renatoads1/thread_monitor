using System;
using System.Threading;
using System.Diagnostics;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(TimerR));
            ////////////////////////////////////////////////
            Thread z = new Thread(new ThreadStart(TimerR2));
            
            t.Start();
            z.Start();
            
        }
        public static void TimerR()
        {
            //busca um na fila de acordo com status
            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine("t1" + DateTime.Now.ToString());
                using (Process p = Process.Start(@"C:\Users\renatolacerda\Desktop\OlaMundoWF.exe"))
                {
                    Thread.Sleep(2000);
                    Console.WriteLine(p.Id.ToString());
                    Thread.Sleep(2000);
                    p.Kill();
                }
                
            }
            
        }
        public static void TimerR2()
        {
            while (true)
            {
                //verifica se fila aberta ou fechada 
                Thread.Sleep(5000);
                Console.WriteLine("t2" + DateTime.Now.ToString());
            }
        }
    }
}
