using System;
using System.Linq;
using Sorting;
using Algorithms.Datastructure.Interfaces;

namespace Algorithms
{
    class Program2
    {        
        public static void Main(string[] args)
        {
            var pObj = new Program();
            ILinkList list = new SingleLinkedList("header");            

            for(int i =1; i<=10;i++){               
               list.AddNode(new SingleLinkedList("data"+i.ToString()), i);
            }            

            list.GetAllNodes();

            list.DeleteNode(1);
            list.DeleteNode(2);
            list.DeleteNode(8);

            list.GetAllNodes();
        }
    }
}
