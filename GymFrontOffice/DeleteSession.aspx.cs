using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class DeleteSession : System.Web.UI.Page
{
    Int32 SessionID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SessionID = Convert.ToInt32(Session["SessionID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
       clsSessionCollection SessionBook = new clsSessionCollection();
        SessionBook.ThisSession.Find(SessionID);
        SessionBook.Delete();
        Response.Redirect("SessionList.aspx");
    }
}