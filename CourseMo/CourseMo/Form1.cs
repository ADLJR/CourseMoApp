using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseMo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var vault = new CourseMo.DataAccess();
      var students = vault.StudentList();
      var courses = vault.CoursesList();
      
      // Display students
      foreach (Student s in students) {
        this.studentListBox.Items.Add(s);
      }

      // Display courses
      foreach (Course c in courses)
      {
        this.coursesListBox.Items.Add(c);
      }

    }

    private void coursesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      // clear waitlist and enrolllist everytime a new course is selected
      this.enrollListBox.Items.Clear();
      this.waitListBox.Items.Clear();


      // assign selected cousre
      var selected = this.coursesListBox.SelectedItem;
      var selectCourse = (Course)selected;

      // display info about selected course
      this.classTextBox.Text = (selectCourse.CSize).ToString();
      this.semesterTextBox.Text = selectCourse.Semester;
      this.dayTextBox.Text = selectCourse.CDay;
      this.enrollTextBox.Text = (selectCourse.CSize).ToString();
      this.timeTextBox.Text = selectCourse.CTime;
      this.typeTextBox.Text = selectCourse.CType;
      this.yearTextBox.Text = (selectCourse.Term).ToString();
      this.waitTextBox.Text = (selectCourse.Waitlists.Count).ToString();
      this.enrollTextBox.Text = (selectCourse.Registereds.Count).ToString();

      // display students enrolled in course
      var studentsReg = selectCourse.Registereds;

      foreach (Registered showID in studentsReg) {
        this.enrollListBox.Items.Add(showID.NetID);
      }

      // display students enrolled in course
      var studentsWait = selectCourse.Waitlists;

      foreach (Waitlist showID in studentsWait)
      {
        this.waitListBox.Items.Add(showID.NetID);
      }
    }
  }
}
