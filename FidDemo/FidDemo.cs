using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

[assembly: Fiddler.RequiredVersion("2.3.5.0")]
namespace FidDemo
{
    public class FidDemo : IAutoTamper
    {
        public void OnLoad()
        {
            var menuItem = new MenuItem("FidDeo");
            menuItem.MenuItems.Add(
                    new MenuItem(
                        "action",
                        (sender, args) =>
                        {
                            var session = FiddlerApplication.UI.GetSelectedSessions(1).FirstOrDefault();
                            MessageBox.Show(session.fullUrl);
                        }));


            FiddlerApplication.UI.mnuSessionContext.MenuItems.Add(menuItem);
            menuItem.Index = 0;

            var oPage = new TabPage("randomTab") { ImageIndex = (int)SessionIcons.Document };
            oPage.Controls.Add(new FidDemoUC
            {
                Dock = DockStyle.Fill
            });

            FiddlerApplication.UI.tabsViews.TabPages.Add(oPage);
        }

        public void OnBeforeUnload()
        {

        }

        public void AutoTamperRequestBefore(Session oSession)
        {

        }

        public void AutoTamperRequestAfter(Session oSession)
        {

        }

        public void AutoTamperResponseBefore(Session oSession)
        {

        }

        public void AutoTamperResponseAfter(Session oSession)
        {

        }

        public void OnBeforeReturningError(Session oSession)
        {

        }
    }
}
