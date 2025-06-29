using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;
using SHDocVw;
using Shell32;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using System;
using System.Windows;
using System.IO;
using CrudOwn.ModelWidoku;
using System.Runtime.CompilerServices;
using CrudOwn.Services;


namespace CrudOwn.ModelWidoku


{

    public static class Jump
    {

        


        public static void UstawJumpList()
        {
            // Utworzenie nowej JumpList
            Microsoft.WindowsAPICodePack.Taskbar.JumpList jumpList = Microsoft.WindowsAPICodePack.Taskbar.JumpList.CreateJumpList();

            // Dodanie niestandardowego zadania – np. otwórz stronę internetową
            JumpListLink linkDoGoogle = new JumpListLink("C:\\Program Files\\Internet Explorer\\iexplore.exe", "Otwórz Google")
            {
                Arguments = "https://www.google.com",
                IconReference = new IconReference("C:\\Program Files\\Internet Explorer\\iexplore.exe", 0)
            };

            

           


            JumpListLink linkDoChrome = new JumpListLink("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "Otwórz Chrome")
            {

                Arguments = Nazwy_sciezek.ax, // Pobierz ścieżkę z elementOne
                IconReference = new IconReference("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", 0)
                
                
            };



            JumpListLink linkDoTrojmiasto = new JumpListLink("C:\\Program Files\\Internet Explorer\\iexplore.exe", "Trojmiasto.pl")
            {
                Arguments = "https://www.trojmiasto.pl/",
                IconReference = new IconReference("C:\\Program Files\\Internet Explorer\\iexplore.exe", 0)
            };


            // Dodaj link do CrudOwn.exe
            JumpListLink linkDoCrudOwn = new JumpListLink(
                "C:\\Users\\Admin\\source\\repos\\CrudOwn\\CrudOwn\\bin\\Debug\\CrudOwn.exe",
                "Uruchom CrudOwn")
            {
                IconReference = new IconReference(
                    "C:\\Users\\Admin\\source\\repos\\CrudOwn\\CrudOwn\\bin\\Debug\\CrudOwn.exe", 0)
            };

            jumpList.AddUserTasks(linkDoChrome); // Dodaj link do Chrome
            jumpList.AddUserTasks(linkDoGoogle);
            jumpList.AddUserTasks(linkDoTrojmiasto);
            jumpList.AddUserTasks(linkDoCrudOwn); // Dodaj nowy link

            // Zastosowanie Jump Listy
            jumpList.Refresh();
        }


        public static string PobierzSciezke()
        {
            return Nazwy_sciezek.ax; // Zwraca sciezke z elementOne
        }



        //public static string PobierzSciezke()
        //{
        //    ShellWindows shellWindows = new ShellWindows();

        //    foreach (InternetExplorer window in shellWindows)
        //    {
        //        if (window.FullName.ToLower().EndsWith("explorer.exe"))
        //        {
        //            dynamic document = window.Document;
        //            return document.Folder.Self.Path;
        //        }
        //    }

        //    return string.Empty;
        //}
    }
}


public static class Prog
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
                MessageBox.Show("Aktywny folder: " + folderPath, "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}



