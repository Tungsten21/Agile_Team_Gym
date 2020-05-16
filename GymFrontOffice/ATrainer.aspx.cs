using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ATrainer : System.Web.UI.Page
{
    //var to stor the primary key with page level scope
    Int32 TrainerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the trainerID of the trainer to processed
        TrainerID = Convert.ToInt32(Session["TrainerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(TrainerID != -1)
            {
                //display the current data for the record
                DisplayTrainer();
            }
        }
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
            txtDateOfBirth.Text = ATrainer.DateOfBirth.ToShortDateString();
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
            ATrainer.EmailAddress = email;
            ATrainer.TrainerID = TrainerID;
            ATrainer.FullName = fullName;
            ATrainer.DateOfBirth = Convert.ToDateTime(dateOfBirth);
            ATrainer.Gender = gender;
            ATrainer.Retrained = chkRetrained.Checked;

            //create a new instance of the trainer collection
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            //if this is a new record i.e. Trainer ID = -1 then add the data
            if(TrainerID == -1)
            {
                //set the ThisTrainer property
                AllTrainers.ThisTrainer = ATrainer;
                //add the new record
                AllTrainers.Add();
               
            }
            else //otherwise it must be an update
            {
                //find the record to update
                AllTrainers.ThisTrainer.Find(TrainerID);
                //set the ThisTrainer property
                AllTrainers.ThisTrainer = ATrainer;
                //update the record
                AllTrainers.Update();
            }

            //redirect back to the listpage
            Response.Redirect("DefaultTrainer.aspx");
           
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void txtTrainerID_TextChanged(object sender, EventArgs e)
    {

    }

    void DisplayTrainer()
    {
        //create an instance of the trainer collection
        clsTrainerCollection Trainers = new clsTrainerCollection();
        //find the record to update
        Trainers.ThisTrainer.Find(TrainerID);
        //dispaly the data for this record
        txtTrainerID.Text = Trainers.ThisTrainer.TrainerID.ToString();
        txtFullname.Text = Trainers.ThisTrainer.FullName;
        txtEmail.Text = Trainers.ThisTrainer.EmailAddress;
        txtGender.Text = Trainers.ThisTrainer.Gender;
        txtDateOfBirth.Text = Trainers.ThisTrainer.DateOfBirth.ToString();
        chkRetrained.Checked = Trainers.ThisTrainer.Retrained;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultTrainer.aspx");
    }
}