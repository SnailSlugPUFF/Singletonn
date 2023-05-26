using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SingletonCfg;

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

            string filePath = "content.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Информация успешно записана в файл.");
            Console.ReadLine();
        }

    }
}
