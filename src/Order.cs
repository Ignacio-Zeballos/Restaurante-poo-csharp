using System.Collections.Generic;

///La clase 'Order' tiene la responsabilidad de representar una orden,
/// permite agregar platillos y calcular el precio de la orden,
/// esto se hace porque no es responsabilidad del mozo o de la mesa,
/// cumpliendo con los principios de SRP.
namespace Ucu.Poo.Restaurant
{       
        public class Order
    {
        private List<Dish> order = new List<Dish>();
        public void AddToOrder(Dish dish) ///Método para agregar platillos a la orden
        {
             order.Add(dish);
        }
        public double Total()  ///Método para calcular el precio de la orden.
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