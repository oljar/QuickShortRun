namespace warsztat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Admin\\source\\repos\\QuickShortRun\\warsztat\\dane.txt";
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

            foreach (var a in kolekcjaSlownikow)
            {
                Console.WriteLine("Nowy słownik:");
                foreach (var para in a)
                {
                    Console.WriteLine($"  {para.Key}: {para.Value}");
                }
            }
        }
    }
}

