using System;

namespace WhatsCountSymbolsStr {
    class Program {
        static void Main() {
            string str = Console.ReadLine();
            // Разбивает строку на массив подстрок для поиска кол-ва слов в строке
            var colStr = str.Split(" ");
            Console.WriteLine(str);
            // Получает кол-во словв строке
            Console.WriteLine(colStr.Length);
            Console.ReadKey();
        }
    }
}
