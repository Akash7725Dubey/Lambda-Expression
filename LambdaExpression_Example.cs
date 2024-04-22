using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Demo
{

    //Example 1
    //public  static class demo
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<int> list = new List<int>() {1,2,3,4,5,6 };
    //        List<int>evenNumbers=list.FindAll(x=>(x%2)==0).ToList();
    //FindAll retrieves all the element that matches the condition

    //        foreach(var num in evenNumbers)
    //        {
    //            Console.WriteLine(num);
    //        }
    //        List<int> OddNumber = list.FindAll(x => (x % 2) == 1).ToList();
    //        foreach(var num in OddNumber)
    //        {
    //            Console.WriteLine(num);
    //        }
    //    }
    //}






    //Example 2

    //class Dog
    //{
    //public string Name { get; set; }
    //public int Age {  get; set; }

    //}
    //class Demo {
    //    static void Main(string[] args)
    //    {
    //        List<Dog>list = new List<Dog>()
    //        { new Dog{Name="Roomy",Age=23},
    //          new Dog{Name="Rocky",Age=21},
    //          new Dog{Name="Rambo",Age=22}
    //        }   ;
    //        var Names=list.Select(x=>x.Age).ToList();
    //        foreach(var dog in Names){
    //            Console.WriteLine(dog);
    //        }

    //    }

    //}








    //Using Lambda Expression with Anonymous Types

    //class Dog
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<Dog> dogs = new List<Dog>()
    //        {
    //            new Dog{Name="Rommy",Age=11},
    //            new Dog{Name="Monty",Age=6},
    //            new Dog {Name="Syamu",Age=23}
    //        };
    //        var newDogList = dogs.Select(x => new { Age=x.Age, Name=x.Name[1] });
    //        foreach (var dog in newDogList)
    //        {
    //            Console.WriteLine(dog);
    //        }

    //        //Sorting using Lambda Expression
    //        var SortedDogs = dogs.OrderByDescending(x => x.Age);
    //        //OrderByDescending is used to sort the element in descending order based on their key
    //        foreach (var dog in SortedDogs)
    //        {
    //            Console.WriteLine($"Name: {dog.Name} Age:{dog.Age}");
    //        }
    //    }
   // }









    

}
