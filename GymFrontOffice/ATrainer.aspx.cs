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

    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        //create an instance of the trainer class
        clsTrainer ATrainer = new clsTrainer();
        //variable to store the primary key
        Int32 TrainerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        TrainerID = Convert.ToInt32(txtTrainerID.Text);
        //find the record
        Found = ATrainer.Find(TrainerID);
        //if found
        if(Found == true)
        {
            //display the values of the properties in the form
            txtFullname.Text = ATrainer.FullName;
            txtGender.Text = ATrainer.Gender;
            txtDateOfBirth.Text = ATrainer.DateOfBirth.ToString();
            txtEmail.Text = ATrainer.EmailAddress;
            chkRetrained.Checked = ATrainer.Retrained;
        }
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTrainer
        clsTrainer ATrainer = new clsTrainer();

        //capture all data for validation
        string fullName = txtFullname.Text;
        string gender = txtGender.Text;
        string dateOfBirth = txtDateOfBirth.Text;
        string email = txtEmail.Text;
        //variable to store error messages
        string Error = "";
        Error = ATrainer.Valid(fullName, gender, dateOfBirth, email);
        if (Error == "")
        {
            //capture all the data
            ATrainer.EmailAddress = txtEmail.Text;
            int id = int.Parse(txtTrainerID.Text);
            ATrainer.FullName = txtFullname.Text;
            ATrainer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            ATrainer.Gender = txtGender.Text;
            ATrainer.Retrained = chkRetrained.Checked;

            //store the trainer in the session object
            Session["ATrainer"] = ATrainer;
            //redirect to the viewer page
            Response.Redirect("TrainerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void txtTrainerID_TextChanged(object sender, EventArgs e)
    {

    }
}