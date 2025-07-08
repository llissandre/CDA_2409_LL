using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Calendrier.Data;
using System.Diagnostics;
using System.Windows.Threading;
using System.ComponentModel;
using System.Collections;

namespace Calendrier.ViewModels
{
    class InfosViewModel : INotifyPropertyChanged
    {
        private List<Session> _sessions;
        private string _resultat;
        public InfosViewModel()
        {
            var pe = new PachaDataFormationEntities();
            _sessions = new List<Session>(pe.GetSessions(2011, 5));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public string resultat {
            get
            {
                return _resultat;
            }
            private set
            {
                _resultat = value;
                RaisePropertyChanged("resultat");
            }
        }

        internal void Calculer()
        {
            var alors = _sessions.GetType().GetInterface(typeof(IEnumerable<>).FullName);

            var l1 = new List<string>() { "un", "deux", "trois" };

            var res = l1
                .Where(s => s.ToLower().Contains("un"))
                .ToArray();

            Debug.Print(resultat.ToString());
        }

    }
}
