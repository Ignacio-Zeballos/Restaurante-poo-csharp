using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;

namespace Ucu.Poo.Restaurant
{
    public class Table
    {
        private string number;
        public string Number
        {
            get {return number;} set{number= value;}
        }
        private bool isoccupied;
        public bool IsOccupied
        {
            get {return isoccupied;} set{isoccupied = value;}
        }
        public Table(string number)
        {
            this.Number= number;
            this.IsOccupied = false;
        }
        private Order myorder;
        public void Occupy()
        {
            this.IsOccupied = true;
            myorder = new Order() ;
        }
        public void AddToOrder(Dish dish)
        {
             myorder.AddToOrder(dish);
        }
        public void Free()
        {
            this.IsOccupied= false;
        }
        public bool HasOrders()
        {
            if (myorder != null)
            {
                return true;
            }
            return false ;
        }
    }
}