using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

[Table (Name = "topics")]
public class Topic
{

    [Column(Name = "topicid", IsPrimaryKey = true, IsDbGenerated=true )]
    public int TopicId { get; set; }

    [Column(Name = "batchid" )]
    public int BatchId { get; set; }

    [Column(Name = "day")]
    public DateTime Day { get; set; }

    [Column(Name = "topics")]
    public string Topics { get; set; }

    [Column(Name = "exercises")]
    public string Exercises { get; set; }

}