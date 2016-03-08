using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserKey"]== null)
            Response.Redirect("Default.aspx");
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        SubmitShow();
    }
    protected void SubmitShow()
    {
        ServiceReference.LoginServiceClient slr = new ServiceReference.LoginServiceClient();

        ServiceReference.ShowLite sLite = new ServiceReference.ShowLite();

        sLite.Name = ShowNameTextBox.Text;
        sLite.Date = ShowDateCalendar.SelectedDate.ToShortDateString();
        sLite.Time = ShowTimeTextBox.Text;
        sLite.TicketInfo = ShowTicketInfoTextBox.Text;

        slr.AddShow(sLite);

    }
    protected void ShowDateCalendar_SelectionChanged(object sender, EventArgs e)
    {

    }
}