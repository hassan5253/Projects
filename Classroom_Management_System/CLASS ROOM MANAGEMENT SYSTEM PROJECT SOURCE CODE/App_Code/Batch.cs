using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

[Table ( Name="batch")]
public class Batch
{
    [Column (Name="batchid", IsDbGenerated = true, IsPrimaryKey = true)]
    public int BatchId { get; set; }

    [Column(Name = "facid")]
    public int FacId { get; set; }

    [Column(Name = "subject")]
    public string Subject { get; set; }

    [Column(Name = "stdate")]
    public DateTime StartDate  { get; set; }

    [Column(Name = "enddate")]
    public Nullable<DateTime> EndDate { get; set; }
}