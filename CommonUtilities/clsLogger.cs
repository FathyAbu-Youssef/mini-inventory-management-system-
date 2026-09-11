using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace CommonUtilities
{
    public class clsLogger
    {
        public static void LogException(Exception ex, [CallerMemberName] string MethodName = "", [CallerFilePath] string FilePath = "", [CallerLineNumber] int LineNumber = 0)
        {
            using (EventLog log = new EventLog())
            {
                string ErrorMessage =
                    $"Exception occured in method: {MethodName},\n" +
                    $"FilePath: {FilePath}\n" +
                    $"Line Number : {LineNumber}\n" +
                    $"Exception: {ex.Message}\n" +
                    $"Exception Stack Trace: {ex.StackTrace}";

                log.WriteEntry(ErrorMessage, EventLogEntryType.Error);
            }
        }
    }
}
