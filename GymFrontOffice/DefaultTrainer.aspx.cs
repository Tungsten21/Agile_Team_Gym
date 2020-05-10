using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayTrainers();
        }

        void DisplayTrainers()
        {
            //create an instance of the trainer collection
            clsTrainerCollection AllTrainers = new clsTrainerCollection();
            //set the data source of the list of trainers in the collection
            lstTrainerList.DataSource = AllTrainers.TrainerList;
            //set the name of the primary key
            lstTrainerList.DataValueField = "TrainerID";
            //set the data to display
            lstTrainerList.DataTextField = "FullName";
            //bind the data to the list
            lstTrainerList.DataBind();
        }
    }

    //event handler for the add button
    protected void AddClick(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["TrainerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("ATrainer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 TrainerID;
        //if a record has been selected from the list
        if(lstTrainerList.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            TrainerID = Convert.ToInt32(lstTrainerList.SelectedValue);
            //store the data in the session object
            Session["TrainerID"] = TrainerID;
            //redirect to the delete page
            Response.Redirect("DeleteTrainer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a trainer to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key valye of the record to be edited
        Int32 TrainerID;
        //if a record has been selected from the list
        if(lstTrainerList.SelectedIndex !=  -1)
        {
            //get the primary key of the record to edit
            TrainerID = Convert.ToInt32(lstTrainerList.SelectedValue);
            //store the data in the session object
            Session["TrainerID"] = TrainerID;
            //redirect to the edit page
            Response.Redirect("ATrainer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a Trainer to update";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the trainer collection
        clsTrainerCollection Trainers = new clsTrainerCollection();
        Trainers.ReportByGender(txtFilter.Text);
        lstTrainerList.DataSource = Trainers.TrainerList;
        //set the name of the primary key
        lstTrainerList.DataValueField = "TrainerID";
        //set the name of the field to display
        lstTrainerList.DataTextField = "FullName";
        //bind the data to the list
        lstTrainerList.DataBind();

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the trainer collection
        clsTrainerCollection Trainers = new clsTrainerCollection();
        Trainers.ReportByGender("");
        //clear any existing filter to tidy up the interface
        lstTrainerList.DataSource = Trainers.TrainerList;
        txtFilter.Text = "";
        lstTrainerList.DataValueField = "TrainerID";
        //set the name of the field to display
        lstTrainerList.DataTextField = "FullName";
        //bind the data to the list
        lstTrainerList.DataBind();
    }
}