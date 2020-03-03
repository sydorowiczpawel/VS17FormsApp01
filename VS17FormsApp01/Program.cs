using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace VS17FormsApp01
{
    //static class Program
    class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new _logForm());
            Application.Run(new _mainForm());

        }
    }
}

//TODO: aplikacja ma się włączać od wyboru okna, z ktorym elementem chce pracować, np. soldier/tank/documents
//TODO: odczyt z pliku SOLDIERS.XML i wyrzucenie ich do tabeli
//TODO: odczyt z pliku TANKS.XML i wyrzucenie ich do tabeli
//TODO: odczyt z pliku DOCUMENTS.XML i wyrzucenie ich do tabeli
//TODO: tabele główne mają pokazywać tylko podstawowe dane, a kliknięcie w konkretną pozycję ma rozwijać szeroką listę ze szczegółami
//TODO: ekran logowania!
//TODO: logins.xml
