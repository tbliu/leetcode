public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] wait = new int[temperatures.Length];
        Stack<int> indices = new Stack<int>();
        for (var i = 0; i < temperatures.Length; i++) {
            while (indices.Count() > 0 && temperatures[indices.Peek()] < temperatures[i]) {
                var index = indices.Pop();
                wait[index] = i - index;
            }
            indices.Push(i);
        }
        return wait;
    }
}