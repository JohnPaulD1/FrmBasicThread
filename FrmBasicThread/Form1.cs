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
    public partial class FrmBasicThread : Form
    {
        
        MyThreadClass MyThreadClass = new MyThreadClass();  
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            label1.Text = "--Before Starting Thread--";

            ThreadStart threadStart = new ThreadStart(MyThreadClass.Thread1);

            Thread ThreadA = new Thread(threadStart);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(threadStart);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("--End of Thead--");
            label1.Text = "--End Of Thread--";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
