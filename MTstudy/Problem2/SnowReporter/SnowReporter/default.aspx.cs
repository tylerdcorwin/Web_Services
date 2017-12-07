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
            const string accountSid = "AC1aea9d222ae314d10dfde35c6369c189";
            const string authToken = "f5edc8b98a6c3175aea89f29394274cd";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+14017148826"); //This will be from txt box with augmentation
            var message = MessageResource.Create(to,
                                                 //+15005550006  +17748723011
                                                 from: new PhoneNumber("+17748723011"),
                                                 body: "Testing this out");
            Console.WriteLine(message.Sid);
        }
    }
}