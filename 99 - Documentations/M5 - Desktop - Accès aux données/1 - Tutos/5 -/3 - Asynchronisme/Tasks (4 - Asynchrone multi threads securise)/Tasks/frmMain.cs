using System.Diagnostics;

namespace Tasks
{
    public partial class frmMain : Form
    {
        private List<int> _lstNb = new List<int>();
        Random _rnd = new Random();
        Stopwatch _sw = new Stopwatch();
        Object _verrou = new();

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
            _lstNb.Clear();
            lbxNombres.DataSource = null;
            lblTempo.Text = String.Empty;
            _sw.Restart();

            // Création et lancement de 10 tâches en //
            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Run(() => { RemplirListe(); });
            }

            // Attente de la fin des 10 tâches
            await Task.WhenAll(taskArray);

            _sw.Stop();
            lblTempo.Text = String.Format("Temps écoulé : {0} ms", _sw.ElapsedMilliseconds);

            // Tris de la liste pour faciliter la lecture
            _lstNb.Sort();

            lbxNombres.DataSource = _lstNb;          
        }

        private void RemplirListe()
        {
            // On cherche tous les nombres compris entre 1 et 100 en évitant les doublons
            while (_lstNb.Count < 100)
            {
                int nb = _rnd.Next(1, 101);
                Thread.Sleep(10);

                lock (_verrou) // Une seule thread à un instant donné peu exécuter cette portion de code
                {
                    if (!_lstNb.Contains(nb)) // ATTENTION, ACCES CONCURENTIEL A UNE MEME VARIABLE (_lstNb)
                    {
                        Thread.Sleep(10);
                        _lstNb.Add(nb);
                    }
                }
            }
        }
    }
}