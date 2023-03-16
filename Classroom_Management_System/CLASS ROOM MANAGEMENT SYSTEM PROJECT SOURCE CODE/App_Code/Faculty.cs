using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

[Table( Name="Faculty")]
public class Faculty
{
    [Column ( Name="facid", IsPrimaryKey = true, IsDbGenerated = true)]
	public int Facid {get; set;}
    [Column (Name="facname") ]
    public string Facname { get;set;}
    [Column(Name = "password")]
    public string Password { get; set; }
    [Column(Name = "email")]
    public string Email  { get;set; }
    [Column(Name = "qualification")]
    public string Qualification { get; set; }
}