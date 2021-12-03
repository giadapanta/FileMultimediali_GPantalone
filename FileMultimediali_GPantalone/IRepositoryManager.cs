using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali_GPantalone
{
   interface IRepositoryManager<T>
    {
        public List<T> Fetch();
    }
}
