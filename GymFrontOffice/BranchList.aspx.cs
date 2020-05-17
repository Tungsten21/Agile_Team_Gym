using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            
            DisplayBranches();
        }


        void DisplayBranches()
        {

            clsBranchCollection AllBranches = new clsBranchCollection();
            lstBranchList.DataSource = AllBranches.BranchList;
            lstBranchList.DataValueField = "GymID";
            lstBranchList.DataTextField = "GymCity";
            lstBranchList.DataBind();
        }


    }


    protected void AddClick(object sender, EventArgs e)
    {
        Session["GymID"] = -1;
        Response.Redirect("ABranch.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 GymID;

        if (lstBranchList.SelectedIndex != -1)
        { GymID = Convert.ToInt32(lstBranchList.SelectedValue);
            Session["GymID"] = GymID;
            Response.Redirect("ABranch.aspx"); }
        else 
        {
            lablError.Text = "Please select a Branch record to update";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        Int32 GymID;
        if (lstBranchList.SelectedIndex != -1)
        {
            GymID = Convert.ToInt32(lstBranchList.SelectedValue);
            Session["GymID"] = GymID;
            Response.Redirect("DeleteBranch.aspx");
        }
        else
        {
            lablError.Text = "Please Select a record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsBranchCollection Branches = new clsBranchCollection();

        Branches.ReportByDateOpened(txtFilter.Text);
        lstBranchList.DataSource = Branches.BranchList;
        lstBranchList.DataValueField = "GymID";
        lstBranchList.DataTextField = "DateOpened";
        lstBranchList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsBranchCollection Branches = new clsBranchCollection();
        Branches.ReportByDateOpened("");
        txtFilter.Text = "";
        lstBranchList.DataSource = Branches.BranchList;
        lstBranchList.DataValueField = "GymID";
        lstBranchList.DataTextField = "DateOpened";
        lstBranchList.DataBind();

    }

    protected void lstTrainerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}