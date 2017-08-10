using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmbientContextExamples.Example1;

namespace DesignPatternsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestAmbientContext_Click(object sender, EventArgs e)
        {
            DisplayDebugInfo();
            Credentials.Instance = new SuperCredentials();
            DisplayDebugInfo();

            var t = new Task(() =>
                {
                    DisplayDebugInfo();
                }
            );
            t.Start();
            t.Wait();
        }

        private void DisplayDebugInfo()
        {
            Console.WriteLine("Task {0} running on thread {1}",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Instance of ambient context {0}", Credentials.Instance.GetHashCode());
        }
    }
}
