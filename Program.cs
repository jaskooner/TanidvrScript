// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


// Helper methods
void StartProcess(string pFilename, Process pProcess)
{
    ProcessStartInfo startInfo = new ProcessStartInfo();
    pProcess.StartInfo.FileName = pFilename;
    pProcess.StartInfo.UseShellExecute = false;
    pProcess.Start();
}

// Stores the filenames in a collection, to iterate over
string[] lines = File.ReadAllLines("cam_files.txt");


// Starting cams
List<Thread> threads = new List<Thread>();
foreach (string line in lines)
{
    // Starting cameras
    Console.WriteLine("Starting cameras");
    Process p = new Process();
    Thread thread1 = new Thread(() => StartProcess(line, p));
    thread1.Start();
}




