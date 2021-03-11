using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = DropDownList1.SelectedValue;
            switch (name)
            {
                case "Personal"://Dropdown
                    MultiView1.SetActiveView(Personal);
                    break;
                case "Educational":
                    MultiView1.SetActiveView(Education);
                    break;
                case "Experience":
                    MultiView1.SetActiveView(JobExperience);
                    break;
                default:
                    break;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Education);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //int age=DateTime.Now.Year - Calendar1.SelectedDate.Year;
            //txtage.Text = age.ToString();
            txtage.Text = (DateTime.Now.Year - Calendar1.SelectedDate.Year).ToString();


        }
    }
}