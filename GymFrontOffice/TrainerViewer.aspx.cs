using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TrainerViewer : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new insatnce of clsTrainer
        clsTrainer ATrainer = new clsTrainer();
        //get the data from the session object
        ATrainer = (clsTrainer)Session["ATrainer"];
        //display the email address for this entry
        Response.Write(ATrainer.TrainerID);
        Response.Write("<br>");
        Response.Write(ATrainer.FullName);
        Response.Write("<br>");
        Response.Write(ATrainer.Gender);
        Response.Write("<br>");
        Response.Write(ATrainer.EmailAddress);
        Response.Write("<br>");
        Response.Write(ATrainer.DateOfBirth);
        Response.Write("<br>");
        Response.Write(ATrainer.Retrained);
    
    }
}