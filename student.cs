using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP
{
    class Student
    {
        private string name;

        public string StudentName 
        {
            get { return name; }
            set { name = value; }
        }
        public Student() { }
        public Student(string stName) 
        {
            name = stName; 
        }
        public virtual void Talk() 
        {
            MessageBox.Show(name);
        }
        private void btnTalk_Click(object sender, RoutedEventArgs e) 
        {
            Student st1 = new Student("Minh");
            st1.Talk();
            Student st2 = new Student();
            st2.StudentName = "Dung";
            st2.Talk();
        }
        private void btnTalk_click(object sender, RoutedEventArgs e)
        {
            StudentCollege college = new StudentCollege();
            college.StudentName = "Minh";
            college.Talk();
            StudentUniversity university = new StudentUniversity();
            university.StudentName = "Dung";
            university.Talk();
        }
        Student[] studentList = new Student[3];
        studentList.Add(new Student("Minh"));
        studentList.Add(new Student("Hoa"));
        studentList.Add(new Student("Dung"));
            foreach (Student st in studenList)
            {
                1st.Items.Add(st.StudentName);
            }
    }
}
