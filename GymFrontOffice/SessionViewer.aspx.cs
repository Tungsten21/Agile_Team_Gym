using GymTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSession
        clsSession ASession = new clsSession();
        //get the data from the session object

        ASession = (clsSession)Session["ASession"];
        //display the session for this entry
        Response.Write(ASession.SessionID);
        Response.Write("<br>");

        Response.Write(ASession.TrainerID);
        Response.Write("<br>");

        Response.Write(ASession.BranchID);
        Response.Write("<br>");

        Response.Write(ASession.SessionType);
        Response.Write("<br>");

       Response.Write(ASession.Cost);
       Response.Write("<br>");

       Response.Write(ASession.DateTime);
       Response.Write("<br>");

        Response.Write(ASession.EquipmentRequired);

  
    }
}