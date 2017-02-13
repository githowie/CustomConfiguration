using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Collections.Specialized;

namespace CustomConfiguration
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            /*
            string devUrl = string.Empty;
            var connectionManagerDatabaseServers = ConfigurationManager.GetSection("ConnectionManagerDatabaseServers") as NameValueCollection;
            if (connectionManagerDatabaseServers != null)
            {
                devUrl = connectionManagerDatabaseServers["Dev"].ToString();
                Response.Write(devUrl);
            }
             * */

            // Grab the Environments listed in the App.config and add them to our list.
            var connectionManagerDatabaseServers = ConfigurationManager.GetSection("ConnectionManagerDatabaseServers") as NameValueCollection;
            if (connectionManagerDatabaseServers != null)
            {
                foreach (var serverKey in connectionManagerDatabaseServers.AllKeys)
                {
                    string serverValue = connectionManagerDatabaseServers.GetValues(serverKey).FirstOrDefault();
                    Response.Write(serverValue + "<BR>");
                }
            }
            
        }
    }
}