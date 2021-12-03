using FileMultimediali_GPantalone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone.Repository
{
    internal class RepositoryPodcast : IRepositoryManager<Podcast>
    {
        static List<Episodio> episodiAB = new List<Episodio>()
        {
            new Episodio("Maratona 490 a.C", new Durata(0 , 32, 0), false),
            new Episodio ("Salamina 480 a.C.", new Durata (0 , 27, 3),false)
        };
        static List<Episodio> episodiAA = new List<Episodio>()
        {
            new Episodio("Una donna moderna in un mondo antico", new Durata(0,37,0), false),
            new Episodio("L'Egitto di Cleopatra", new Durata(0,31,1), false)
        };

        static List<Episodio> episodiGG = new List<Episodio>()
        {
            new Episodio("Insofferenza", new Durata(0,25,9), false),
            new Episodio("Spensieratezza", new Durata (0,23,1), false)
        };
        static List<Podcast> podcasts = new List<Podcast>()
        {
            new Podcast("Le Grandi Battaglie", new Autore("Alessandro", "Barbero", 1959),episodiAB),
            new Podcast("Cleopatra, donna e regina", new Autore("Alberto", "Angela", 1962),episodiAA),
            new Podcast("Cara Marie Curie", new Autore ("Gabriella", "Greison", 1976), episodiGG)
        };
        

        public List<Podcast> Fetch()
        {
            return podcasts;
        }
        public List<Podcast> GetByTitolo(string titoloScelto)
        {
            return podcasts.Where(p => p.Titolo == titoloScelto).ToList();
        }
                
        public List<Episodio> GetByDurata(Durata dt)
            
        {
            List<Episodio> episodi = new List<Episodio>();
            List<Episodio> ep = new List<Episodio>();
            episodi.AddRange(episodiAB);
            episodi.AddRange (episodiAA);
            episodi.AddRange(episodiGG);

            foreach (var e in episodi)
            {
                if (e.Durata.Ore < dt.Ore)
                {
                    ep.Add(e);
                }
                else if (e.Durata.Ore == dt.Ore)
                {
                    if (e.Durata.Minuti < dt.Minuti)
                    {
                        ep.Add(e);
                    }
                    else if (e.Durata.Minuti == dt.Minuti)
                    {
                        if (e.Durata.Secondi <= dt.Secondi)
                        {
                            ep.Add(e);
                        }
                    }
                }

            }
            return ep; 
          
        }
       
    }
}
