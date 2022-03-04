using System;

namespace Stealer
{
    class Stealer
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            Console.WriteLine(spy.StealFieldInfo("Hacker", "username", "password"));
        }
    }
}
