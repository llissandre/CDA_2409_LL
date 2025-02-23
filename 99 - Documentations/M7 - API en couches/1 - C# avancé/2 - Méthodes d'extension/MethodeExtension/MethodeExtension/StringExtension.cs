using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeExtension
{
    public static class StringExtension
    {
        /// <summary>
        /// Encode une chaine de caractères
        /// </summary>
        /// <param name="str">La chaine à encoder</param>
        /// <returns>La chaine encodée</returns>
        public static String Encoder(this String str)
        {
            //byte[] bytes = Encoding.Default.GetBytes(str);
            //string resultat = Convert.ToBase64String(bytes);
            //return resultat;

            return Convert.ToBase64String(Encoding.Default.GetBytes(str));
        }

        /// <summary>
        /// Décoder une chaine
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String Decoder(this String str)
        {
            return Encoding.Default.GetString(Convert.FromBase64String(str));
        }

        /// <summary>
        /// Compte le nombre de mots d'une chaine
        /// </summary>
        /// <param name="str">Une chaine</param>
        /// <returns>le nombre de mots</returns>
        public static int WordCount(this String str)
        {
            char[] separators = new char[] { ' ', '.', '?', '\'', '!' };
            var words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public static int WordCount(this String str, char[] separators)
        {           
            var words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }


    }
}
