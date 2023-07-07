using HandlingAsynchronousExceptions;

Console.WriteLine("Created by : Bahareh.Smi");
Console.WriteLine("Date : 1402/04/15");
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Exceptions in asynchronous methods that return void :");
Console.WriteLine();

sampleTaskThrowMultipleExceptionsAsync.ThisIsATestMethod();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Exceptions in asynchronous methods that return a Task object :");
Console.WriteLine();

var result = sampleTaskThrowMultipleExceptionsAsync.ExceptionInAsyncCodeDemo();
Console.WriteLine(result.Exception);
Console.WriteLine(result.Status);

Console.WriteLine();
Console.WriteLine("Use the Exceptions property to retrieve all exceptions :");
Console.WriteLine();

var _result = sampleTaskThrowMultipleExceptionsAsync.ExceptionInAsyncAllCodeDemo();
Console.WriteLine(_result.Exception);
Console.WriteLine(_result.Status);
Console.WriteLine();


Console.ReadLine();
Console.ReadLine();

