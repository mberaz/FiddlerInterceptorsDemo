using Fiddler;
using System;
using System.Windows.Forms;

namespace FidDemoIntercptor
{
    public partial class MyUserControl : UserControl
    {
        private string _headerText;
        private string _body;
        private bool isBody = true;
        public MyUserControl()
        {
            InitializeComponent();
        }
 
        public void SetData(string data)
        {
            _body = data;
            richTextBox1.Text = data;
        }

        public void SetHeaders(HTTPResponseHeaders headers)
        {
            foreach (var httpResponseHeader in headers)
            {
                _headerText += $"{httpResponseHeader.Name} : {httpResponseHeader.Value}";
            }
        }

        public void Clear()
        {
            richTextBox1.Text = null;
        }

        private void btnBodyOrHeaderSwitcher_Click(object sender, EventArgs e)
        {
            if (isBody)
            {
                isBody = false;
                richTextBox1.Text = _headerText;
            }
            else
            {
                isBody = true;
                richTextBox1.Text = _body;
            }
        }
    }
}
