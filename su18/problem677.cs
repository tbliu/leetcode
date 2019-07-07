public class MapSum {

    private Dictionary<string, int> map { get; set; }
    /** Initialize your data structure here. */
    public MapSum() {
        this.map = new Dictionary<string, int>();
    }
    
    public void Insert(string key, int val) {
        if (this.map.ContainsKey(key)) {
            this.map[key] = val;
        } else {
            this.map.Add(key, val);
        }
    }
    
    public int Sum(string prefix) {
        return this.map
            .Where(kvp => prefix.Length <= kvp.Key.Length && kvp.Key.StartsWith(prefix))
            .Sum(kvp => kvp.Value);
    }
}

/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */