namespace playfairGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            string allomany = @"..\..\..\..\src\szoveg.txt";
            using StreamReader sr = new(allomany);
            tbSzoveg.Text = sr.ReadToEnd();
        }

        private void OnTbSzovegTextChanged(object sender, EventArgs e)
        {
            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] szovegek = tbSzoveg.Text.Split(" ");
            if (szovegek.Any(szoveg => szoveg.Length != 2))
            {
                lblSzoveg.ForeColor = Color.Red;
            } 
            else if (szovegek.Any(szoveg => !abc.Contains(szoveg[0]) || !abc.Contains(szoveg[1])))
            {
                lblSzoveg.ForeColor = Color.Blue;
            }
            else if (szovegek.Any(szoveg => szoveg[0] == szoveg[1]))
            {
                lblSzoveg.ForeColor = Color.Magenta;
            }
            else
            {
                lblSzoveg.ForeColor = Color.Green;
            }
        }
    }
}