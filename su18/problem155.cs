public class MinStack {

    public Stack<int> Values { get; set; }
	public Stack<int> Min { get; set; }
	
	/** initialize your data structure here. */
	public MinStack()
	{
		Values = new Stack<int>();
		Min = new Stack<int>();
     
	}

	public void Push(int x)
	{
		Values.Push(x);
		if(Min.Count == 0 || x <= GetMin())
		{
			Min.Push(x);
		}
	}

	public void Pop()
	{
		int popped = Values.Pop();
		if(popped==GetMin())
		{
			Min.Pop();
		}
	}

	public int Top()
	{
		return Values.Count==0 ? 0 : Values.Peek();
	}

	public int GetMin()
	{
		return Min.Count == 0 ? 0 : Min.Peek();
	}
}