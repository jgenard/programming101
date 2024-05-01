namespace Variables101;

public class Arrays
{
    public void DeclareArrays()
    {
        int[] array1 = new int[5]; // Declare a single-dimensional array of 5 integers.

        int[] array2 = [1, 2, 3, 4, 5, 6]; // Declare and set array element values.

        int[,] multiDimensionalArray1 = new int[2, 3]; // Declare a two dimensional array.

        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // Declare and set array element values.

        int[][] jaggedArray = new int[6][]; // Declare a jagged array.

        jaggedArray[0] = [1, 2, 3, 4]; // Set the values of the first array in the jagged array structure.
    }
}
