using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace menagerplików
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void refresh()
        {
            //string nazwa = FileUpload1.FileName;
            //ListaPlikow.Items.Clear();
            string katalog = Server.MapPath("~\\Files\\" );
            string[] listapl = Directory.GetFiles(katalog, "*.*",SearchOption.AllDirectories);
            foreach (string plik in listapl)
                ListaPlikow.Items.Add(Convert.ToString(Path.GetFileName(plik)));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                Response.Write("liczba użytkowników Online = " + Application["LiczbaUzytkownikow"].ToString());
 
            }

            if (!IsPostBack)
            {
                refresh();
            }

            ListaPlikow.SelectedIndexChanged += new EventHandler(ListaPlikow_SelectedIndexChanged);

        }

        protected void bDodaj_Click1(object sender, EventArgs e)
        {
            ListaPlikow.Items.Clear();
            if (IsPostBack)
            {
                string katalog = Server.MapPath("~\\Files\\");
                string nazwa = FileUpload1.FileName;
               
                Boolean Obraz = false;
                
                
                if (FileUpload1.HasFile)
                {
                    string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    string[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg", ".bmp" };
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            Obraz = true;
                        }
                    }
                }

                if (Obraz)
                {
                    try
                    {
                        katalog += "Fotki\\";
                        lHelp.Text = katalog;
                        FileUpload1.PostedFile.SaveAs(katalog + FileUpload1.FileName);
                        InfoPlik.Text = "Obraz zapisany";
                        ListaPlikow.Items.Clear();
                        
                        refresh();
                        
                    }
                    catch 
                    {
                        InfoPlik.Text = "Plik nie może być zapisany";
                        refresh();
                    }
                }
                else
                {
                    try
                    {
                        katalog += "Inne\\";

                        lHelp.Text = katalog;

                        FileUpload1.PostedFile.SaveAs(katalog + FileUpload1.FileName);
                        InfoPlik.Text = "Plik zapisany";
                        ListaPlikow.Items.Clear();

                        refresh();
                    }
                    catch
                    {
                        InfoPlik.Text = "Plik nie może być zapisany";
                        refresh();
                    }
                }
                
                
            }
        }

        
        
        protected void bUsun_Click1(object sender, EventArgs e)
        {

            if (System.IO.Directory.Exists(lHelp.Text))
                try
                {
                        System.IO.File.Delete(lHelp.Text + ListaPlikow.SelectedItem);
                        lHelp.Text = ("plik usunięty");
                        ListaPlikow.Items.Clear();

                        refresh();
                }
                catch
                {
                    lHelp.Text = ("błąd przy usuwaniu");
                }
        }
        
       
        
        protected void ListaPlikow_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                                   
            string fileExt = System.IO.Path.GetExtension(ListaPlikow.SelectedItem.Text).ToLower();
            string katalog = Server.MapPath("~\\Files\\");
            Boolean Obraz = false;

            string[] Graficzne = { ".gif", ".png", ".jpeg", ".jpg", ".bmp" };
            for (int i = 0; i < Graficzne.Length; i++)
            {
                if (fileExt == Graficzne[i])
                {
                    Obraz = true;
                }
            }
            if (Obraz)
            {
                try
                {
                    katalog += "Fotki\\";
                    lHelp.Text = katalog;
                }
                catch
                {
                    InfoPlik.Text = "Błędny wybór";
                    refresh();
                }
            }
            else
            {
                try
                {
                    katalog += "Inne\\";
                    lHelp.Text = katalog; 
                }
                catch
                {
                    InfoPlik.Text = "błędny wybór";
                    refresh();
                }
            }
           
        }

        protected void bZmien_Click(object sender, EventArgs e)
        {
            if  (System.IO.Directory.Exists(lHelp.Text))
                
            {
                try
                {
                    string p = Path.Combine(lHelp.Text,ListaPlikow.SelectedItem.Text);
                    string filename = Path.GetFileNameWithoutExtension(p);
                    string extension = Path.GetExtension(p);
                    string newfile = (tbZmien.Text + extension);
                    System.IO.File.Move(p, lHelp.Text + newfile);
                    lHelp.Text = ("nazwa pliku zmieniona");
                    ListaPlikow.Items.Clear();

                    refresh();
                }
                catch
                {
                    lHelp.Text = ("błędna nazwa pliku");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void bDoGalerii_Click(object sender, EventArgs e)
        {
            Server.Transfer("Strona2.aspx", true);
        }

                
    }
}