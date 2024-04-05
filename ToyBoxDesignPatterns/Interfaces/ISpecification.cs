using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBoxDesignPatterns.Interfaces
{
    internal interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T item);
    }
}
