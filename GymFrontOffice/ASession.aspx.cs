using GymTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class ASession : System.Web.UI.Page
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
        clsSession ASession = new clsSession();
                //capture all data for validation
        string trainerID = txtTrainerID.Text;
        string branchID = txtBranchID.Text;
        string dateTime = txtDateTime.Text;
        string type = txtType.Text;
        string cost = txtCost.Text;
        //variable to store error messages
        string Error = "";
        Error = ASession.Valid(trainerID, branchID, type, dateTime, cost);
        if (Error == "")
        {
            //capture all the data
            int sessionid = int.Parse(txtSessionID.Text);
            ASession.SessionID = sessionid;

            int trainerid = int.Parse(txtTrainerID.Text);
            ASession.TrainerID = trainerid;

            int Branchid = int.Parse(txtBranchID.Text);
            ASession.BranchID = Branchid;
            ASession.DateTime = Convert.ToDateTime(txtDateTime.Text);
            ASession.SessionType = txtType.Text;

            ASession.Cost = Double.Parse(txtCost.Text);

            ASession.EquipmentRequired = chkEquipmentRequired.Checked;

            //store the address in the session object
            Session["ASession"] = ASession;
            //redirect to the viewer page
            Response.Redirect("SessionViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }




    protected void Find_Click(object sender, EventArgs e)
    {
        //create an instance of the trainer class
        clsSession ASession = new clsSession();

        //variable to store the primary key
        Int32 SessionID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SessionID = Convert.ToInt32(txtSessionID.Text);
        //find the record
        Found = ASession.Find(SessionID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtTrainerID.Text = ASession.TrainerID.ToString();
            txtBranchID.Text = ASession.BranchID.ToString();
            txtType.Text = ASession.SessionType;
            txtCost.Text = ASession.Cost.ToString();
            txtDateTime.Text = ASession.DateTime.ToString();
            chkEquipmentRequired.Checked = ASession.EquipmentRequired;
        }


    }


    protected void Cancel_Click(object sender, EventArgs e)
    {

    }
}