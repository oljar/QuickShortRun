﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CrudOwn.Services
{
    public static class NazwySciezek
    {
        public static string witryna = "onet.pl";
        public static string sciezka = "C:\\Users\\Admin\\source\\repos\\CrudOwn\\CrudOwn\\bin\\Debug\\CrudOwn.exe";

        // Fix: Change the return type of the method to match the returned value  
        public static List<Dictionary<string, string>> MakeDict()
        {
            string filePath = "dane.txt";
            List<Dictionary<string, string>> kolekcjaSlownikow = new List<Dictionary<string, string>>();

            foreach (var linia in File.ReadAllLines(filePath))
            {
                Dictionary<string, string> slownik = new Dictionary<string, string>();
                var pary = linia.Split(';');

                foreach (var para in pary)
                {
                    var kluczWartosc = para.Split('=');
                    if (kluczWartosc.Length == 2)
                    {
                        slownik[kluczWartosc[0].Trim()] = kluczWartosc[1].Trim();
                    }
                }
                kolekcjaSlownikow.Add(slownik);
            }

           
            return kolekcjaSlownikow;
        }
    }
}


