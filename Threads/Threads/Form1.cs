using System.Diagnostics;
using System.Threading;

namespace Threads
{
    public partial class frmTrackThread : Form
    {

        class MyThreadClass
        {
            public static void Thread1()
            {
                for (int i = 0; i < 2; i++)
                {
                    Thread thread = Thread.CurrentThread;
                    Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                    Thread.Sleep(500);
                }
            }

            public static void Thread2()
            {
                for (int i = 0; i < 6; i++)
                {
                    Thread thread = Thread.CurrentThread;
                    Debug.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                    Thread.Sleep(1500);
                }
            }
        }

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("-Thread Starts-");
            Thread threadA = new Thread(MyThreadClass.Thread1){ Name = "Thread A", Priority = ThreadPriority.Highest };
            Thread threadB = new Thread(MyThreadClass.Thread1){ Name = "Thread B", Priority = ThreadPriority.Normal };
            Thread threadC = new Thread(MyThreadClass.Thread2){ Name = "Thread C", Priority = ThreadPriority.AboveNormal };
            Thread threadD = new Thread(MyThreadClass.Thread2){ Name = "Thread D", Priority = ThreadPriority.BelowNormal };

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            label1.Text = "End Of Thread";
            Debug.WriteLine("-End of Thread-");

            Task.Delay(2000);
            Application.Exit();
        }
    }
}
