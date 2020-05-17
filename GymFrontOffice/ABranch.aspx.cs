using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;



public partial class _Default : System.Web.UI.Page
{

    Int32 GymID;


    protected void Page_Load(object sender, EventArgs e)
    {

        GymID = Convert.ToInt32(Session["GymID"]);
        if (IsPostBack == false)
        {        
            if (GymID != -1)
            {
                DisplayBranch();
            }
        }

    }

    void DisplayBranch()
    {
        
        clsBranchCollection Branches = new clsBranchCollection();
        //search for the record in order to update
        Branches.ThisBranch.Find(GymID);
        //dispaly the data for this record
        txtbxGymID.Text = Branches.ThisBranch.GymID.ToString();
        txtbxGymCity.Text = Branches.ThisBranch.GymCity;
        txtbxGymAddress.Text = Branches.ThisBranch.GymAddress;
        txtbxDateOpened.Text = Branches.ThisBranch.DateOpened.ToString();
        txtbxSessionCount.Text = Branches.ThisBranch.SessionCount.ToString();
        chkbxAmmenities.Checked = Branches.ThisBranch.Ammenities;
    }

    protected void bttnOK_Click(object sender, EventArgs e)
    {
        clsBranch ABranch = new clsBranch();


        string GymCity = txtbxGymCity.Text;
        string GymAddress = txtbxGymAddress.Text;
        string DateOpened = txtbxDateOpened.Text;
        string SessionCount = txtbxSessionCount.Text;
        string Error = "";
        Error = ABranch.Valid(GymCity, GymAddress, DateOpened, SessionCount);
        if (Error == "")
        {
            ABranch.GymID = GymID;
            ABranch.GymCity = GymCity;
            ABranch.GymAddress = GymAddress;
            ABranch.DateOpened = Convert.ToDateTime(DateOpened);
            ABranch.SessionCount = Convert.ToInt32(SessionCount);
            ABranch.Ammenities = chkbxAmmenities.Checked;


            clsBranchCollection AllBranches = new clsBranchCollection();


            if (GymID == -1)
            {

                AllBranches.ThisBranch = ABranch;

                AllBranches.Add();

            }
            else
            {

                AllBranches.ThisBranch.Find(GymID);
                AllBranches.ThisBranch = ABranch;
                AllBranches.Update();
            }

            //redirect back to the listpage
            Response.Redirect("BranchList.aspx");

        }
        else
        {
            lblErrorMessage.Text = Error;
        }


    }

    protected void bttnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BranchList.aspx");
    }

    protected void bttnFind_Click(object sender, EventArgs e)
    {
        
        clsBranch ABranch = new clsBranch();
        Int32 GymID;
        Boolean Found = false;
        GymID = Convert.ToInt32(txtbxGymID.Text);
        Found = ABranch.Find(GymID);
        //if found
        if (Found == true)
        {
         

            txtbxGymCity.Text = ABranch.GymCity;
            txtbxGymAddress.Text = ABranch.GymAddress;
            txtbxDateOpened.Text = ABranch.DateOpened.ToShortDateString();
            txtbxSessionCount.Text = ABranch.SessionCount.ToString();
            chkbxAmmenities.Checked = ABranch.Ammenities;


        }

    }
}