using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class FacultyDAL
{
    public static string Login(string facid, string password)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var faculty = (from fac in dc.Faculties
                           where fac.Facid == Int32.Parse(facid) &&
                                 fac.Password == password
                           select fac).SingleOrDefault();

            if (faculty != null)
                return faculty.Facname;
            else
                return null;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.Login() -> " + ex.Message);
            return null; 
        }
    }

    public static  List<Batch> GetRunningBatches(string facid)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var batches = from batch in dc.Batches
                          where batch.FacId == Int32.Parse(facid)
                          &&   batch.EndDate.HasValue == false 
                          select batch;
            return batches.ToList();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.GetRunningBatches() -> " + ex.Message);
            return null;
        }
    }

    public static List<Topic> GetTopics(string batchid)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var  topics = from topic in dc.Topics
                          where topic.BatchId == Int32.Parse(batchid)
                          orderby topic.Day descending 
                          select topic;
            return topics.ToList();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.GetTopics() -> " + ex.Message);
            return null;
        }
    }

    public static List<Feedback> GetFeedbacks(string facid)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var feedbacks = from feedback in dc.Feedbacks 
                         where feedback.Student.Batch.FacId == 
                                     Int32.Parse(facid)
                         orderby feedback.PostedOn descending
                         select feedback;
            return feedbacks.ToList();
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.GetFeedbacks() -> " + ex.Message);
            return null;
        }
    }

    public static bool UpdateFeedback(string feedbackid, string reply)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var feedback = (from fb in dc.Feedbacks
                            where fb.FeedbackId == Int32.Parse(feedbackid)
                            select fb).SingleOrDefault();
            feedback.Reply = reply;
            dc.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.UpdateFeedback() -> " + ex.Message);
            return false;
        }
    }
    
    public static Feedback GetFeedback(string feedbackid)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var feedback = (from fb in dc.Feedbacks
                      where fb.FeedbackId == Int32.Parse(feedbackid)
                      select fb).SingleOrDefault();
            return feedback;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.GetFeedback() -> " + ex.Message);
            return null;
        }
    }

    public static bool DeleteTopic(string topicid)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var selectedtopic = (from topic in dc.Topics
                         where topic.TopicId == Int32.Parse(topicid)
                         select topic).SingleOrDefault();
            dc.Topics.DeleteOnSubmit(selectedtopic);
            dc.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.DeleteTopics() -> " + ex.Message);
            return false;
        }
    }

    public static bool AddTopics(string batchid,
           DateTime day, 
           string topics,
           string exercises)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            Topic t = new Topic
            {
                BatchId = Int32.Parse(batchid),
                Day = day,
                Topics = topics,
                Exercises = exercises
            };
            dc.Topics.InsertOnSubmit(t);
            dc.SubmitChanges();
            return true;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in FacultyDAL.AddTopics() -> " + ex.Message);
            return false;
        }
        
    }
}