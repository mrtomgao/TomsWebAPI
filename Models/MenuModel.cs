using System.Collections.Generic;

namespace TomsAPI.Models
{
    public class MenuModel
    {
        public MenuItem menuItm { get; set; }

        public MenuModel(int id)
        {
            List<MenuItem> menuList = new List<MenuItem>()
            {
                //in leiu of some Database Shiz do this hard coded adding.
                new MenuItem { ID = 1, Name = "Pancakes with drizzled sauce", Price = 10.99, Available = true },
                new MenuItem{ ID = 2, Name = "Hamburger with Chicken MacNuggets", Price = 7.95, Available = true },
                new MenuItem{ ID = 3, Name = "Broccoli + Saltine Crackers ", Price = 21.99, Available = false },
                new MenuItem { ID = 4, Name = "Country Fried pinto beans", Price = 27.50, Available = true },
                new MenuItem { ID = 5, Name = "Mama's favorite scramble", Price = 10.99, Available = true },
                new MenuItem { ID = 6, Name = "Bowl of mosquitos with BBQ sauce", Price = 12.98, Available = false }
            };

            menuItm = menuList.Find(x => x.ID == id);

        }

        public struct MenuItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public bool Available { get; set; }
        }

    }
}