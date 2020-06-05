using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance;

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
/*
    Singleton Design Pattern
    Burada ki amaç bir sınıftan bir instance oluşturmak ve yeni oluşturulacaksa var olanın 
    kulanılmasını sağlar.
    Bu tasarım deseninde constructer private olmalıdır. Bu yapılan işlem new
    ile nesne oluşturmasını engeller.
    class il aynı türde static bir mamber oluşturulur.
    static membera ulaşmak için ise static bir metod yazılır. 
     
*/
