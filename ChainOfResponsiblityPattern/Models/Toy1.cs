using ChainOfResponsiblityPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Models
{
    internal class Toy1 : IToy
    {
        private IToy? nextToy;

        public void SetNextToy(IToy toy)
        {
            nextToy = toy;
        }

        public IToy? GetNextToy() => nextToy;

        public void HandleRequest(int request)
        {
            if(request <= 5)
            {
                Console.WriteLine("Toy1 can handle the request");
            }
            else if(nextToy != null)
            {
                nextToy.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("No Toy can handle the request");
            }
        }
    }
}
