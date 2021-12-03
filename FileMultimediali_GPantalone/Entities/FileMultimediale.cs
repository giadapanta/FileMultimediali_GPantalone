using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone
{
    abstract class FileMultimediale
    {
        public string Titolo { get; set; }
        public Autore Autore { get; set; }
        public FileMultimediale(string titolo, Autore autore)
        {
            Titolo = titolo;
            Autore = autore;
        }
        public virtual string PrintInfo()
        {
            return $"Titolo: {Titolo} - Autore: {Autore.Nome} {Autore.Cognome} [{Autore.AnnoDiNascita}]";
        }
    }
    public class Autore
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita    { get; set; }
        public Autore(string nome, string cognome, int annoDiNascita)
        {
            Nome = nome;
            Cognome = cognome;  
            AnnoDiNascita = annoDiNascita;
        }
    }
}
