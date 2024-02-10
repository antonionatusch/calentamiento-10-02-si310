using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calentamiento_10_02_si310
{
    public class FirstExercise
    {
        public static void Demo() {
            int[] numbers = new int[30];

            Console.WriteLine("Digite la cantidad de elementos que desea agregar: ");
            var amountOfUserNumbers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfUserNumbers; i++)
            {
                Console.WriteLine($"Elemento {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ordenado: ");

            for (int i = 0; i < amountOfUserNumbers; i++) {
                for (int j = 0; j < amountOfUserNumbers - i - 1; j++) {
                    if (numbers[j] > numbers[j + 1]) { 
                        var temp = numbers[j+1];
                        numbers[j+1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < amountOfUserNumbers; i++) {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
