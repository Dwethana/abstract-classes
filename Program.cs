using System;
using diffrentClasses;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            animal [] animals = new animal [3]; //I create a object animal
            animals[0]=new cat(); //in array 0 is the method walk from cat class
            animals[1]= new dog(); // in array 1 is the method walk from dog class
            animals [2]=new cat ();//in array 0 is the method walk from cat class
            //always when I use the class cat or dog, the method walk overrides the abstract method walk from class animal
            
            foreach (animal t in animals)
            {
                t.walk();
            }
        }
    }
}
