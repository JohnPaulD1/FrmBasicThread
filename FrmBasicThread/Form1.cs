using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class frmTrackThread : Form
    {
        
        MyThreadClass MyThreadClass = new MyThreadClass();  
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "-Thread Started-";

            ThreadStart threadStart1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart threadStart2 = new ThreadStart(MyThreadClass.Thread2);

            Thread ThreadA = new Thread(threadStart1);
            Thread ThreadB = new Thread(threadStart2);
            Thread ThreadC = new Thread(threadStart1);
            Thread ThreadD = new Thread(threadStart2);

            ThreadA.Name = "Thread A Process";                     
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";
            
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End Of Thread-";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
