using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
  public class Openingsuur
  {
	 private int id;
	 private string openUur;
	 private string sluitUur;

	 public Openingsuur(int id, string openUur, string sluitUur)
	 {
		this.id = id;
		this.openUur = openUur;
		this.sluitUur = sluitUur;
	 }

	 public Openingsuur( )
	 {

	 }

	 public int Id
	 {
		get => id;
		set => id = value;
	 }
	 public string OpenUur
	 {
		get => openUur;
		set => openUur = value;
	 }
	 public string SluitUur
	 {
		get => sluitUur;
		set => sluitUur = value;
	 }

	 public static Openingsuur Create(DataRow dr)
	 {
		return new Openingsuur((int)dr[0], dr[1].ToString( ), dr[2].ToString( ));
	 }
  }
}