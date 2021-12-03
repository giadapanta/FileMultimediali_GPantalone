using FileMultimediali_GPantalone.Entities;
using FileMultimediali_GPantalone.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone
{
    internal class Menu
    {
        public static RepositoryCanzoni repCanzoni = new RepositoryCanzoni();
        public static RepositoryPodcast repPodcast=new RepositoryPodcast();
        internal static void Start()
        {
           
            char choice;
            do
            {
               
                Console.WriteLine("Scegli tra le seguenti opzioni:" +
                    "\n(1) Visualizza tutte le canzoni," +
                    "\n(2) Visualizza tutti i podcast" +
                    "\n(3) Visualizza le canzoni di un certo genere" +
                    "\n(4) Visualizza gli episodi di un certo podcast" +
                    "\n(5) Visualizza gli episodi con una durata <= ad una certa durata" +
                    "\n(q) Esci");
                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        List<Canzone> canzoni = repCanzoni.Fetch();
                        Stampa(canzoni);     //visualizza tutte le canzoni
                        break;
                    case '2':
                        List<Podcast> podcasts = repPodcast.Fetch();
                        Stampa(podcasts);    //visualizza tutti i podcast - no episodi -.
                        break;
                    case '3':
                       List<Canzone> canzoniByG = VisualizzaCanzoniByGen();  //Visualizza le canzoni secondo
                      Stampa(canzoniByG);                                    //il genere scelto
                        break;
                    case '4':
                        //Visualizza gli episodi di un certo podcast
                        //ChiediPodcast();
                       VisualizzaEpisodi();
                        //StampaEp(pod);
                        break;
                    case '5':
                        //Visualizza episodi <= ad una certa durata
                        VisualizzaEpisodiByDurata();
                        break;
                    case 'q':
                        Console.WriteLine("\nARRIVEDERCI!\n");
                        break;
                        default: Console.WriteLine("\nLa scelta inserita non è valida.\n");
                        break;
                }

            } while (choice != 'q');
        }

        private static void VisualizzaEpisodiByDurata()
        {
             Durata dt= ChiediDurata();
            List<Podcast> podcasts = repPodcast.Fetch();
            List<Episodio> episodiByD = repPodcast.GetByDurata(dt);
           
            foreach (var p in podcasts)
            {
                foreach (var ep in episodiByD)
                {
                    if (p.Episodi.Contains(ep))
                    {
                        Console.WriteLine($"Podcast: {p.Titolo}, Episodio: " +
                            $"\n{ep.Titolo} - {ep.Durata.Ore}h {ep.Durata.Minuti}min " +
                            $"{ep.Durata.Secondi}sec");
                    }
                    
                }
            }


            
        }

        private static Durata ChiediDurata()
        {
            Durata dt = new Durata();
            int ore;
            do
            {
                Console.WriteLine("Inserisci le ORE:");

            }while(!int.TryParse(Console.ReadLine(), out ore));
            dt.Ore = ore;
            int min;
            do
            {
                Console.WriteLine("Inserisci le MINUTI:");

            } while (!int.TryParse(Console.ReadLine(), out min));
            dt.Minuti = min;

            int s;
            do
            {
                Console.WriteLine("Inserisci le SECONDI:");

            } while (!int.TryParse(Console.ReadLine(), out s));
            dt.Secondi = s; 
            return dt;
        }


        private static void VisualizzaEpisodi()
        {
            string titoloScelto = ChiediPodcast();
            List<Podcast> podcast= new List<Podcast>();
            podcast.AddRange(repPodcast.GetByTitolo(titoloScelto));
            //List<Episodio> episodi = new List<Episodio>();
            foreach (var p in podcast)
            {
                
                    foreach (var e in p.Episodi)
                        Console.WriteLine($"{e.Titolo} - {e.Durata.Ore}h {e.Durata.Minuti}min " +
                            $"{e.Durata.Secondi}sec - {e.Ascoltato}");
            }

            
        }
        //private static void StampaEp(List<Podcast> podcasts)
        //{
        //    List <Episodio> episodi = new List<Episodio>();
        //    foreach (var p in podcasts)
        //    {
        //        if(p.)
        //        foreach (var e in episodi)
        //            Console.WriteLine($"{e.Titolo} - {e.Durata} - {e.Ascoltato}");
        //    }
        //}

        private static string ChiediPodcast()
        {
            List<Podcast> podcast =repPodcast.Fetch();
            string titoloScelto;
            do
            {
                Console.WriteLine("Scegli il titolo tra i seguenti podcasts:");
                Stampa(podcast);
                titoloScelto=Console.ReadLine();    

            }while(string.IsNullOrEmpty(titoloScelto));
            //foreach (var p in podcast)
            //{
            //    Console.WriteLine($"{p.PrintInfo()}");
            //}
            //string titoloScelto= Console.ReadLine();
            //while(string.IsNullOrEmpty(titoloScelto))
            //{
            //    Console.WriteLine("Titolo inserito non valido.");
            //}
            return titoloScelto;
        }

        private static List<Canzone> VisualizzaCanzoniByGen()
        {
            GenereEnum genereScelto = GetGenere();
            //List<Canzone> canzoni = repCanzoni.GetByGenere(genereScelto);
           List<Canzone> canzoniByG = new List<Canzone>();
            canzoniByG.AddRange(repCanzoni.GetByGenere(genereScelto));
            return canzoniByG;

        }
        private static GenereEnum GetGenere()
        {
            Console.WriteLine($"Premi {(int)GenereEnum.Pop} per scegliere {GenereEnum.Pop}");
            Console.WriteLine($"Premi {(int)GenereEnum.Rock} per scegliere {GenereEnum.Rock}");
            Console.WriteLine($"Premi {(int)GenereEnum.Blues} per scegliere {GenereEnum.Blues}");
            Console.WriteLine($"Premi {(int)GenereEnum.RNB} per scegliere {GenereEnum.RNB}");
            Console.WriteLine($"Premi {(int)GenereEnum.Soul} per scegliere {GenereEnum.Soul}");
            Console.WriteLine($"Premi {(int)GenereEnum.Latino} per scegliere {GenereEnum.Latino}");
            int genereScelto;
                    
            while(!int.TryParse(Console.ReadLine(), out genereScelto) || genereScelto>6)
            {
                Console.WriteLine("Scelta non valida, prova di nuovo.");
            }
            return (GenereEnum)genereScelto;
        }

        //private static void FetchPodcast()
        //{
        //    List<Podcast> podcasts = repPodcast.Fetch();
        //    foreach(var p in podcasts)
        //    {
        //        Console.WriteLine(p.PrintInfo());
        //    }
        //}

       private static void Stampa(List<Podcast> podcasts)
        {
            foreach(var p in podcasts)
                Console.WriteLine(p.PrintInfo());
        }
        private static void Stampa(List<Canzone> canzoni)
        {
            foreach (var c in canzoni)
            {
                Console.WriteLine(c.PrintInfo());
            }

        }
    }
}
