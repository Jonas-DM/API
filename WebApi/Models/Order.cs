using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApi.Models
{
  public class Order
  {
	 //private properties
	 private int _orderID;
	 private DateTime _datum;
	 private DateTime _afhaalTijdstip;
	 private bool _verwerkt;
	 private int _broodjesID;
	 private int _klantID;

	 //publieke properties
	 public int OrderID
	 {
		get
		{
		  return _orderID;
		}
		set
		{
		  _orderID = value;
		}
	 }
	 public DateTime Datum
	 {
		get
		{
		  return _datum;
		}
		set
		{
		  _datum = value;
		}
	 }
	 public DateTime Afhaaltijdstip
	 {
		get
		{
		  return _afhaalTijdstip;
		}
		set
		{
		  _afhaalTijdstip = value;
		}
	 }
	 public bool Verwerkt
	 {
		get
		{
		  return _verwerkt;
		}
		set
		{
		  _verwerkt = value;
		}
	 }
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

	 //constructors
	 public Order(int porderid, DateTime pdatum, DateTime pafhaaltijdstip, bool pverwerkt, int pbroodjesid, int pklantid )
	 {
		_orderID = porderid;
		_datum = pdatum;
		_afhaalTijdstip = pafhaaltijdstip;
		_verwerkt = pverwerkt;
		_broodjesID = pbroodjesid;
		_klantID = pklantid;
	 }
	 public Order( )
	 {

	 }

	 //methodes
	 public static Order Create(DataRow dr)
	 {
		return new Order((int)dr[0], (DateTime)dr[1], (DateTime)dr[2], (bool)dr[3], (int)dr[4], (int)dr[5]);
	 }


  }
}