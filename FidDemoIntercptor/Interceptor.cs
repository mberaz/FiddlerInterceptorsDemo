using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

namespace FidDemoIntercptor
{
    public class Interceptor : Inspector2, IResponseInspector2
    {
        private MyUserControl control;
        private byte[] _body;
        private HTTPResponseHeaders _headers;
        public override void AddToTab(TabPage o)
        {
            control = new MyUserControl();
            o.Text = "Inspector Demo";
            o.Controls.Add(control);
        }

        public override int GetOrder()
        {
            return 100;
        }

        public void Clear()
        {
            control.Clear();
        }

        public byte[] body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;

                if (_body != null)
                {
                    string completeResponse = Encoding.UTF8.GetString(body);

                    control.SetData(completeResponse);
                }
            }
        }
        public bool bDirty { get; }
        public bool bReadOnly { get; set; }

        public HTTPResponseHeaders headers
        {
            get
            {
                return _headers;
            }
            set
            {
                _headers = value;

                if (_headers != null)
                {
                     

                    control.SetHeaders(_headers);
                }
            }
        }
    }
}
