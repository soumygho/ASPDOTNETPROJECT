using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using offsetLibrary;

public partial class identitycard : System.Web.UI.Page
{
    IdentitycardOperation identityops = new IdentitycardOperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Visible = false;
        if (!IsPostBack)
        {
            bindData();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        try
        {
            Identitycard card = new Identitycard();
            card.Ratepercard = float.Parse(TextBox1.Text);
            bool flag = identityops.insertIntoIdentityCard(card);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY INSERTED!!!";
            }
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
    private void bindData()
    {
        try
        {
            List<Identitycard> cards = identityops.readIdentityCard();
            if (cards != null && cards.Count > 0)
            {
                Button1.Visible = false;
                TextBox1.Text = cards[0].Ratepercard.ToString();
            }
            else
            {
                Button2.Visible = false;
            }
            
        }
        catch (Exception e)
        {
            Label1.Text = e.Message;
            Label1.Visible = true;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        try
        {
            Identitycard card = new Identitycard();
            card.Ratepercard = float.Parse(TextBox1.Text);
            bool flag = identityops.upadteIdentitycard(card);
            if (flag)
            {
                Label1.Text = "SUCCESSFULLY UPDATED!!!";
            }
            bindData();
        }
        catch (Exception em)
        {
            Label1.Text = em.Message;
        }
    }
}
