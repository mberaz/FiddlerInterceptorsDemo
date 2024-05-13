using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

namespace FidDemo
{
    public partial class FidDemoUC : UserControl
    {
        public FidDemoUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var session = FiddlerApplication.UI.GetSelectedSessions(1).FirstOrDefault();

            richTextBox1.Text += session.fullUrl + Environment.NewLine;

            foreach (var header in session.RequestHeaders)
            {
                richTextBox1.Text += header.Name + " " + header.Value + Environment.NewLine;
            }
        }
    }
}
