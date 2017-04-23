namespace Sorting{
    public class SortAlgorithmSelector
    {
        public ISorting GetAlgorithmObjByName(string name)
        {
            ISorting sortingObj = null;
            switch(name)
            {
                case "bubble":
                     sortingObj = new BubbleSort();                     
                     break;
                case "merge":
                     sortingObj = new  MergeSort();
                     break;
            }

            return sortingObj;
        }
    }
}