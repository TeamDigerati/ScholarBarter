using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reimers.Google.Map;

namespace ScholarBarter
{
    public partial class userLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Map1.MapControls.Add(new Reimers.Google.Map.Controls.ZoomControl());
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // Show scholarBarter UserLocation in map

           
        }
    }
}