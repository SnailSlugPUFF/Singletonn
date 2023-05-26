using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonCfg
{
    public class Singleton
    {
       private static Singleton instance;
        private string data;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public string GetData()
        {
            return data;
        }

        public void SetData(string newData)
        {
            data = newData;
        }
    }
}
