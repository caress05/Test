﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddArtist2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void SubmitButton_Click(object sender, EventArgs e)
    {

    }
    protected void SubmitArtist()
    {
        ServiceReference.LoginServiceClient los = new ServiceReference.LoginServiceClient();

        ServiceReference.ArtistLite aLite = new ServiceReference.ArtistLite();

        aLite.Name = NameTextBox.Text;
        aLite.Email = EmailTextBox.Text;
        aLite.WebPage = WebPageTextBox.Text;

        los.AddArtist(aLite);

    }
}