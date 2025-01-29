namespace InterfaceTrain2
{
    public class InterfaceExample
    {

        void setAStudent()
        {
            IStudent aung;
            aung = ReturnAStudent();
        }
        IStudent ReturnAStudent()
        {
            return new Student("Aung", 26);
        }
    }


    class Student : IStudent
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Student()
        {
        }
    }

    interface IStudent
    {
        string Name { get; set; }
        int Age { get; set; }

    }
}