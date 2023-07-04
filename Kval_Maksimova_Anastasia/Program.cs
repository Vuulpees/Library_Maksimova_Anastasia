using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Kval_Maksimova_Anastasia
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Команда ", "ул Красная Пресня\n");
            Player player1 = new Player("Иванов Перт Игоревич ", "Вратарь\n");
            Console.WriteLine("-------------------------------");

            Player player2 = new Player("Смолов Иван Иванович", "Нападающий\n");
           

            List<object> objects = new List<object> { team, player1, player2 };

            
            foreach (var obj in objects)
            {
                Console.WriteLine(obj.ToString());



            }
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
}   }   

        
    

