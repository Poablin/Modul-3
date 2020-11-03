using System;
using System.Net;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var downloadTask = DownloadLineFromDatabase();
            var lineWriteTask = WriteNewLine();
            var downloadedLine = await downloadTask;
            var newWrittenLine = await lineWriteTask;
            Console.WriteLine("Finished");
        }

        private static async Task<string> DownloadLineFromDatabase()
        {
            Console.WriteLine("Downloading from database...");
            await Task.Delay(3000);
            return "Downloaded";
        }
        private static async Task<string> WriteNewLine()
        {
            Console.WriteLine("Writing new file...");
            await Task.Delay(2000);
            return "Written Line";
        }
    }
}
