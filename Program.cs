using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;//Espacio de nombres utilizado
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad=0;
            string cadena = "";
            Type type;



            type = edad.GetType();
            mostrarTipo(type);
            type = cadena.GetType();
            mostrarTipo(type);

            Personas personas = new Personas();
            //type = personas.GetType();
            

            
            type = typeof(Personas);

            PropertyInfo[] propertyInfo = type.GetProperties();
            foreach (PropertyInfo pInfo in propertyInfo)
            {
                Console.WriteLine(pInfo.Name);
            }


            var metodos = type.GetMethods();
            foreach (var item in metodos)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
        public static void mostrarTipo(Type type)
        {
            Console.WriteLine(type);
        }
    }
}
