using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBoxDesignPatterns.Interfaces;
using ToyBoxDesignPatterns.Models;

namespace ToyBoxDesignPatterns.Specifications
{
    internal class MinAgeSpecifciation(int minAge) : ISpecification<Toy>
    {
        readonly int _minAge = minAge;
        public bool IsSatisfiedBy(Toy toy) => toy.Age >= _minAge;
        
    }
}
