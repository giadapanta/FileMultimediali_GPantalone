using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone.Entities
{
    class Podcast: FileMultimediale
    {
        public List<Episodio> Episodi { get; set; }
        public Podcast(string titolo, Autore autore, List<Episodio> episodi)
            : base (titolo, autore)
        {
            Episodi = episodi;
        }

        public Podcast(string titolo, Autore autore, List<Episodio> episodi, List<Episodio> episodiAB) : this(titolo, autore, episodi)
        {
        }

        public override string PrintInfo()
        {
            return $"Podcast -> {base.PrintInfo()} ";
        }
        
    }
    public class Episodio
    {
        public string Titolo { get; set;}
        public Durata Durata { get; set; }
        public bool Ascoltato { get; set; }
        public Episodio (string titolo, Durata durata, bool ascoltato)
        {
            Titolo = titolo;
            Durata = durata;
            Ascoltato = ascoltato;
        }
        //public string PrintInfoEp()
        //{
        //   return $"{Titolo} - {Durata} - {Ascoltato}";
        //}
        
    }
    public struct Durata
    {
        public int Ore { get; set; }
        public int Minuti { get; set; }
        public int Secondi { get; set; }

        public Durata(int ore, int minuti, int secondi)
        {
            Ore = ore;
            Minuti = minuti;
            Secondi = secondi;
        }
    }
}
