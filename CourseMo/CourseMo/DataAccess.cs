using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMo
{
  class DataAccess
  {
    // created context of database
    private RegisterDBDataContext db;

    // constructor
    public DataAccess() {
      db = new RegisterDBDataContext();

    }

    // function to obtain list of students
    public IOrderedQueryable<Student> StudentList() {
      // create Linq to SQL object context

      var query = from s in db.Students
                  orderby s.LastName
                  select s;

      return query;

    }

    // function to obtain list of courses
    public IOrderedQueryable<Course> CoursesList()
    {
      // create Linq to SQL object context

      var query = from c in db.Courses
                  orderby c.CRN
                  select c;

      return query;

    }

    
  }
}
