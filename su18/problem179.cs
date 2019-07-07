public class Solution {
    public string LargestNumber(int[] nums) {
        List<String> list = nums.Select(x => x.ToString()).ToList();
        list.Sort((a, b) => String.Compare(a+b, b+a));
        StringBuilder largest = new StringBuilder();
        list.ForEach(x => largest.Append(x));
        return largest[0] == '0' ? "0" : largest.ToString();
    }
}