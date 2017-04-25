using System;
using System.Linq;
using Sorting;

namespace Algorithms
{
    class Program
    {        
        public static void Main(string[] args)
        {
            var pObj = new Program();
            var list = new SingleLinkedList("header");            

            for(int i =0; i<10;i++){               
               var nextList = new SingleLinkedList("data"+i.ToString());               
            }            
        }
    }
}
