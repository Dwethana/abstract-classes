using System;
namespace diffrentClasses{
    //an abstract class has always abstract in it
    public abstract class animal
    {
        int a= 35;
        public abstract void walk(); //this is an abstract method, I have to declare it like that
    }
    //the class dog  inherits the class animal
    public class dog : animal
    {
        //I have to use override, otherwise I can't use the method walk
        public override void walk()
        {
            Console.WriteLine("The dog is walking.");
        }
    }

    public class cat : animal
    {
        public override void walk()
        {
            Console.WriteLine("The cat is walking and is making catnoises.");
        }
    }

}