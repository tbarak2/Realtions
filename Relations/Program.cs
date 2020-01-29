using Relations.Data.DataManagers;
using Relations.Data.GraphData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDataManager personManager = PersonDataManager.Instance;
            try
            {
                var s = personManager.GetAllData().Result.ToArray();
                PersonRelationGraph.Instance.CreateGraph(s);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
