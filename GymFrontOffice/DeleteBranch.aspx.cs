using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class _Default : System.Web.UI.Page
{



    Int32 GymID;


    protected void Page_Load(object sender, EventArgs e)
    {
        GymID = Convert.ToInt32(Session["GymID"]);
    }

    protected void yesbtn_Click(object sender, EventArgs e)
    {
      
        clsBranchCollection AllBranches = new clsBranchCollection();
        //find the record to delete
        AllBranches.ThisBranch.Find(GymID);
        AllBranches.Delete();
        //redirect back to the main page
        Response.Redirect("BranchList.aspx");
    }

    protected void nobtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchList.aspx");
    }
}