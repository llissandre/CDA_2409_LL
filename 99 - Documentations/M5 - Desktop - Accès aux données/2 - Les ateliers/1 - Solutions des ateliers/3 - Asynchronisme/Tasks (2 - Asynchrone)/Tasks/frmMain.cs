using System.Diagnostics;

namespace Tasks
{
    public partial class frmMain : Form
    {
        private List<int> _lstNb = new List<int>();
        Random _rnd = new Random();
        Stopwatch _sw = new Stopwatch();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btSynchrone_Click(object sender, EventArgs e)
        {
            _lstNb.Clear();
            lbxNombres.DataSource = null;
            lblTempo.Text = String.Empty;
            _sw.Restart();

            RemplirListe();

            _sw.Stop();
            lblTempo.Text = String.Format("Temps écoulé : {0} ms", _sw.ElapsedMilliseconds);

            // Tris de la liste pour faciliter la lecture
            _lstNb.Sort();

            lbxNombres.DataSource = _lstNb;
        }

        private async void btAsynchrone_Click(object sender, EventArgs e)
        {
            btAsynchrone.Enabled = false;

            _lstNb.Clear();
            lbxNombres.DataSource = null;
            lblTempo.Text = String.Empty;
            _sw.Restart();

            await Task.Run(() => 
            { 
                RemplirListe(); 
            });

            _sw.Stop();
            lblTempo.Text = String.Format("Temps écoulé : {0} ms", _sw.ElapsedMilliseconds);

            // Tris de la liste pour faciliter la lecture
            _lstNb.Sort();

            lbxNombres.DataSource = _lstNb;

            btAsynchrone.Enabled = true;
        }

        private void RemplirListe()
        {
            // On cherche tous les nombres compris entre 1 et 100 en évitant les doublons
            while (_lstNb.Count < 100)
            {
                int nb = _rnd.Next(1, 101);
                Thread.Sleep(10);

                if (!_lstNb.Contains(nb))
                {
                    Thread.Sleep(10);
                    _lstNb.Add(nb);
                }
            }
        }
    }
}