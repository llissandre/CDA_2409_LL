using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendrier.Data;
using System.Collections.ObjectModel;

namespace Calendrier.ViewModels
{
    class CalendrierViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<Session> sessions { get; private set; }
        public int Annee { get; private set; }
        public byte Semaine { get; private set; }

        public CalendrierViewModel()
        {
            var pe = new PachaDataFormationEntities();
            sessions = new ObservableCollection<Session>(pe.GetSessions(2011, 5));
            Annee = 2011;
            Semaine = 5;
        }

        protected void OnPropertyChanged(string name)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        internal void GetSemaine(DateTime dt)
        {
            Annee = dt.Year;
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            Semaine = (byte)cal.GetWeekOfYear(dt.ToLocalTime(), 
                    System.Globalization.CalendarWeekRule.FirstDay, System.DayOfWeek.Sunday);

            var pe = new PachaDataFormationEntities();
            sessions = new ObservableCollection<Session>(pe.GetSessions(Annee, Semaine));
            OnPropertyChanged("sessions");
        }

        internal void AnnuleSession(int sessionId)
        {
            var pe = new PachaDataFormationEntities();
            pe.DeleteSession(sessionId);
            sessions.Remove(sessions.First(s => s.SessionId == sessionId));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
