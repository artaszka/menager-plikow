using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.IO;

namespace menagerplików
{
    public partial class Strona2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LadujObraz();
        }
                       
        protected void bWczytaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\Strona2.aspx");  
        }

        private void LadujObraz()
        {
            foreach (string NazwaPliku in Directory.GetFiles(Server.MapPath("~\\Files\\Fotki\\")))
            {
                ImageButton Miniatura = new ImageButton();
                FileInfo fileInfo = new FileInfo(NazwaPliku);
                Miniatura.ImageUrl = "~\\Files\\Fotki\\" + fileInfo.Name;
                Miniatura.Width = Unit.Pixel(100);
                Miniatura.Height = Unit.Pixel(100);
                Miniatura.Style.Add("padding", "5px");
                Miniatura.Click += new ImageClickEventHandler(imageButton_Click);
                Panel1.Controls.Add(Miniatura);
            }
        }
        void imageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~\\Obraz.aspx?ImageURL=" + ((ImageButton)sender).ImageUrl);
        }

        protected void bStrona1_Click(object sender, EventArgs e)
        {
            Server.Transfer("MainPrzegladarka.aspx", true);
        }
    }
}
