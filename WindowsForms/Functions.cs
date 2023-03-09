using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2WindowsFormsBrowser
{
    internal class Functions
    {
        public void MessagedReceivedHandler(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            //addressBar.Text = uri;
            //webView.CoreWebView2.PostWebMessageAsString(uri);
            MessageBox.Show(uri);
        }
    }
}
