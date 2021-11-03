using System.Diagnostics;
using System.Net;
using Microsoft.Win32;




async Task DownloadWSA(string filePath, string url)
{


    using (System.Net.WebClient client = new System.Net.WebClient())
    {
        var WSAFile = $@"C:\Users\{Environment.UserName}\Downloads\WSA-Android.msix";
        Console.WriteLine("Downloading WSA Please Wait...");
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

using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
{
    var arch = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
    Object o = key.GetValue("CurrentBuild");
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("============================> WSA Installer Script <============================");
    Console.BackgroundColor  = ConsoleColor.Black;
    Console.WriteLine($"Build Number: {Convert.ToInt32(o)}");
    Console.WriteLine($"Windows Architecture : {arch}\n \n \n \n");
    if (Convert.ToInt32(o) == 22000 || Convert.ToInt32(o) > 22000) { 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Steps to Generate Link \n ");
    Console.Write(">: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Opening Link Generator on Your Browser");
    Console.ForegroundColor = ConsoleColor.Red;
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

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sorry Your Windows Version Doesn't Support WSA Currently Please Update Your Operating System to Build 2200");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Press Enter to Exit.");
        Console.ReadLine();
        return;
    }
}

