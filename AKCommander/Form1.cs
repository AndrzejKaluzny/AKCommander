using System.Runtime.CompilerServices;
using static System.Windows.Forms.LinkLabel;

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
            tabControlL.TabPages[0].Text = sciezka;
            tabControlP.TabPages[0].Text = sciezka;

            foreach (var s in LoadDir.Wczytaj(sciezka))
            {
                listViewtab1L.Items.Add(s.Nazwa);
                listViewtab1R.Items.Add(s.Nazwa);

            }




        }

        private void listViewtab1L_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewtab1L.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intSelectedIndeks = listViewtab1L.SelectedIndices[0];
            if (intSelectedIndeks >= 0)
            {
                var sciezka = listViewtab1L.Items[intSelectedIndeks].Text;
                return;
            }


        }
    }
}