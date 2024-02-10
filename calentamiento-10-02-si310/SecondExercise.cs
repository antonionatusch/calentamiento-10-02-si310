using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calentamiento_10_02_si310
{
    public class SecondExercise
    {

        public static int[] FibonacciSequence(int n) { 
            int[] sequence = new int[n];

            if(n >= 1)
                sequence[0] = 0;
            if (n >= 2)
                sequence[1] = 1;

            for (int i = 2; i < n; i++) {
                sequence[i] = sequence[i-1] + sequence[i-2];
            }

            return sequence;

        }


        public static List<int> FibonacciSequenceList(int n)
        {
            List<int> fibonacci = new List<int>();

            if (n >= 1)
                fibonacci.Add(0);
            if (n >= 2)
                fibonacci.Add(1);

            for (int i = 2; i < n; i++)
            {
                int nextFibonacciNumber = fibonacci[i - 1] + fibonacci[i - 2];
                if (nextFibonacciNumber <= int.MaxValue) 
                    fibonacci.Add(nextFibonacciNumber);
                else
                    break;
            }

            return fibonacci;
        }

        public static void Demo() {

   
            // de forma estatica

            Console.WriteLine("Digite la cantidad de numeros de fibonacci que desea generar: ");

            var numbers = Convert.ToInt32(Console.ReadLine());

            int[] fibonacciArray = FibonacciSequence(numbers);

            for (int i = 0; i < numbers; i++) {
                Console.WriteLine(fibonacciArray[i]);
            }

            Console.WriteLine("Secuencia en reversa: ");

            for (int i = numbers-1; i >= 0; i--)
            {
                Console.WriteLine(fibonacciArray[i]);
            }

            // con una lista

            Console.WriteLine("De forma dinamica: ");
            while (true)
            {
                Console.WriteLine("Digite la cantidad de elementos o enter para salir: ");
                var userOption = Console.ReadLine();

                if (String.IsNullOrEmpty(userOption)) {
                    break;
                }

                var changingNumbers = Convert.ToInt32(userOption);
                var fibonacciList = FibonacciSequenceList(changingNumbers);

                foreach (var fib in fibonacciList) {
                    Console.WriteLine(fib);
                }

            }


            }
            }


        }
    

