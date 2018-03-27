using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
  public class Beleg
  {
	 //private properties
	 private int _id;
	 private string _topping;

	 //publieke properties
	 public string Topping
	 {
		get
		{
		  return _topping;
		}
		set
		{
		  _topping = value;
		}
	 }
	 public int Id
	 {
		get
		{
		  return _id;
		}
		set
		{
		  _id = value;
		}
	 }

	 //constructor
	 public Beleg(int pid, string ptopping )
	 {
		_id = pid;
		_topping = ptopping;
	 }
	 public Beleg( )
	 {

	 }

	 //methode
	 public static Beleg Create(DataRow dr)
	 {
		return new Beleg((int)dr[0], dr[1].ToString());
	 }
  }
}