using Part7_ClassLib;

namespace Part7_Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ISportsman bas = new Basketballman();
            ISportsman foo = new Footballman();

            bas.Jump();
            foo.Jump();
            bas.Run();
            foo.Run();
        }
    }
}