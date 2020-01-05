using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static Random r=new Random();
    static int tut,hak=0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            tut = r.Next(1, 101);
            TextBox1.Focus();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Button2.Enabled = false;
        hak++;
        int sayi = Convert.ToInt32(TextBox1.Text);
        if (sayi<tut)
        {
            Label1.Text = "Sayınızı Büyütün...";
            TextBox1.Text = "";
            TextBox1.Focus();
        }
        else if (sayi > tut)
        {
            Label1.Text = "Sayınızı Küçültün...";
            TextBox1.Text = "";
            TextBox1.Focus();
        }
        else if (sayi == tut)
        {
            Label1.Text = "Tebrikler..."+hak.ToString()+" .hakkınızda bildiniz";
            Button2.Enabled = true;
            Button1.Enabled = false;    
        }
        Label2.Text = (10 - hak).ToString() + " hakkınız kaldı...";
        if (hak==10)
        {
            Label2.Text = tut.ToString() + "olan sayımı bilemedin...";
            Button1.Enabled = false;
            Button2.Enabled = true;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        tut = r.Next(1,101);
        hak = 0;
        TextBox1.Text = "";
        TextBox1.Focus();
        Button1.Enabled = true;
        Label1.Text = "";
        Label2.Text = "10 hakkınız var";
        Button2.Enabled = false;
    }
}