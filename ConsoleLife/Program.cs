using System;
//using System.Runtime.InteropServices;

namespace ConsoleLife
{
    public class Program
    {
        //[DllImport("kernel32.dll", ExactSpelling = true)]
        //private static extern IntPrt GetConsoleWindow();

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //private static extern bool ShowWindow(IntPrt hWnd, int cCmdShow);

        public static void Main(string[] args)
        {
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //ShowWindow(GetConsoleWindow(), MAXIMIZE);

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            
            //1366*768
            var ge = new GEngine(rows: 120,
                cols: 448,
                density: 2);

            while (true)
            {
                Console.Title = ge.CurrentGeneration.ToString();

                var field = ge.GetCurrentGeneration();

                for (var y = 0; y < field.GetLength(1); y++)
                {
                    var str = new char[field.GetLength(0)];

                    for (var x = 0; x < field.GetLength(0); x++)
                    {
                        if (field[x, y])
                            str[x] = '#';
                        else
                            str[x] = ' '; 
                    }
                    Console.WriteLine(str);
                }

                Console.SetCursorPosition(0, 0);
                ge.NextGeneration();
            }
        }
    }
}
