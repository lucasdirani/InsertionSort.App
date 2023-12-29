namespace InsertionSort.App.Algoritmos
{
    public static class AlgoritmoInsertionSort
    {
        public static void InsertionSort(int[] arr, int n)
        {
            int i, j, chave;
            for (i = 1; i < n; i++)
            {
                chave = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > chave)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = chave;
            }
        }
    }
}