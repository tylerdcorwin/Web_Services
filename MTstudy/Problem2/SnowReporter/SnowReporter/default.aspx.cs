using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Clients;

namespace SnowReporter
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SendMessage_OnClick(object sender, EventArgs e)
        {
            const string accountSid = "XXXXXX";
            const string authToken = "XXXXX";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+XXXX"); //This will be from txt box with augmentation
            var message = MessageResource.Create(to,
                                                 //+xxxx  +XXXX
                                                 from: new PhoneNumber("+XXXXX"),
                                                 body: "Testing this out");
            Console.WriteLine(message.Sid);
        }
    }
}
