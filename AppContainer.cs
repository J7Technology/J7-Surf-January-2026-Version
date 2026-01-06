using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyTabs;
using Microsoft.Web.WebView2.WinForms;
namespace Surf
{
    public partial class AppContainer : TitleBarTabs
    {
        WebBrowser webBrowser1 = new WebBrowser();
        public AppContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = false;
            TabRenderer = new  ChromeTabRenderer(this);
        }

        // Handle the method CreateTabs that allows user to create tabs

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                // The content will be an instance of another form
                Content = new SurfUI()
                {
                    Text = new SurfUI().webView.Source.ToString(),

                }
            };
            
        }
    }
}
