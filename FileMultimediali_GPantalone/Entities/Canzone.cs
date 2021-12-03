using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone.Entities
{
    class Canzone: FileMultimediale
    {
        public GenereEnum Genere { get; set; }
        public Canzone (string titolo, Autore autore, GenereEnum genere)
            :base(titolo, autore)
        {
            Genere = genere;
        }
        public override string PrintInfo()
        {
            return $"Canzone -> {base.PrintInfo()} - Genere: {Genere}";
        }
    }
    enum GenereEnum
    {
        Pop,
        Rock,
        Rap,
        Blues,
        RNB,
        Soul,
        Latino
    }
}
