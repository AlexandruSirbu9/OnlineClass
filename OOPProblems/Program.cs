namespace OOPProblems
{
    class Program
    {
        static void Main(string[] args)
        {
           Person person= new Person();
            person.Greet();

            Student student = new Student();
            student.Greet();
            student.AfisareVarsta(24);

            Student student1= new Student();
            student1.SetAge(18);
            student1.AfisareVarsta(2000);

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.SetAge(30);
            teacher.Explain();


        }
    }
}