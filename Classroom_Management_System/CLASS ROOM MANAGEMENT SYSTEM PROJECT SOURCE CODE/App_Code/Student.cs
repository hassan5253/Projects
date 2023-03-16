using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Data.Linq;

[Table (Name="student")]
public class Student
{
    [Column(Name = "studid", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Studid { get; set; }
    [Column(Name = "studname")]
    public string Studname { get; set; }
    [Column(Name = "password")]
    public string Password { get; set; }
    [Column(Name = "email")]
    public string Email { get; set; }
    [Column(Name = "batchid")]
    public int Batchid { get; set; }
    private EntityRef<Batch> m_batch;
    [Association(Storage = "m_batch", ThisKey = "Batchid")]

    public Batch Batch
    {
        get
        {
            return m_batch.Entity;
        }
        set
        {
            m_batch.Entity = value;
        }
    }
}