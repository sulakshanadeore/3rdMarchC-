using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string myxml = @"<Departments>
                    <Department>Accounts</Department>
                    <Department>Sales</Department>
                    <Department>HR</Department>
                    <Department>Marketing</Department>
                    <Department>IT</Department>
                        </Departments>";
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument doc = new XDocument();
            doc = XDocument.Parse(myxml);

            var result = doc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Response.Write(item.Value + "<br/>");
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\deore\source\repos\WebApplication2\WebApplication2\App_Data\empdata.xml";
            // XDocument doc = new XDocument();
            XElement doc1 = XElement.Load(filename);
            //var result = doc1.Descendants("employees");
            
            var rdata=from ed in doc1.Descendants("employees")
                      select new{  id=ed.Element("EmployeeID").Value,
                      ename=ed.Element("FirstName").Value};

            foreach (var item in rdata)
            {
                Response.Write(item.id + "  " + item.ename + "<br/>");

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\deore\source\repos\WebApplication2\WebApplication2\App_Data\empdata.xml";
            // XDocument doc = new XDocument();
            XElement doc1 = XElement.Load(filename);
            var rdata = from ed in doc1.Descendants("employees")
                        where Convert.ToInt32(ed.Element("EmployeeID").Value)==5
                        select new
                        {
                            id = ed.Element("EmployeeID").Value,
                            ename = ed.Element("FirstName").Value
                        };

            foreach (var item in rdata)
            {
                Response.Write(item.id + "  " + item.ename + "<br/>");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\deore\source\repos\WebApplication2\WebApplication2\App_Data\empdata.xml";
            XDocument doc = XDocument.Load(filename);
            doc.Element("NewDataSet").Add(new XElement("employees", new XElement("EmployeeID", 21), new XElement("FirstName", "Suraj"), new XElement("LastName", "khanna")));
            doc.Save(filename);
                }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=spd\\sqlexpress;Initial Catalog=northwind;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from employees", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "employees");
            ds.WriteXml(@"C:\Users\deore\source\repos\WebApplication2\WebApplication2\App_Data/empdata.xml");

        }
    }
}