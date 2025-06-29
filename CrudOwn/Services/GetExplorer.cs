using SHDocVw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrudOwn.Services
{
    public static class GetExplorer
    {
        public static string  GetActiveFolder()
        {
            
            ShellWindows shellWindows = new ShellWindows();

            foreach (InternetExplorer window in shellWindows)
            {
                if (window.FullName.ToLower().EndsWith("explorer.exe"))
                {
                    dynamic document = window.Document;
                    string folderPath = document.Folder.Self.Path;
                    return folderPath;

                }
                

            }return string.Empty; // Zwraca pusty string, jeśli nie znaleziono aktywnego folderu

        }
    }
}
