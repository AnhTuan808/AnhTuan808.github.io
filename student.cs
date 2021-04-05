using System;
using System.Collections.Generic;
using System.Text;

namespace AppOOP
{
    class Student
    {
        private string name;

        private void btnTalk_Click(object sender, RoutedEventArgs e) 
        {
            Student st1 = new Student("Tuan");
            st1.Talk();
            Student st2 = new Student();
            st2.StudentName = "Nhan";
            st2.Talk();
        }
    }
}
