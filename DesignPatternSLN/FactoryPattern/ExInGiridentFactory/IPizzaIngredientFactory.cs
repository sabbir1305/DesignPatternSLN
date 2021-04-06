using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternSLN.FactoryPattern.ExInGiridentFactory
{
   public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreatCheese();
        IViggies[] CreatVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }

    public interface IDough
    {

    }

    public interface ISauce
    {

    }
    public interface ICheese
    {

    }

    public interface IViggies
    {

    }
    public interface IPepperoni
    {

    }

    public interface IClams
    {

    }

}
