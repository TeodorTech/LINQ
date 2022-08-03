using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Car
    {
        
        public string Name { get; set; }
        public float Price { get; set; }
        public bool isAvailable { get; set; }
        public string type { get; set; }
        public override string ToString() => $"{Name},{Price}";
        

        public static  List<Car> GenerateListOfProducts()
            {
            return new List<Car>
            {
                new Car{Name="Honda",Price =15000,isAvailable=true ,type ="Sport"},
                new Car{Name="Mazda",Price =25000,isAvailable=false,type ="Sport"} ,                
                new Car{Name="Dacia",Price =1000,isAvailable=false,type ="Clasic" } ,
                new Car{Name="Audi",Price =40000,isAvailable=true,type ="Comfort"},
                new Car{Name="Porche",Price =50000,isAvailable=true,type ="Sport"},
                new Car{Name="Mercedes",Price =100500,isAvailable=false,type ="Comfort"},
                new Car{Name="BMW",Price =50500,isAvailable=true,type ="Sport"},

            };

            }
}
}
