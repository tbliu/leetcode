public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> ret = new List<IList<int>>();
        Helper(candidates, target, 0, ret, new List<int>());
        return ret;
    }

    private void Helper(int[] candidates, int target, int pos,
        IList<IList<int>> list, IList<int> listSoFar) {
            if (target == 0) {
                list.Add(listSoFar);
                return;
            } else if (pos >= candidates.Count() || target < 0) {
                return;
            } else {
                IList<int> takePos = new List<int>(listSoFar);
                takePos.Add(candidates[pos]);
                Helper(candidates, target, pos + 1, list, new List<int>(listSoFar));
                Helper(candidates, target - candidates[pos], pos, list, takePos);
            }
    }
}