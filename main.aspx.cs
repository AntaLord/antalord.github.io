using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B1_Click(object sender, EventArgs e)
    {
        if( TextBox1.Text == "" )
        {
            Response.Write("<script>alert('Digite um valor para converter!')</script>");
        }
        else
        {
            int diegao = 4500 * Convert.ToInt32(TextBox1.Text);
            Label1.Text = "<strong>Total: </strong>" + Convert.ToString(diegao) + " diegões!";
        }
    }
}
