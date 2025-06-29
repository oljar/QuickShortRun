using SHDocVw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warsztat
{
    public class link
    {
        public static void Sciezka()
        {
            ShellWindows shellWindows = new ShellWindows();

            foreach (InternetExplorer window in shellWindows)
            {
                if (window.FullName.ToLower().EndsWith("explorer.exe"))
                {
                    dynamic document = window.Document;
                    string folderPath = document.Folder.Self.Path;
                    Console.WriteLine("Aktywny folder: " + folderPath);
                   
                }
            }
        }
    }
}
    

    
    

