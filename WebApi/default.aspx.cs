using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApi.Controllers;

namespace WebApi
{
  public partial class _default : System.Web.UI.Page
  {
	ValuesController con = new ValuesController( );
	protected void Page_Load(object sender, EventArgs e)
	{
	  foreach(Beleg bel in con.Get("beleg", new string[] { "belegID", "beleg" }, ""))
	  {
		lblTest.Text += " " + bel.Beeleg + " , ";
	  }
	}
  }
}