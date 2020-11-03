using System;
using System.Net;
using System.Threading.Tasks;
using Console = System.Console;

namespace AsyncAndAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await UploadBothFiles();
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

        private static async Task UploadBothFiles()
        {
            var downloadTask = DownloadLineFromDatabase();
            var lineWriteTask = WriteNewLine();
            var downloadedLine = await downloadTask;
            var newWrittenLine = await lineWriteTask;
            Console.WriteLine("Uploads Done");
        }
    }
}
