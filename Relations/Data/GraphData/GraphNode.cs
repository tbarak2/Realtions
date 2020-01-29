using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Data.GraphData
{
    public class GraphNode<T>
    {
        private List<GraphNode<T>> m_Connected = new List<GraphNode<T>>();

        public T value { get; set; }

        // get (and no set) - we don't want to assign the collection as whole
        // if we want to add/remove a neighbor we'll call Neighbors.Add, Neighbors.Remove
        public List<GraphNode<T>> Neighbors
        {
            get
            {
                return m_Connected;
            }
        }
    }
}
