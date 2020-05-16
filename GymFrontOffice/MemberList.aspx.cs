using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GymClasses;

public partial class MemberList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayMembers();
        }

        void DisplayMembers()
        {
            //create an instance of the Member collection
            clsMemberCollection AllMembers = new clsMemberCollection();
            //set the data source of the list of Members in the collection
            lstMemberList.DataSource = AllMembers.MemberList;
            //set the name of the primary key
            lstMemberList.DataValueField = "MemberID";
            //set the data to display
            lstMemberList.DataTextField = "FullName";
            //bind the data to the list
            lstMemberList.DataBind();
        }
    }

    protected void bttnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["MemberID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AMember.aspx");
    }

    protected void bttnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key valye of the record to be edited
        Int32 MemberID;
        //if a record has been selected from the list
        if (lstMemberList.SelectedIndex != -1)
        {
            //get the primary key of the record to edit
            MemberID = Convert.ToInt32(lstMemberList.SelectedValue);
            //store the data in the session object
            Session["MemberID"] = MemberID;
            //redirect to the edit page
            Response.Redirect("AMember.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            Errorlbl.Text = "Please select a member to update";
        }
    }

    protected void bttnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 MemberID;
        //if a record has been selected from the list
        if (lstMemberList.SelectedIndex != -1)
        {
            //get the primary key of the record to delete
            MemberID = Convert.ToInt32(lstMemberList.SelectedValue);
            //store the data in the session object
            Session["MemberID"] = MemberID;
            //redirect to the delete page
            Response.Redirect("DeleteMember.aspx");
        }
    }

    protected void bttnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Member collection
        clsMemberCollection Members = new clsMemberCollection();
        Members.ReportByDOB(txtbxDOB.Text);
        lstMemberList.DataSource = Members.MemberList;
        //set the name of the primary key
        lstMemberList.DataValueField = "MemberID";
        //set the name of the field to display
        lstMemberList.DataTextField = "FullName";
        //bind the data to the list
        lstMemberList.DataBind();
    }

    protected void bttnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Member collection
        clsMemberCollection Members = new clsMemberCollection();
        Members.ReportByDOB("");
        //clear any existing filter to tidy up the interface
        txtbxDOB.Text = "";
        lstMemberList.DataValueField = "MemberID";
        //set the name of the field to display
        lstMemberList.DataTextField = "FullName";
        //bind the data to the list
        lstMemberList.DataBind();
    }
}