using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using LoggerLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*ErrorLogger err = new ErrorLogger();
        err.Log(string.Format("{0}\t{1}\t{2}\n", DateTime.Now.ToString(), Request.UserAgent, Request.QueryString["text"]));*/

        DebugLogger def = new DebugLogger();
        def.Log(string.Format("{0}\t{1}\t{2}\n", DateTime.Now.ToString(), Request.UserAgent, Request.QueryString["text"]));
    }
}