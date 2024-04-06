using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Interfaces
{
    internal interface IToy
    {
        void HandleRequest(int request);
        void SetNextToy(IToy? toy);
        IToy? GetNextToy();
    }
}
