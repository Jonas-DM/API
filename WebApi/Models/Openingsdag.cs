using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApi.Models
{
  public class Openingsdag
  {
	 private int _openDagenID;

	 public int OpenDagenID
	 {
		get
		{
		  return _openDagenID;
		}
		set
		{
		  _openDagenID = value;
		}
	 }

	 private string _openDag;

	 public string Opendag
	 {
		get
		{
		  return _openDag;
		}
		set
		{
		  _openDag = value;
		}
	 }

	 public Openingsdag(int popeningsdagid, string popendag )
	 {
		_openDagenID = popeningsdagid;
		_openDag = popendag;
	 }

	 public static Openingsdag Create(DataRow dr)
	 {
		return new Openingsdag ((int)dr[0], dr[1].ToString( ));
	 }



  }
}