using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._7ConsoleApp1
{
        internal class Program
        {
            static void Main(string[] args)
            {

                string firstName = "Алексей";
                string secondName = "Коробов";
                string thirdName = "Олегович";
                byte age = 30;
                string email = "myryty@mail.ru";
                float markProgramming = 88.545f;
                float markMath = 97.647f;
                float markPhysics = 91.233f;
                float Σ = markProgramming + markMath + markPhysics;
                double Σaverage = Σ / 3;


                //string pattern1 = "Ф.И.О.: {0} Возраст: {1} Email: {2} Баллы по программированию: {3} Баллы по математике: {4} Баллы по физике: {5}; ";

                string pattern2 = "Ф.И.О.: {0} " +
                    "\nВозраст: {1} " +
                    "\nEmail: {2} " +
                    "\nБаллы по программированию: {3} " +
                    "\nБаллы по математике: {4} " +
                    "\nБаллы по физике: {5}";


                Console.WriteLine(pattern2,
                        secondName + " " + firstName + " " + thirdName + " ",
                        age,
                        email,
                        markProgramming,
                        markMath,
                        markPhysics);

                Console.ReadKey();

                //console.writeline(secondname + " " + firstname + " " + thirdname +  " " + age + " " + email + markprogramming + markmath + markphysics);


                string pattern3 = "\nСумма баллов: {0} " +
                    "\nСредний балл: {1} ";


                Console.WriteLine(pattern3,
                       Σ,
                       Σaverage.ToString("#.###"));


                Console.ReadLine();





            }
        }
    }
