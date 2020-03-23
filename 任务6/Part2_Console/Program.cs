using Part2_ClassLib;

namespace Part2_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student("cgf2", 10);
            Person person = new Person("fgc2", 11);

            student.Show();
            person.Show();
        }
    }
}