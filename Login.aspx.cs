using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoSecurity
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Step 1
            //command for adding membership to the application
            //aspnet_regsql - S SPD\SQLEXPRESS - E - A m -d nameofDB

            //Step 2
            //open web.config--- register the providers with application--AspNetSqlMembershipProvider & AspNetSqlRoleProvider
            //<system.web>
            //<membership>
    //<providers>
    //<clear/>
    //<add name = "AspNetSqlMembershipProvider" type = "System.Web.Security.SqlMembershipProvider"
    //connectionStringName = "demosecurity" />
        //  </ providers >
    //</membership >
    //<roleManager enabled = "true" >
 
    //   <providers>
 
    //     < clear />
 
    //     < add name = "AspNetSqlRoleProvider" type = "System.Web.Security.SqlRoleProvider" connectionStringName = "demosecurity" />
      
    //        </ providers >
      

    //      </ roleManager >


        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(Login1.UserName,Login1.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName,false);

                if (Login1.RememberMeSet == true)
                {
                    FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
                }
                
            }
        }
    }
}