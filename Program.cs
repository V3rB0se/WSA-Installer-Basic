using System.Diagnostics;
using System.Net;




async Task DownloadWSA(string filePath, string url)
{


    using (System.Net.WebClient client = new System.Net.WebClient())
    {
        var WSAFile = $@"C:\Users\{Environment.UserName}\Downloads\WSA-Android.msix";
        Console.WriteLine("Downloading WSA");
        await client.DownloadFileTaskAsync(url, filePath);
        Console.WriteLine("Downloaded");
        Console.WriteLine(".. Installing ");
        var startInfo = new ProcessStartInfo()
        {
            FileName = "powershell.exe",
            Arguments = $"Add-AppxPackage -Path {WSAFile}",
            UseShellExecute = false,
            Verb = "runas"
        };
        Process.Start(startInfo);
    }
    Console.WriteLine("Press Any Key to Exit...");
    Console.ReadLine();
}
var arch = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
Console.WriteLine($"Windows Architecture : {arch}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Opening Online Link Generator for Microsoft Store \n \n \n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Steps to Generate Link \n ");
Console.Write(">: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Choose ProductId from first dropdown");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(">: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Copy this and Paste in Data Field: 9p3395vx91nr");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(">: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Select Slow from DropDown Menu & Click the Checkbox Button to Generate the Link");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(">: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Locate the largest file from the list. It should be a MSIX Bundle sized a little over 1 GB.");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(">: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Right click and Copy the link of that file and paste it below.\n \n");

var proc = new ProcessStartInfo()
{
    UseShellExecute = true,
    FileName = "https://store.rg-adguard.net"
};
Process.Start(proc);
Console.Write("URL:");
string askURL = Console.ReadLine();
Console.WriteLine($"URL:{askURL}");
await DownloadWSA($@"C:\Users\{Environment.UserName}\Downloads\WSA-Android.msix", askURL);
