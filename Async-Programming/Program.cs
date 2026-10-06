using System;
using System.Threading.Tasks;

namespace Async_Programming;


class Program
{
    
    static async Task Main()
    {

        Console.WriteLine("Before awaiting the operation");
        
        // Directly awaiting inside Console.WriteLine
        Console.WriteLine(await PausingForAPeriodOfTime.DelayResult("Hello World", TimeSpan.FromSeconds(5)));
        
        Console.WriteLine("After awaiting the operation");
        
    }
}