using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{       
        public class Order
    {
        private List<Dish> order = new List<Dish>();
        public void AddToOrder(Dish dish)
        {
             order.Add(dish);
        }
        public double Total(Dish dish)
        {
            double subtotal = 0 ;
            foreach (Dish d in order)
            {
                subtotal +=  d.Price ;
            }
            return subtotal ;
        }
    }
}