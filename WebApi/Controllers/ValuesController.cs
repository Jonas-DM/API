using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;

namespace WebApi.Controllers
{
  public class ValuesController : ApiController
  {
	MySqlConnection conn = WebApiConfig.conn();

	// GET api/values
	//public IEnumerable<string> Get( )
	//{
	//  return new string[] { "value1", "value2" };
	//}

	public List<Beleg> lijst = new List<Beleg>( );

	// GET api/values/5
	//public List<Beleg> Get(int id)
	//{
	//  MySqlConnection conn = WebApiConfig.conn( );

	//  //MySqlCommand query = conn.CreateCommand( );

	//  //query.CommandText = "SELECT * FROM beleg";
	//  string query = "SELECT * FROM " + tabel;
	//  MySqlCommand cmd = new MySqlCommand( query, conn);
	//  try
	//  {
	//	conn.Open( );
	//  }
	//  catch(MySql.Data.MySqlClient.MySqlException ex)
	//  {


	//  }

	//  MySqlDataReader reader = cmd.ExecuteReader( );


	//  while(reader.Read())
	//  {
	//	lijst.Add(new Beleg(reader.GetInt32(0), reader.GetString(1)));
	//  }
	//  conn.Close( );

	//  return lijst;
	//}

	public List<object> Get(string tabel, string[] velden, string where)
	{
	  //Type t = Type.GetType(tabel, true);
	  //Debug.WriteLine(t.ToString());
	  string q = "SELECT ";
	  int x = 1;
	  foreach(string veld in velden)
	  {
		if(x == velden.Length)
		{
		  q += veld + " ";
		  continue; //zodat het volgend statement niet wordt uitgevoerd.
		}
		q += veld + ", ";
		x++;
	  }

	  q += "FROM " + tabel; 

	  MySqlCommand cmd = new MySqlCommand(q, conn);
	  conn.Open( );
	  MySqlDataReader reader = cmd.ExecuteReader( );

	  List<object> lijst = new List<object>( );

	  while(reader.Read( ))
	  {
		lijst.Add(new Beleg(reader.GetInt32(0), reader.GetString(1)));
	  }

	  return lijst;
	}

	// POST api/values
	public void Post([FromBody]string value)
	{
	}

	// PUT api/values/5
	public void Put(int id, [FromBody]string value)
	{
	}

	// DELETE api/values/5
	public void Delete(int id)
	{
	}
  }

  public class Beleg
  {
	private int id;
	private string beleg;

	public Beleg(int id, string beleg)
	{
	  this.id = id;
	  this.beleg = beleg;
	}

	public int Id
	{
	  get => id;
	  set => id = value;
	}
	public string Beeleg
	{
	  get => beleg;
	  set => beleg = value;
	}
  }
}
