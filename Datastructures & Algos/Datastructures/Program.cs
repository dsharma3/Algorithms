using System;
using System.Linq;
using Sorting;

namespace Algorithms
{
    class Program2
    {        
        public static void Main(string[] args)
        {
            var pObj = new Program();
            var list = new SingleLinkedList("header");            

            for(int i =1; i<=10;i++){               
               list.AddNode(new SingleLinkedList("data"+i.ToString()), i);
            }            

            list.GetAllNodes();
        }
    }
}
