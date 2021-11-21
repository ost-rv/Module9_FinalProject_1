using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_FinalProject_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Exception[] arrayException = {
                new MyException("Моё исключение"),
                new ArgumentException(),
                new TimeoutException(),
                new InvalidOperationException(),
                new OverflowException()
            };

            foreach (Exception exception in arrayException)
            {

                try
                {
                    throw exception;
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (TimeoutException ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.GetType().Name);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("----------------");
                }
            }
            Console.ReadLine();


        }
    }
}
