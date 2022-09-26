using System;

namespace Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInLine = 3;
            int allPictures = 52;

            int completedLines;
            int rest;

            completedLines = allPictures / countInLine;
            rest = allPictures % countInLine;

            Console.WriteLine($"если {allPictures} картинки разложить по {countInLine} в ряд, то получится {completedLines} рядов и один неполный ряд с {rest} картинками");
        }
    }
}
