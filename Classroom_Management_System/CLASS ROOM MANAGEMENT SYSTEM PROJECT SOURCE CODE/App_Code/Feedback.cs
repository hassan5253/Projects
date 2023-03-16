using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Data.Linq;

[Table   (Name="feedback")]
public class Feedback
{
    [Column (Name="feedbackid", IsDbGenerated = true, IsPrimaryKey = true)]
    public int FeedbackId { get; set; }
    [Column (Name = "studid")]
    public int StudId { get; set; }
    [Column (Name = "postedon")]
    public DateTime PostedOn { get; set; }
    [Column (Name = "feedback")]
    public string  FeedbackText { get; set; }
    [Column (Name = "reply")]
    public string Reply { get; set; }

    public string StudentName
    {
        get
        {
           return Student.Studname;
        }
    }

    public int  BatchId
    {
        get
        {
            return Student.Batchid;
        }
    }

    // association with Student 
    private EntityRef<Student> stud;
    [Association(Storage = "stud", ThisKey = "StudId")]
    public Student Student
    {
        get
        {
            return stud.Entity;
        }
        set
        {
            stud.Entity = value; 
        }
    }

   

}