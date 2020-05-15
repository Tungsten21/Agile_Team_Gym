using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class DeleteMember : System.Web.UI.Page
{
    Int32 MemberID;

    
    protected void Page_Load(object sender, EventArgs e)
    {
        //retrieve the MemberID of the Member to be deleted from the session object
        MemberID = Convert.ToInt32(Session["MemberID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the member collection
        clsMemberCollection AllMembers = new clsMemberCollection();
        //find the record to delete
        AllMembers.ThisMember.Find(MemberID);
        //delete the record
        AllMembers.Delete();
        //redirect back to the main page
        Response.Redirect("MemberList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberList.aspx");
    }
}