using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;

[assembly: Fiddler.RequiredVersion("2.3.5.0")]
namespace FidDemoIntercptor
{
    public class DemoIntercptor: IFiddlerExtension
    {
        public void OnLoad()
        {
             
        }

        public void OnBeforeUnload()
        {
 
        }
    }
}
