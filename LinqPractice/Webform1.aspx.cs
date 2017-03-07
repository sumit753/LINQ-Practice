using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqPractice
{
    public partial class Webform1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext sdcObj = new SampleDataContext();

            //using Sql query like expression.
            IEnumerable<Student> queryResult = from student in sdcObj.Students
                                               where student.Gender == "Male"
                                               select student;

            GridView1.DataSource = queryResult;
            GridView1.DataBind();

            //using lambda expression
            IEnumerable<Student1> queryOutput = Student1.GetAllStudent1().Where(Student => Student.Gender == "Male");
            GridView2.DataSource = queryOutput;
            GridView2.DataBind();
        }
    }
}