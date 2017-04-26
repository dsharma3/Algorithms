/*
    1) The linked list is better from Array in following ways
        a) Array requires a fixed chunk of memory which is sometime not available due to memory constraints.
        b) Array's can't be resized dynamically as compared to linked 
    2) The cons of linked list.
        a) The traversal time in worst case is O(n) if the element is lying at the end of the list.
        b) The deletion and insertion is having O(n) in worst case scenario.
        c) Same case with searching\traversing the time complexity is O(n) in worst case.

 */
using System;
namespace Algorithms{
    public class SingleLinkedList
    {
        private object mData;
        private SingleLinkedList mNext;    

        public object Data{
            get{
                return mData;
            }
            private set{
                mData = value;
            }
        }
        
        public SingleLinkedList Next{
            get{
                return mNext;
            }
            private set{
                mNext = value;
            }
        }

        public SingleLinkedList(){

        }

        public SingleLinkedList(object data){
            this.Data = data;
        }

        public object GetData(){

            return this.Data;
        }

        public void SetData(object data){
            this.Data = data;
        }

        public void SetNext(SingleLinkedList nextData){
            this.Next = nextData;
        }

        public SingleLinkedList GetNext(){
            return this.Next;
        }   

        public bool HasNextNode(){
            return this.Next != null;
        }     

        public void AddNode(SingleLinkedList node, int index){
            var count = 0;
            var currentNode = this;
            while(true){   
                if(currentNode.HasNextNode()){   
                    currentNode = currentNode.Next;               
                   
                    if(count == index){
                        var temp = currentNode.Next;
                        currentNode.Next = node;
                        node.Next = temp;
                        break;
                    }
                    count++;
                 }
                 else{
                     currentNode.Next = node;
                     break;
                 }
            }
        }

        public void GetAllNodes(){
            var count = 0;
            var currentNode = this;          
             while(currentNode.HasNextNode()){ 
                currentNode = currentNode.Next;    
                Console.WriteLine("Node-no:{0}, Node-data-{1}", count, currentNode.GetData().ToString());
                count++;
             }
        } 

        public void DeleteNode(int index){
            var count = 1;
            var currentNode = this;
            while(true){
                Console.WriteLine(count);                
                if(currentNode!=null){
                    if(count==index){
                        var temp = currentNode.Next;

                        if(temp != null)
                            currentNode.Next = temp.Next;                       
                        else
                            currentNode = null;
                        break;
                    }
                    count++;
                }
                currentNode = currentNode.Next;
            }
        }
    }
}