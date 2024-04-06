using ChainOfResponsiblityPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Models
{
    internal class ToyBox
    {
        private IToy? firstToy;

        public void AddToy(IToy toy)
        {
            if(firstToy == null)
            {
                firstToy = toy;
            }
            else
            {
                IToy currentToy = firstToy;

                while(currentToy != null)
                {
                    if(currentToy.GetType() == toy.GetType())
                    {
                        Console.WriteLine("This toy is already in the toy box.");
                        return;
                    }

                    if (currentToy.GetType().Name.CompareTo(toy.GetType().Name) > 0)
                    {
                        toy.SetNextToy(currentToy);

                        if(currentToy == firstToy)
                        {
                            firstToy = toy;
                        }
                        else
                        {
                            IToy? previousToy = firstToy;

                            while(previousToy != null && previousToy.GetType().Name != currentToy.GetType().Name)
                            {
                                previousToy = previousToy.GetNextToy();
                            }

                            previousToy?.SetNextToy(toy);
                        }
                        return;
                    }

                    if(currentToy.GetType().Name.CompareTo(toy.GetType().Name) < 0 && currentToy == firstToy)
                    {
                        currentToy.SetNextToy(toy);
                        firstToy = currentToy;
                        return;
                    }
                }
            }
        }
    }
}
