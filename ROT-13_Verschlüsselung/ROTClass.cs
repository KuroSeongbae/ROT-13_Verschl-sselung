using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT_13_Verschlüsselung
{
    class ROTClass
    {
        static void Main(string[] args)
        {

            var dateipfad = EinUndAusgabe.GebePfadEin();
            var eingabe = "";
            var ausgabe = "";

            eingabe = EinUndAusgabe.LeseDatei(dateipfad);
            eingabe = Verarbeitung.ErsetzeUmlaute(eingabe);
            eingabe = Verarbeitung.SchreibeZeichenGroß(eingabe);
            ausgabe = Verarbeitung.VerschlüsselZeichen(eingabe, ausgabe);
            dateipfad = EinUndAusgabe.GebePfadEin();
            EinUndAusgabe.SchreibeDatei(dateipfad, ausgabe);
        }

        public static void ErstelleDictionary()
        {
            Dictionary<string, string> Schlüssel = new Dictionary<string, string>();
            Schlüssel.Add("A", "N");
            Schlüssel.Add("B", "O");
            Schlüssel.Add("C", "P");
            Schlüssel.Add("D", "Q");
            Schlüssel.Add("E", "R");
            Schlüssel.Add("F", "S");
            Schlüssel.Add("G", "T");
            Schlüssel.Add("H", "U");
            Schlüssel.Add("I", "V");
            Schlüssel.Add("J", "W");
            Schlüssel.Add("K", "X");
            Schlüssel.Add("L", "Y");
            Schlüssel.Add("M", "Z");
            Schlüssel.Add("N", "A");
            Schlüssel.Add("O", "B");
            Schlüssel.Add("P", "C");
            Schlüssel.Add("Q", "D");
            Schlüssel.Add("R", "E");
            Schlüssel.Add("S", "F");
            Schlüssel.Add("T", "G");
            Schlüssel.Add("U", "H");
            Schlüssel.Add("V", "I");
            Schlüssel.Add("W", "J");
            Schlüssel.Add("X", "K");
            Schlüssel.Add("Y", "L");
            Schlüssel.Add("Z", "M");
            Schlüssel.Add(" ", " ");
        }
    }

    public class EinUndAusgabe
    {
        public static string GebePfadEin()
        {
            Console.WriteLine("Bitte geben Sie den Dateipfad an wo die Datei liegt, bzw. wo sie abgespeichert werden soll: ");
            return Console.ReadLine();
        }

        public static string LeseDatei(string dateipfad)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@dateipfad, Encoding.Default);
            return file.ReadToEnd();
        }

        public static void SchreibeDatei(string dateipfad, string ausgabe)
        {
            System.IO.File.WriteAllText(@dateipfad, ausgabe);
        }

    }

    public class Verarbeitung
    {
        public static string ErsetzeUmlaute(string eing)
        {
            eing = eing.Replace("ä", "ae");
            eing = eing.Replace("ö", "oe");
            eing = eing.Replace("ü", "ue");
            eing = eing.Replace("ß", "ss");

            return eing;
        }

        public static string SchreibeZeichenGroß(string eing)
        {
            return eing.ToUpper();
        }

        public static string VerschlüsselZeichen(string eing, string ausg)
        {
            foreach (char index in eing)
            {
                switch (index)
                {
                    case '0':
                        ausg += 'D';
                        break;
                    case '1':
                        ausg += 'E';
                        break;
                    case '2':
                        ausg += 'F';
                        break;
                    case '3':
                        ausg += 'G';
                        break;
                    case '4':
                        ausg += 'H';
                        break;
                    case '5':
                        ausg += 'I';
                        break;
                    case '6':
                        ausg += 'J';
                        break;
                    case '7':
                        ausg += 'K';
                        break;
                    case '8':
                        ausg += 'L';
                        break;
                    case '9':
                        ausg += 'M';
                        break;
                    case 'A':
                        ausg += 'N';
                        break;
                    case 'B':
                        ausg += 'O';
                        break;
                    case 'C':
                        ausg += 'P';
                        break;
                    case 'D':
                        ausg += 'Q';
                        break;
                    case 'E':
                        ausg += 'R';
                        break;
                    case 'F':
                        ausg += 'S';
                        break;
                    case 'G':
                        ausg += 'T';
                        break;
                    case 'H':
                        ausg += 'U';
                        break;
                    case 'I':
                        ausg += 'V';
                        break;
                    case 'J':
                        ausg += 'W';
                        break;
                    case 'K':
                        ausg += 'X';
                        break;
                    case 'L':
                        ausg += 'Y';
                        break;
                    case 'M':
                        ausg += 'Z';
                        break;
                    case 'N':
                        ausg += '0';
                        break;
                    case 'O':
                        ausg += '1';
                        break;
                    case 'P':
                        ausg += '2';
                        break;
                    case 'Q':
                        ausg += '3';
                        break;
                    case 'R':
                        ausg += '4';
                        break;
                    case 'S':
                        ausg += '5';
                        break;
                    case 'T':
                        ausg += '6';
                        break;
                    case 'U':
                        ausg += '7';
                        break;
                    case 'V':
                        ausg += '8';
                        break;
                    case 'W':
                        ausg += '9';
                        break;
                    case 'X':
                        ausg += 'A';
                        break;
                    case 'Y':
                        ausg += 'B';
                        break;
                    case 'Z':
                        ausg += 'C';
                        break;
                    default:
                        ausg += index;
                        break;
                }
            }
            return ausg;
        }
    }
}
