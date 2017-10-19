using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClassPt2
{
    public partial class cardChecker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CC.cdyne.LuhnChecker myCC = new CC.cdyne.LuhnChecker();
            CC.cdyne.ReturnIndicator myReturn = new CC.cdyne.ReturnIndicator();

            myReturn = myCC.CheckCC(TextBox1.Text);

            CCResult.Text = myReturn.CardType + " \n" + myReturn.CardValid;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dict.aonaware.WordDefinition myDict = new dict.aonaware.WordDefinition();
            dict.aonaware.DictService myService = new dict.aonaware.DictService();

            myDict = myService.Define(TextBox2.Text);
            dict.aonaware.Definition[] dict = myDict.Definitions;
            
            foreach(dict.aonaware.Definition d in dict)
            {
                ListBox1.Items.Add(d.WordDefinition);
                ListBox1.Items.Add("\n");
            }            
        }
    }
}