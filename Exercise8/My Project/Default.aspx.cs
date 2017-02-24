using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Project
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int Zero = 0;
                int Error = 1 / Zero;
            }
            catch (Exception Ex) 
            {
                Response.Write(Ex.Message);
            }
        }
    }
}