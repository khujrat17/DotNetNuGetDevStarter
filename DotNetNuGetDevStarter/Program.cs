using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NuGetDevStarter
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine(@"
 _   _       _   _       _   _       _   _       _   _       _   _ 
| \ | | ___ | |_| |__   | \ | | ___ | |_| |__   | \ | | ___ | |_| |__
|  \| |/ _ \| __| '_ \  |  \| |/ _ \| __| '_ \  |  \| |/ _ \| __| '_ \
| |\  | (_) | |_| | | | | |\  | (_) | |_| | | | | |\  | (_) | |_| | | |
|_| \_|\___/ \__|_| |_| |_| \_|\___/ \__|_| |_| |_| \_|\___/ \__|_| |_|
🚀 NuGet Developer Starter Kit
");

            string[] packages = {
                "MySqlOptimizer",
                "myOtpGenerator",
                "CustomLog",
                "MyIpAddress",
                "MyLogicalLibrary",
                "SolidPrinciplesDemo",
                "DesignPatternsDemo",
                "AutoDocCommenter",
                "CodeSnip.NET",
                "RealTimeToolkit.NET"
            };

            foreach (var pkg in packages)
            {
                Console.WriteLine($"\n📦 Installing: {pkg}");
                await Run("dotnet", $"add package {pkg}");
            }

            Console.WriteLine("\n✅ All recommended NuGet packages installed successfully!");
            Console.WriteLine("💡 Explore them inside your .NET project or Visual Studio now!");
        }

        static async Task Run(string file, string args)
        {
            var psi = new ProcessStartInfo(file, args)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            var proc = Process.Start(psi);
            await proc.WaitForExitAsync();
        }
    }
}
