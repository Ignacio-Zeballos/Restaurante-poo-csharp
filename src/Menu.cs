using System;
using System.Collections.Generic;

/// Representacion del menú, tiene la responsabilidad de almacenar los platillos existentes,
/// puede agregar o eliminar platillos del mismo,
/// tiene un metodo para buscar platillos dentro del menú.
/// Cumple SRP porque solo gestiona los platillos almacenados.
namespace Ucu.Poo.Restaurant
{
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }
        public Dish GetDishByName(string dish)
        {
            foreach (Dish d in dishes)
            {
                if (d.Name == dish)
                {
                    return d ;
                }
            }
            return null;
        }
    }
}