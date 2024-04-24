using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public interface IAnimal
    {
        string Name {get;set;}
        string Habitat {get;set;}
        string EatingHabit {get;set;}
        void DisplayName();
    }
}