/*
    1) The linked list is better from Array in following ways
        a) Array requires a fixed chunk of memory which is sometime not available due to memory constraints.
        b) Array's can't be resized dynamically as compared to linked 
    2) The cons of linked list.
        a) The traversal time in worst case is O(n) if the element is lying at the end of the list.
        b) The deletion and insertion is having O(n) in worst case scenario.
        c) Same case with searching\traversing the time complexity is O(n) in worst case.

 */
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
                Next = value;
            }
        }

        public SingleLinkedList(){

        }

        public SingleLinkedList(object data){
            this.Data = data;
        }

        public void GetData(){

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

        public void AddNode(SingleLinkedList node){
            while(true){
                if(){

                }
            }
        }        
    }
}