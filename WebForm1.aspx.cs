using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceClientTrial.ServiceReference1;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ServiceClientTrial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new Service1Client();
            Employees[] emp = new Employees[] { };
            emp=proxy.GetDataEmployees();
            List<Employees> empdata = new List<Employees>();
            empdata = emp.ToList<Employees>();
            GridView1.DataSource = empdata;
            GridView1.DataBind();

            foreach (var item in empdata)
            {
                ListBox1.Items.Add(item.Empid + "  " + item.Fname);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:61722/Service1.svc/rest/GetEmployees");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            StreamReader sr = new StreamReader(responseStream,Encoding.GetEncoding("utf-8"));

            string json = sr.ReadToEnd();
            sr.Close();
            var empobj = json.Replace("[", "").Replace("]", "");
            Response.Write(empobj);
        }
    }
}