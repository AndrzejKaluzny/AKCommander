namespace AKCommander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sciezka = @"c:\";
            var loadDir = Wczytaj(sciezka);


        }

        private static List<LoadDir> Wczytaj(string sciezka)
        {
            return default;
        }
    }
}