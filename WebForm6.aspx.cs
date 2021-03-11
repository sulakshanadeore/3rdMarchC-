using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace FirstWebApplication
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string photoname = null;
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                   string fname = FileUpload1.FileName;
                FileUpload1.SaveAs(@"D:\Sulakshana\IBMC#\FirstWebApplication\FirstWebApplication\DocumentsAndImages\" + fname);

            }
            if (FileUpload2.HasFile)
            {
             photoname= FileUpload2.FileName;
                FileUpload2.SaveAs(@"D:\Sulakshana\IBMC#\FirstWebApplication\FirstWebApplication\DocumentsAndImages\" + photoname);
                string fname= (@"D:\Sulakshana\IBMC#\FirstWebApplication\FirstWebApplication\DocumentsAndImages\" + photoname);
                Image1.ImageUrl = "~/DocumentsAndImages/" + photoname;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream(@"D:\Sulakshana\IBMC#\FirstWebApplication\FirstWebApplication\DocumentsAndImages\" + photoname,FileMode.Open,FileAccess.Read);
            //BinaryReader br = new BinaryReader(fs);
            //byte[] arr=br.ReadBytes(Convert.ToInt32(fs.Length));
            Image1.ImageUrl = FileUpload2.FileName;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (CheckBoxList1.SelectedItem=="C#")
            //{

            //}
            TextBox2.Text = "";
            for (int i = 0; i < 4; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {

                    TextBox2.Text += CheckBoxList1.Items[i].Text + ",";
                }
                
            }
            
        }
    }
}