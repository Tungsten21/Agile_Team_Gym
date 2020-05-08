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
    Int32 SessionID;

    protected void Page_Load(object sender, EventArgs e)
    {
        SessionID = Convert.ToInt32(Session["SessionID"]);

        if (IsPostBack ==false)
        {
            if(SessionID !=-1)
            {
                DisplaySession();
            }
        }
    }

    void DisplaySession()
    {
        clsSessionCollection SessionBook = new clsSessionCollection();
        SessionBook.ThisSession.Find(SessionID);
        txtSessionID.Text=SessionBook.ThisSession.SessionID.ToString();
        txtTrainerID.Text = SessionBook.ThisSession.TrainerID.ToString();
        txtBranchID.Text= SessionBook.ThisSession.BranchID.ToString();
        txtDateTime.Text = SessionBook.ThisSession.DateTime.ToString();
        chkEquipmentRequired.Checked = SessionBook.ThisSession.EquipmentRequired;
        txtCost.Text = SessionBook.ThisSession.Cost.ToString();
        txtType.Text = SessionBook.ThisSession.SessionType;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsTrainer
        clsSession ASession = new clsSession();
                //capture all data for validation
        string TrainerID = txtTrainerID.Text;
        string BranchID = txtBranchID.Text;
        string DateTime = txtDateTime.Text;
        string SessionType = txtType.Text;
        string Cost = txtCost.Text;
        //variable to store error messages
        string Error = "";
        Error = ASession.Valid(TrainerID, BranchID, SessionType, DateTime, Cost);
        if (Error == "")
        {
           ASession.SessionID = SessionID;
            ASession.TrainerID = Convert.ToInt32(TrainerID);
            ASession.BranchID = Convert.ToInt32(BranchID);
            ASession.DateTime = Convert.ToDateTime(DateTime);
            ASession.SessionType = SessionType;
            ASession.Cost = Decimal.Parse(Cost);
            ASession.EquipmentRequired = chkEquipmentRequired.Checked;

            clsSessionCollection SessionList = new clsSessionCollection();
            if (SessionID == -1)
            {
                SessionList.ThisSession = ASession;
                SessionList.Add();
            }

            else
            {
                SessionList.ThisSession.Find(SessionID);
                SessionList.ThisSession = ASession;
                SessionList.Update();
            }
            Response.Redirect("SessionList.aspx");

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

    protected void chkEquipmentRequired_CheckedChanged(object sender, EventArgs e)
    {

    }
}