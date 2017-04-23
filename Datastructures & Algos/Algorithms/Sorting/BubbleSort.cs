namespace Sorting{
    public class BubbleSort: ISorting
    {
        public int[] Sort(int[] arrayToSort)
        {   
            for(int i = (arrayToSort.Length - 1); i >=0; i-- )
            {
                for (int j = 1; j<=i; j++)
                {
                    if(arrayToSort[j-1] > arrayToSort[j])
                    {
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j-1];
                        arrayToSort[j-1] = temp;
                    }
                }
            }
            return arrayToSort;
        }   
    }
}