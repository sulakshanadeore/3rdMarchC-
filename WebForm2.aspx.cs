using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected override void OnPreInit(EventArgs e)
        {
            base.OnPreInit(e);
            this.MasterPageFile = "~/MySite.Master";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}