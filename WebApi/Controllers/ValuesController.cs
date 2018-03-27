using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using WebApi.Models;



namespace WebApi.Controllers
{
  [System.Web.Http.RoutePrefix("api/broodjes")]
  public class ValuesController : ApiController
  {
	 [System.Web.Http.Route("{id:int}")]
	 
	 //GET = ophalen
	 //POST = aanmaken
	 //PUT = update
	 //DELETE = verwijderen

	 //GET api/values

	 

	 public IEnumerable<string> Get( )
	 {
		
		return new string[] { "value1", "value2" };
	 }

	 //GET api/values/5
	 public string Get(int id)
	 {
		return "value";
	 }

	 //POST api/values
	 public void Post([FromBody]string value)
	 {
	 }

	 

	 MySqlConnection conn = WebApiConfig.conn( );

	 public ResponseModel  Get(string tabel, string[] velden, string where, object klasse)
	 {
		Type t = klasse.GetType( );
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

		DataTable dt = new DataTable( );
		dt.Load(cmd.ExecuteReader( ));
		conn.Close( );

		List<object> lijst = new List<object>( );

		foreach(DataRow row in dt.Rows)
		{
		  lijst.Add(t.GetMethod("Create").Invoke(null, new object[] { row }));
		}

		ResponseModel respModel = new ResponseModel
		{
		  Data = lijst,
		  Status = true,
		  Message = "Data Recieved"
		};

		return respModel;
	 }
  }

  public class ResponseModel
  {
	 public string Message
	 {
		set; get;
	 }
	 public bool Status
	 {
		set; get;
	 }
	 public object Data
	 {
		set; get;
	 }
  }
}
