public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Plan
        //1. Create a new array using doubles with the size specified by 'length'.
        //2. loop from 1 to 'length' to generate each multiple.
        //3. calculate the multiple inside teh loop (number * current loop index)
        //4. store the multiple in the array at the correct position (index-1)
        //5. return the array with the new value

        var result = new double[length];
        for (int i = 1; i <= length; ++i)
        {
            result[i - 1] = number * i;
        }

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //PLAN
        //1. find the starting point of the section that needs to be moved. This will be 'data.count - amount'
        //2. get the sub-list of elements fromt eh starting point to the end of list
        //3. remove the same sublist of elements from the original list
        //4 insert the sublist that was saved at the beginning

        var splitIndex = data.Count - amount;

        //get items to be moved to the front
        List<int> itemsToMove = data.GetRange(splitIndex, amount);
        //remove tems from end
        data.RemoveRange(splitIndex, amount);
        //add back to the beggining
        data.InsertRange(0, itemsToMove);
    }
}
