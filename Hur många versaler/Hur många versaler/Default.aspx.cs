using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hur_många_versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button.Text = "Submit";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Text.Enabled == false)
            {
                Result.Text = "";
                Text.Text = "";
                Text.Enabled = true;
                Button.Text = "Submit";
            }
            else
            {
                Result.Text = "Texten inehåller " + Model.TextAnalyzer.GetNumberOfCapitals(Text.Text).ToString() + " versaler";
                Text.Enabled = false;
                Button.Text = "Reset";
            }
            
        }
    }
}