using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySession();
        }
    }
    void DisplaySession()
    {
        GymClasses.clsSessionCollection Session = new GymClasses.clsSessionCollection();
        lstSessionList.DataSource = Session.SessionList;
        lstSessionList.DataValueField = "SessionID";
        lstSessionList.DataTextField = "Type";
        lstSessionList.DataBind();

         }
}