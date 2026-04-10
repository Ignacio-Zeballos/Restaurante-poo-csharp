using System.Collections.Generic;

///Representación de un mozo del restaurante,
/// tiene informacion como su nombre y una mesa asignada,
/// puede tomar pedidos o asignar mesas.
/// Cumple con SRP porque solo maneja las responsabilidade asociadas a un mozo.
namespace Ucu.Poo.Restaurant
{
    public class Waiter
    {
        private List<Table> assignedTables = new List<Table>();
        private string name;
        public string Name
        {
            get {return name;} set{name= value;}
        }
        public Waiter(string name)
        {
            this.Name= name;
        }
        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}