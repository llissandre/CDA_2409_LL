using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Synthese
{
    internal class GestStudents
    {
        private List<Student> _students;

        public GestStudents(List<Student> students)
        {
            _students = students;
        }

        public override string ToString()
        {
            return ToString<object>(null, null);
        }

        public string ToString<T>(Func<Student, bool> filtre = null, Func<Student, T> order = null)
        {
            IEnumerable<Student> stds = null;
            string res = null;

            stds = (filtre != null) ? _students.Where(filtre) : _students;

            stds = (order != null) ?  stds.OrderBy(order) : stds;

            foreach (Student std in stds)
                res += $"{std}{Environment.NewLine}";

            return res;
        }
    }
}
