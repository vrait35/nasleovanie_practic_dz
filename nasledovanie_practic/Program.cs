using System;

namespace nasledovanie_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int y = 2;
            while (true)
            {
                Show(y);
                 key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow) { if (y < 5) y++; }
                else if (key.Key == ConsoleKey.UpArrow) { if (y > 2) y--; }
            }







            File file1 = new File("anuar.txt", 200);
            File file2 = new File("Oleg.jpg", 300.956);
            File file3 = new File("Mfsd.docx", 545.34);
            Storage st = new Storage();
            st.Transfer(file1);
            st.Transfer(file2);
            st.Transfer(file3);
            Console.WriteLine("Содержимое в флешке: ");
            foreach(File mas in st.GetFile())
            {
                Console.WriteLine("Имя файла: {0} " +
                    " Рзмер файла: {1}",mas.FileName,mas.Size);
            } 
        }
        static void Show(int y)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (y == 1) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 1);
            Console.Write("┌────────────────────────────────────────────────────┐");
            if (y == 2) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 2);
            Console.Write(" расчет общего количества памяти всех устройств");
            if (y == 3) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 3);
            Console.Write(" копирование информации на устройства ");
            if (y == 4) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 4);
            Console.Write(" расчет времени необходимого для копирования");
            if (y == 5) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 5);
            Console.Write("расчет необходимого количества носителей информации ");
            if (y == 6) Console.ForegroundColor = ConsoleColor.DarkRed;
            else Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, 6);
            Console.Write("└────────────────────────────────────────────────────┘");
        }
    }
}
