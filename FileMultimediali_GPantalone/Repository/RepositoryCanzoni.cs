using FileMultimediali_GPantalone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone.Repository
{
    internal class RepositoryCanzoni : IRepositoryManager<Canzone>
    {
        static List<Canzone> canzoni = new List<Canzone>()
        {
            new Canzone("Thinking Out Loud", new Autore("Ed", "Sheeran", 1991), GenereEnum.Soul ),
            new Canzone("Almeno tu nell'universo", new Autore("Mia", "Martini",1947), GenereEnum.Pop),
            new Canzone("Ghost", new Autore("Justin", "Bieber", 1994), GenereEnum.Pop),
            new Canzone("A Natural Woman", new Autore("Aretha", "Franklin",1942 ), GenereEnum.Soul),
            new Canzone("Despacito", new Autore("Louis", "Fonsi", 1978), GenereEnum.Latino),
            new Canzone("Love Don't Cost A Thing", new Autore("Jennifer", "Lopez", 1969), GenereEnum.RNB),
            new Canzone("Hey Joe", new Autore("Jimi", "Hendrix", 1942), GenereEnum.Rock)
            
        };
        public List<Canzone> Fetch()
        {
            return canzoni;
        }
        public List<Canzone> GetByGenere(GenereEnum genereScelto)
        {        
        return canzoni.Where(c => c.Genere == genereScelto).ToList();
        }
    }
}
