﻿using SHDocVw;

namespace warsztat
{
    public static class Prog
    {
        public static void Main()
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