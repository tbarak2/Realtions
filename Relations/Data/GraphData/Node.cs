using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Data.GraphData
{
    public class Node<T>
    {
        public T Value { get; set; }
        public List<T> Nighbor { get; set; }
        //public Direction  { get; set; }
    }
}
