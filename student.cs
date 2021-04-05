    class Student
    {
        private string name;

        public string StudentName 
        {
            get
            {
                return name; 
            }
            set
            {
                name = value; 
            }
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
    }
