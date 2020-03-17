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
}