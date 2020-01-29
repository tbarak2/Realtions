using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Data.GraphData
{
    public interface IRelationsGraph<T>
    {
       

        void CreateGraph(T[] array);

    }
}
