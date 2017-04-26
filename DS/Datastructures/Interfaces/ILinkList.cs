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
namespace Algorithms.Datastructure.Interfaces{
    public interface ILinkList
    {       
        object GetData();
        void SetData(object data);
        void SetNext(ILinkList nextData);
        ILinkList GetNext();
        bool HasNextNode();
        void AddNode(ILinkList node, int index);
        void GetAllNodes();
        void DeleteNode(int index);
    }
}