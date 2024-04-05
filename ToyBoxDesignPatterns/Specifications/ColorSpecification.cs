using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBoxDesignPatterns.Interfaces;
using ToyBoxDesignPatterns.Models;

namespace ToyBoxDesignPatterns.Specifications
{
    public class ColorSpecification(string color) : ISpecification<Toy>
    {
        public readonly string _color = color;
        public bool IsSatisfiedBy(Toy toy) =>  toy.Color == _color;
        
    }
}
