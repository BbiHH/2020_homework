using Part1_ClassLib;

namespace Part1_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student("cgf", 10);
            Person person = new Person("fgc", 11);

            student.Show();
            person.Show();
        }
    }
}