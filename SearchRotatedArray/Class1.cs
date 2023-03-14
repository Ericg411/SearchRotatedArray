namespace SearchRotatedArray;
public class Class1
{
    public int Search(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                return i;
        }
        return -1;
    }
}
