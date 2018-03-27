using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApi.Models
{
  public class Broodje
  {
	 private int _broodjesID;
	 private string _naamBroodje;
	 private string _prijsBroodje;
	 private string _omschrijving;
	 private string _aanpassing;


	 public int BroodjesID
	 {
		get
		{
		  return _broodjesID;
		}
		set
		{
		  _broodjesID = value;
		}
	 }
	 public string NaamBroodje
	 {
		get
		{
		  return _naamBroodje;
		}
		set
		{
		  _naamBroodje = value;
		}
	 }
	 public string PrijsBroodje
	 {
		get
		{
		  return _prijsBroodje;
		}
		set
		{
		  _prijsBroodje = value;
		}
	 }
	 public string Omschrijving
	 {
		get
		{
		  return _omschrijving;
		}
		set
		{
		  _omschrijving = value;
		}
	 }
	 public string Aanpassing
	 {
		get
		{
		  return _aanpassing;
		}
		set
		{
		  _aanpassing = value;
		}
	 }

	 public Broodje(int pbroodjesid, string pnaambroodje, string pprijsbroodje, string pomschrijving, string paanpassing )
	 {
		_broodjesID = pbroodjesid;
		_naamBroodje = pnaambroodje;
		_prijsBroodje = pprijsbroodje;
		_omschrijving = pomschrijving;
		_aanpassing = paanpassing;
	 }

	 public Broodje( )
	 {

	 }

	 public static Broodje Create(DataRow dr)
	 {
		return new Broodje((int)dr[0], dr[1].ToString( ), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
	 }



  }
}