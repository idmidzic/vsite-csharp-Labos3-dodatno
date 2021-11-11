using System;


namespace C_sharp_vj2
{
    public class NotRealRootsException : ArithmeticException
    {
        public NotRealRootsException(string message): base(message)
        {
            Console.WriteLine(message);
        }
        public NotRealRootsException()
        {
           
        }
    }
}
