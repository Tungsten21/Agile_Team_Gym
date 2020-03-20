using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class DeleteTrainer : System.Web.UI.Page
{
    Int32 TrainerID;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the TrainerId of the trainer to be deleted from the session object
        TrainerID = Convert.ToInt32(Session["TrainerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Trainer collection
        clsTrainerCollection AllTrainers = new clsTrainerCollection();
        //find the record to delete
        AllTrainers.ThisTrainer.Find(TrainerID);
        //delete the record
        AllTrainers.Delete();
        //redirect back to the main page
        Response.Redirect("DefaultTrainer.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}