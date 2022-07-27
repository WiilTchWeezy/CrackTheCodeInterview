using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.StacksAndQueue
{
    public class ThreePointSix
    {
        private MyQueue<Cat> _cat = new MyQueue<Cat>(10);
        private MyQueue<Dog> _dog = new MyQueue<Dog>(10);

        public void Enqueue(Animal animal)
        {
            animal.EnterDate = DateTime.Now;
            if (animal.GetType() == typeof(Cat))
                _cat.Enqueue(animal as Cat);
            else
                _dog.Enqueue(animal as Dog);
        }

        public Animal Dequeue()
        {
            if (_cat.Peek().EnterDate < _dog.Peek().EnterDate)
                return _cat.Dequeue();
            else
                return _dog.Dequeue();
        }

        public Animal Dequeue<T>()
        {
            if (typeof(T) == typeof(Cat))
                return _cat.Dequeue();
            else
                return _dog.Dequeue();
        }
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {

    }

    public abstract class Animal : IComparable
    {
        public string Name { get; set; }
        public DateTime EnterDate { get; set; }

        public int CompareTo(object obj)
        {
            var typedObj = (Animal)obj;
            if (typedObj.Name == this.Name)
                return 0;
            else 
                return 1;
        }

        public override string ToString()
        {
            return $"{Name} - {EnterDate:dd/MM/yyyy HH:mm:ss fffff}";
        }
    }
}
