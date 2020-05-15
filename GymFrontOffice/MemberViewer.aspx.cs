using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class MemberViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsMember
        clsMember AMember = new clsMember();
        //get the data from the session object
        AMember = (clsMember)Session["AMember"];
        //display the Member id for this entry

        Response.Write(AMember.FullName);
        Response.Write("<br>");
        Response.Write(AMember.Address);
        Response.Write("<br>");
        Response.Write(AMember.DOB.ToString("yyyy/mm/dd"));
        Response.Write("<br>");
        Response.Write(AMember.PhoneNumber);
        Response.Write("<br>");
        Response.Write(AMember.MedicalConditions);
        Response.Write("<br>");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("AMember.aspx");
    }
}