using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LaboratorijskaVjezba5
{
    public partial class LogIn : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private bool CheckUsernameAndPassword()
        {
            XElement korisnici = XElement.Load(@"C:\Users\PavleP\source\repos\VSITE_ProgCS\LaboratiorijskeVjezbe\PetaLaboratorijskaVjezba\LaboratorijskaVjezba5\LaboratorijskaVjezba5\App_Data\korisnici.xml");
            var users = from user in korisnici.Elements("korisnik")
                select new {username = (string)user.Element("korisnickoIme"), password = (string)user.Element("lozinka")};

            foreach (var user in users)
            {
                if (String.Compare(user.username, this.Username.Text, true) == 0 && user.password == this.Password.Text)
                {
                    return true;
                }
            }

            return false;
        }

        private void DisplayBooks()
        {
            this.PanelDisplay.Visible = true;
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@"C:\Users\PavleP\source\repos\VSITE_ProgCS\LaboratiorijskeVjezbe\PetaLaboratorijskaVjezba\LaboratorijskaVjezba5\LaboratorijskaVjezba5\App_Data\popisKnjiga.xml");
                this.GridViewData.DataSource = ds;
                this.GridViewData.DataBind();
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (!this.CheckUsernameAndPassword())
            {
                this.PanelError.Visible = true;
            }
            else
            {
                DisplayBooks();
            }
        }


    }
}