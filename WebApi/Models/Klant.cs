using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApi.Models
{
  public class Klant
  {
	 private int _klantID;
	 private string _inlognaam;
	 private string _naam;
	 private string _voornaam;
	 private string _adres;
	 private string _gsmnr;
	 private string _wachtwoord;
	 private string _gemeenteID;


	 public int KlantID
	 {
		get
		{
		  return _klantID;
		}
		set
		{
		  _klantID = value;
		}
	 }
	 public string Inlognaam
	 {
		get
		{
		  return _inlognaam;
		}
		set
		{
		  _inlognaam = value;
		}
	 }
	 public string Naam
	 {
		get
		{
		  return _naam;
		}
		set
		{
		  _naam = value;
		}
	 }
	 public string Voornaam
	 {
		get
		{
		  return _voornaam;
		}
		set
		{
		  _voornaam = value;
		}
	 }
	 public string Adres
	 {
		get
		{
		  return _adres;
		}
		set
		{
		  _adres = value;
		}
	 }
	 public string Gsmnr
	 {
		get
		{
		  return _gsmnr;
		}
		set
		{
		  _gsmnr = value;
		}
	 }
	 public string Wachtwoord
	 {
		get
		{
		  return _wachtwoord;
		}
		set
		{
		  _wachtwoord = value;
		}
	 }
	 public string GemeenteID
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

	 public Klant(int pklantid, string pinlognaam, string pnaam, string pvoornaam, string padres, string pgsmnr, string pwachtwoord, string pgemeenteid )
	 {
		_klantID = pklantid;
		_inlognaam = pinlognaam;
		_naam = pnaam;
		_voornaam = pvoornaam;
		_adres = padres;
		_gsmnr = pgsmnr;
		_wachtwoord = pwachtwoord;
		_gemeenteID = pgemeenteid;
	 }

	 public Klant( )
	 {

	 }

	 public static Klant Create(DataRow dr)
	 {
		return new Klant((int)dr[0], dr[1].ToString( ), dr[2].ToString( ), dr[3].ToString( ), dr[4].ToString( ), dr[5].ToString( ), dr[6].ToString( ), dr[7].ToString( ));
	 }





  }
}