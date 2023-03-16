using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class StudentDAL
{
    public static string Login(string studid, string password)
    {
        try
        {
            ClassroomDataContext dc = new ClassroomDataContext();
            var student = (from stud in dc.Students 
                           where stud.Studid == Int32.Parse(studid) &&
                                 stud.Password == password
                           select stud).SingleOrDefault();

            if (student != null)
                return student.Studname;
            else
                return null;
        }
        catch (Exception ex)
        {
            HttpContext.Current.Trace.Write("Error in StudentDAL.Login() -> " + ex.Message);
            return null;
        }
    }
}