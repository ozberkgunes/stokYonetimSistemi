using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinamaProje
{
    public  class Singleton
    {
        private static Singleton instance = null;
        public int temp;
        private Singleton()
        {

        }

        public static Singleton getInstance()
        {
            
            

                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;

            
        }
    }
}