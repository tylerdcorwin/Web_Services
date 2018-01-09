using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClassSOAPconnect
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Phone.Cdyne.PhoneVerify myPhone = new Phone.Cdyne.PhoneVerify();
            Phone.Cdyne.PhoneReturn myReturn = new Phone.Cdyne.PhoneReturn();
            myReturn = myPhone.CheckPhoneNumber(TextBox1.Text, "0");
            Label1.Text = myReturn.TelecomCity + " " + myReturn.TelecomState;

        }
    }
}