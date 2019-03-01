using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ROT_13_Verschlüsselung;

namespace TestClass
{
    [TestFixture]

    public class TestClass
    {
        [Test, Category("Gerüsttest")]

        public void DateiLesen()
        {
            var ergebnis = EinUndAusgabe.LeseDatei(@"Z:\Programmierung\VisualStudio\Konsolenanwendungen\Test.txt");
            Assert.AreEqual("Hallöle Welt\r\nasdf", ergebnis);
        }

        [Test, Category ("Gerüsttest")]

        public void UmlauteErsetzen()
        {
            var ergebnis = Verarbeitung.ErsetzeUmlaute("Hallülä Wöltß");
            Assert.AreEqual("Halluelae Woeltss", ergebnis);
        }

        [Test, Category("Gerüsttest")]

        public void ZeichenGroßSchreiben()
        {
            var ergebnis = Verarbeitung.SchreibeZeichenGroß("Hallo Welt");
            Assert.AreEqual("HALLO WELT", ergebnis);
        }

        [Test, Category("Gerüsttest")]

        public void ZeichenVerschlüsseln()
        {
            var ergebnis = Verarbeitung.VerschlüsselZeichen("HALLO WELT", "");
            Assert.AreEqual("UNYY1 9RY6", ergebnis);
        }
    }
}
