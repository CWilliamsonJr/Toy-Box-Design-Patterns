using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBoxDesignPatterns.Interfaces;
using ToyBoxDesignPatterns.Models;

namespace ToyBoxDesignPatterns.Filters
{
    internal class ToyFilter
    {
        public IEnumerable<Toy> Filters(IEnumerable<Toy> toys, ISpecification<Toy> specification) => toys.Where(specification.IsSatisfiedBy);
    }
}