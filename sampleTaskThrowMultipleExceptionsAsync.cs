using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingAsynchronousExceptions
{
    public class sampleTaskThrowMultipleExceptionsAsync
    {
        public static void ThisIsATestMethod()
        {
            try
            {
                AsyncMethodReturningVoid();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static async void AsyncMethodReturningVoid()
        {
            throw new Exception("This is an error message...");
        }
        //--------------------------------------------
        public static async Task ExceptionInAsyncCodeDemo()
        {
            try
            {
                var task1 = Task.Run(() => throw new IndexOutOfRangeException
                   ("IndexOutOfRangeException is thrown."));
                var task2 = Task.Run(() => throw new ArithmeticException
                   ("ArithmeticException is thrown."));
                await Task.WhenAll(task1, task2);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //--------------------------------------------
        public static async Task ExceptionInAsyncAllCodeDemo()
        {
            Task tasks = null;
            try
            {
                var task1 = Task.Run(() => throw new IndexOutOfRangeException
                   ("IndexOutOfRangeException is thrown."));
                var task2 = Task.Run(() => throw new
                   ArithmeticException("ArithmeticException is thrown."));
                tasks = Task.WhenAll(task1, task2);
                await tasks;
            }
            catch
            {
                AggregateException aggregateException = tasks.Exception;
                foreach (var e in aggregateException.InnerExceptions)
                {
                    Console.WriteLine(e.GetType().ToString());
                }
            }
        }
    }
}
