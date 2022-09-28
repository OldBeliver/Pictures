using System;

namespace Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesInLine = 3;
            int allPictures = 52;

            int completedLines;
            int restPictures;

            completedLines = allPictures / picturesInLine;
            restPictures = allPictures % picturesInLine;

            Console.WriteLine($"если {allPictures} картинки разложить по {picturesInLine} в ряд, то получится {completedLines} рядов и один неполный ряд с {restPictures} картинками");
        }
    }
}
