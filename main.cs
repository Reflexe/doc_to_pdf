using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace DocToPdf
{
    public class LibreOfficeFailedException : Exception
    {
        public LibreOfficeFailedException(int exitCode)
            : base(string.Format("LibreOffice has failed with {}", exitCode))
            {}
    }

    class Program
    {
        static string getLibreOfficePath() {
            switch (Environment.OSVersion.Platform) {
                case PlatformID.Unix:
                    return "/usr/bin/soffice";
                case PlatformID.Win32NT:
                    string binaryDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    return binaryDirectory + "\\Windows\\program\\soffice.exe";
                default:
                    throw new PlatformNotSupportedException	("Your OS is not supported");
            }
        }

        static void Main(string[] args) {
            string libreOfficePath = getLibreOfficePath();
        
            // FIXME: file name escaping: I have not idea how to do it in .NET.
            ProcessStartInfo procStartInfo = new ProcessStartInfo(libreOfficePath, string.Format("--convert-to pdf --nologo {0}", args[0]));
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            procStartInfo.WorkingDirectory = Environment.CurrentDirectory;

            Process process = new Process() { StartInfo =      procStartInfo, };
            process.Start();
            process.WaitForExit();
            
            // Check for failed exit code.
            if (process.ExitCode != 0) {
                throw new LibreOfficeFailedException(process.ExitCode);
            }
        }
    }
}

