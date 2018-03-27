using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApi.Models
{
  public class Gemeente
  {
	 //private properties
	 private int _gemeenteID;
	 private string _gemeenteNaam;
	 private string _postcode;

	 //publieke properties
	 public int GemeenteID
	 {
		get
		{
		  return _gemeenteID;
		}
		set
		{
		  _gemeenteID = value;
		}
	 }
	 public string GemeenteNaam
	 {
		get
		{
		  return _gemeenteNaam;
		}
		set
		{
		  _gemeenteNaam = value;
		}
	 }
	 public string Postcode
	 {
		get
		{
		  return _postcode;
		}
		set
		{
		  _postcode = value;
		}
	 }

	 //constructor
	 public Gemeente(int pgemeenteid, string pgemeentenaam, string ppostcode )
	 {
		_gemeenteID = pgemeenteid;
		_gemeenteNaam = pgemeentenaam;
		_postcode = ppostcode;
	 }

	 //methode
	 public static Gemeente Create(DataRow dr)
	 {
		return new Gemeente((int)dr[0], dr[1].ToString( ) , dr[2].ToString( ));
	 }
  }
}