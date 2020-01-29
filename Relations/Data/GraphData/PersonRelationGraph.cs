using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Data.GraphData
{
    class PersonRelationGraph : IRelationsGraph<Person>
    {
        private static readonly Lazy<PersonRelationGraph> lazy = new Lazy<PersonRelationGraph>(() => new PersonRelationGraph());

        public static PersonRelationGraph Instance { get { return lazy.Value; } }

        private List<Node<Person>> _nodes;
        private PersonRelationGraph()
        {
            _nodes = new List<Node<Person>>();
        }
        
        public List<Node<Person>> Nodes 
        {
            get
            {
                return _nodes;
            }
            //set
            //{
            //    _nodes.Add(value);
            //}
        }

        //public void CreateGraph(T[] array)
        //{
        //    for(int i =0 is< array.Length in array)
        //}
        public void CreateGraph(Person[] array)
        {
            for (int i = 0;  i< array.Length; ++i)
            {
                
                var nodesWithRealtionName = Nodes.Where(n => n.Value.FullName == array[i].FullName).ToList();
                if (nodesWithRealtionName.Any())
                {
                    nodesWithRealtionName.ForEach(n =>
                    {
                        n.Nighbor.Add(array[i]);
                    });
                }
                var nodesWithRealtionAddress = Nodes.Where(n => n.Value.FullName == array[i].FullName).ToList();
                if (nodesWithRealtionName.Any())
                {
                    nodesWithRealtionName.ForEach(n =>
                    {
                        if (!n.Nighbor.Contains(array[i]))
                        {
                            n.Nighbor.Add(array[i]);
                        }
                    });
                }
                Nodes.Add(new Node<Person> { Value = array[i], Nighbor = new List<Person>() });
            }
        }
    }
}
