using System;

namespace picture
{
    class Program
    {
        static void Main(string[] args)
        {
            int picture = 52;
            int zone = 3;
            int row;

            row = picture / zone;
            picture %= zone;
            Console.WriteLine("Полных рядов будет - " + row + ",остаток - " + picture);
        }
    }
}
