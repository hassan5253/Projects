using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;


public class ClassroomDataContext : DataContext 
{
	public ClassroomDataContext() : base(Database.ConnectionString )
	{
	}
    public Table<Batch> Batches
    {
        get
        {
            return GetTable<Batch>();
        }
    }
    public Table<Faculty> Faculties 
    {
        get
        {
            return GetTable<Faculty>();
        }
    }
    public Table<Student> Students
    {
        get
        {
            return GetTable<Student>();
        }
    }

    public Table<Topic> Topics
    {
        get
        {
            return GetTable<Topic>();
        }
    }

    public Table<Feedback> Feedbacks 
    {
        get
        {
            return GetTable<Feedback>();
        }
    }


}