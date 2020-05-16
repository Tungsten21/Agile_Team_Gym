using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AMember : System.Web.UI.Page
{
    //in order to store the primary key with a page level scope
    Int32 MemberID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //retrieve MemberID of the member requested
        MemberID = Convert.ToInt32(Session["MemberID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (MemberID != -1)
            {
                //display the current data for the record
                DisplayMember();
            }
        }
    }

    void DisplayMember()
    {
        //create an instance of the member collection
        clsMemberCollection Members = new clsMemberCollection();
        //search for the record in order to update
        Members.ThisMember.Find(MemberID);
        //dispaly the data for this record
        txtbxMemberID.Text = Members.ThisMember.MemberID.ToString();
        txtbxFullName.Text = Members.ThisMember.FullName;
        txtbxAddress.Text = Members.ThisMember.Address;
        txtbxDOB.Text = Members.ThisMember.DOB.ToString();
        txtbxPhoneNumber.Text = Members.ThisMember.PhoneNumber.ToString();
        chkbxMedicalConditions.Checked = Members.ThisMember.MedicalConditions;
    }

    protected void bttnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Member class
        clsMember AMember = new clsMember();
        //variable to store the primary key
        Int32 MemberID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        MemberID = Convert.ToInt32(txtbxMemberID.Text);
        //find the record
        Found = AMember.Find(MemberID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtbxFullName.Text = AMember.FullName;
            txtbxAddress.Text = AMember.Address;
            txtbxDOB.Text = AMember.DOB.ToShortDateString();
            txtbxPhoneNumber.Text = AMember.PhoneNumber;
            chkbxMedicalConditions.Checked = AMember.MedicalConditions;
        }
    }

    protected void bttnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsMember
        clsMember AMember = new clsMember();

        //capture all data for validation
        string FullName = txtbxFullName.Text;
        string Address = txtbxAddress.Text;
        string DOB = txtbxDOB.Text;
        string PhoneNumber = txtbxPhoneNumber.Text;
        //variable to store error messages
        string Error = "";
        Error = AMember.Valid(FullName, Address, DOB, PhoneNumber);
        if (Error == "")
        {
            //capture all the data
            AMember.MemberID = MemberID;
            AMember.FullName = FullName;
            AMember.Address = Address;
            AMember.DOB = Convert.ToDateTime(DOB);
            AMember.PhoneNumber = PhoneNumber;
            AMember.MedicalConditions = chkbxMedicalConditions.Checked;

            //create a new instance of the Member collection
            clsMemberCollection AllMembers = new clsMemberCollection();

            //if this is a new record  then add the data
            if (MemberID == -1)
            {
                //set the ThisMember property
                AllMembers.ThisMember = AMember;
                //add the new record
                AllMembers.Add();

            }
            else //otherwise it must be an update
            {
                //find the record to update
                AllMembers.ThisMember.Find(MemberID);
                //set the ThisMember property
                AllMembers.ThisMember = AMember;
                //update the record
                AllMembers.Update();
            }

            //redirect back to the listpage
            Response.Redirect("MemberList.aspx");

        }
        else
        {
            lblErrorMessage.Text = Error;
        }
    }
}