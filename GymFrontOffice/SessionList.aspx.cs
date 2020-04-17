using GymClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySession();
        }
    }
    void DisplaySession()
    {
        GymClasses.clsSessionCollection Session = new GymClasses.clsSessionCollection();
        lstSessionList.DataSource = Session.SessionList;
        lstSessionList.DataValueField = "SessionID";
        lstSessionList.DataTextField = "SessionType";
        lstSessionList.DataBind();

         }
    protected void lstSessionList_SelectedIndexChanged( object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SessionID"] = -1;
        Response.Redirect("ASession.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SessionID;
        if( lstSessionList.SelectedIndex != -1 )
        {
            SessionID = Convert.ToInt32(lstSessionList.SelectedValue);
            Session["SessionID"] = SessionID;
            Response.Redirect("DeleteSession.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to delete from the list";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Int32 SessionID;

        if (lstSessionList.SelectedIndex != -1)
        {
            SessionID = Convert.ToInt32(lstSessionList.SelectedValue);
            Session["SessionID"] = SessionID;
            Response.Redirect("ASession.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to delete from the list";
        }

    }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            clsSessionCollection Sessions = new clsSessionCollection();
            Sessions.ReportBySessionType(txtFilter.Text);
            lstSessionList.DataSource = Sessions.SessionList;
            lstSessionList.DataValueField = "SessionID";
            lstSessionList.DataTextField = "SessionType";
            lstSessionList.DataBind();
        }

       protected void btnClear_Click(object sender, EventArgs e)
       {
            clsSessionCollection Sessions = new clsSessionCollection();
            Sessions.ReportBySessionType("");
            txtFilter.Text = "";
            lstSessionList.DataSource = Sessions.SessionList;
            lstSessionList.DataValueField = "SessionID";
            lstSessionList.DataTextField = "SessionType";
            lstSessionList.DataBind();
       }
}