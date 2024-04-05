using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBoxDesignPatterns.Interfaces;
using ToyBoxDesignPatterns.Models;

namespace ToyBoxDesignPatterns.Specifications
{
    public class SizeSpecification(int size) : ISpecification<Toy>
    {
        public readonly int _size = size;
        public bool IsSatisfiedBy(Toy toy) => toy.Size == _size;        
    }
}
