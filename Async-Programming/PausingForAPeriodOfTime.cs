using System;
using System.Threading.Tasks;

namespace Async_Programming;

public static class PausingForAPeriodOfTime
{
    
    public static async Task<TResult> DelayResult<TResult>(TResult result, TimeSpan delay)
    {
        await Task.Delay(delay);
        return result;
    }
    
    
}