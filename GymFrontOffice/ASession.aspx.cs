using GymTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        //capture all the data
        int sessionid = int.Parse(sessionID.Text);
        ASession.SessionID = sessionid;
       // int trainerid = int.Parse(trainerID.Text);
       // ASession.TrainerID = trainerid;
       // int branchid = int.Parse(branchID.Text);
     //   ASession.BranchID = branchid;
        //ASession.Type = type.Text;
      //  ASession.Cost = cost.Double;
        ASession.EquipmentRequired = EquipmentRequired.Checked;

        //store the address in the session object
        Session["ASession"] = ASession;
        //redirect to the viewer page
        Response.Redirect("SessionViewer.aspx");
    }

}