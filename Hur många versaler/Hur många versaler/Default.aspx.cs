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
            Reset.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Result.Text = "Antalet versaler är: " + Model.TextAnalyzer.GetNumberOfCapitals(Text.Text).ToString();
            Text.Enabled = false;
            Submit.Visible = false;
            Reset.Visible = true;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Result.Text = "";
            Text.Text = "";
            Text.Enabled = true;
            Submit.Visible = true;

        }

    }
}