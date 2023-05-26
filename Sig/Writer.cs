using System;
using System.IO;
using SharedLibra;

namespace Writer
{
    class Writer
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine("Введите информацию для записи в файл:");
            string input = Console.ReadLine();
            singleton.SetData(input);

            // Запись информации в файл
            string filePath = "example.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Информация успешно записана в файл.");
            Console.ReadLine();
        }
    }

}

