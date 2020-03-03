
using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ATrainer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTrainer
        clsTrainer ATrainer = new clsTrainer();
        //capture all the data
        ATrainer.EmailAddress = email.Text;
        int id = int.Parse(trainerID.Text);
        ATrainer.TrainerID = id;
        ATrainer.FullName = fullName.Text;
        ATrainer.DateOfBirth = Calendar1.SelectedDate;
        ATrainer.Gender = gender.Text;
        ATrainer.Retrained = retrained.Checked;

        //store the address in the session object
        Session["ATrainer"] = ATrainer;
        //redirect to the viewer page
        Response.Redirect("TrainerViewer.aspx");
        
    }
}