using System;
using System.Threading.Tasks;

namespace AazarKhanTelstraSMSAPI.PCL.Utilities
{
    public static class RetryHelper
    {
        public static async Task RetryOnExceptionAsync(
            int times, TimeSpan delay, Func<Task> operation)
        {
            await RetryOnExceptionAsync<Exception>(times, delay, operation).ConfigureAwait(false);
        }
        public static async Task RetryOnExceptionAsync<TException>(
            int times, TimeSpan delay, Func<Task> operation) where TException : Exception
        {
            if (times < 0)
                throw new ArgumentOutOfRangeException();
            var attempts = -1;
            do
            {
                TException capturedException;
                try
                {
                    attempts++;
                    await operation().ConfigureAwait(false);
                    break;
                }
                catch (TException ex)
                {
                    capturedException = ex;
                }

                if (attempts == times)
                    throw capturedException;
#if WINDOWS_UWP
                await Task.Delay(delay).ConfigureAwait(false);
#else
                await TaskEx.Delay(delay).ConfigureAwait(false);
#endif

            } while (true);
        }
    }
}