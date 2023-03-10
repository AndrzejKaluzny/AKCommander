namespace AKCommander
{
    public class LoadDir
    {
        public string nazwaPliku { get; set; }
        public string typ { get; set; }


        public static LoadDir Wczytaj(string dirPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            //var listaKatalogow = dirInfo.GetDirectories();
            //var listaPlikow = dirInfo.GetFileSystemInfos();

            //var listaPlikow = from p in dirInfo.GetDirectories()                            select (p);
            return new LoadDir
            {
                nazwaPliku = dirInfo.Name,
                typ = dirInfo.Attributes.ToString()
            };

        }
    }
}