using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        clsBranch ABranch = new clsBranch();
        ABranch = (clsBranch)Session["ABranch"];
      

        Response.Write(ABranch.GymCity);
        Response.Write("<br>");
        Response.Write(ABranch.GymAddress);
        Response.Write("<br>");
        Response.Write(ABranch.DateOpened.ToString("yyyy/mm/dd"));
        Response.Write("<br>");
        Response.Write(ABranch.SessionCount);
        Response.Write("<br>");
        Response.Write(ABranch.Ammenities);
        Response.Write("<br>");

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ABranch.aspx");
    }
}