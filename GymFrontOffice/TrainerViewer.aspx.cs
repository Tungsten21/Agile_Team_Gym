using System;
using GymClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TrainerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsTrainer
        clsTrainer ATrainer = new clsTrainer();
        //get the data from the session object
        ATrainer = (clsTrainer)Session["ATrainer"];
        //display the Trainer id for this entry
        
        Response.Write(ATrainer.FullName);
        Response.Write("<br>");
        Response.Write(ATrainer.Gender);
        Response.Write("<br>");
        Response.Write(ATrainer.DateOfBirth.ToString("dd/MM/yyyy"));
        Response.Write("<br>");
        Response.Write(ATrainer.EmailAddress);
        Response.Write("<br>");
        Response.Write(ATrainer.Retrained);
        Response.Write("<br>");


    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("ATrainer.aspx");
    }
}