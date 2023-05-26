using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SingletonCfg;

namespace Reader
{
    class Reader
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;

            string filePath = @"D:\C#\Singleton-main\Sig\Rud\bin\Debug\content.txt";
            string content = string.Empty;
            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
            }

            singleton.SetData(content);

            Console.WriteLine("Прочитанная информация из файла: " + singleton.GetData());
            Console.ReadLine();
        }
    }
}
