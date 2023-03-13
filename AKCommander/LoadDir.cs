using System.Runtime.CompilerServices;

namespace AKCommander
{
    public  class LoadDir
    {   

        public string? Nazwa { get; set; }
        public string? Atrybut { get; set; }
        public string? Link { get; set; }
        
        public int? Katalog { get; set; }


        public static List<LoadDir> Wczytaj(string sciezka)
        {
            var directoryInfo = new DirectoryInfo(sciezka);

            var directoryList = from katalog in directoryInfo.GetDirectories()
                                orderby katalog.Name
                                select LoadDir.ParsujKatalog(katalog);

            var fileList = from plik in directoryInfo.GetFiles()
                           orderby plik.Name
                           select LoadDir.ParsujPliki(plik);

            directoryList.Union(fileList);

            return directoryList.Union(fileList).ToList();
        }

        internal static LoadDir ParsujKatalog(DirectoryInfo katalog)
            
        {
            return new LoadDir
            {
                Nazwa = string.Concat("[", katalog.Name,"]"),
                Atrybut = katalog.Attributes.ToString(),
                Link = katalog.LinkTarget,
                Katalog=1

            };
        }

        internal static LoadDir ParsujPliki(FileInfo plik)
       {
            return new LoadDir
            {
                Nazwa = plik.Name,
                Atrybut = plik.Attributes.ToString(),
                Link = "",
                Katalog = 0
            };
        }


    }
}