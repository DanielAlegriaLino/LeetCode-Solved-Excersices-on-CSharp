var sol = new Solution();
var lista1 = new ListNode(1, new ListNode(2, null));
var lista2 = new ListNode(1, new ListNode(3, new ListNode(4)));

var res = sol.MergeTwoLists(lista1, lista2);

while (res != null) 
{
	Console.WriteLine(res.val);
	res = res.next;
}


public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}

public class Solution
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{
		if (list1 == null && list2 == null) 
		{ 
			return null; 
		}
		else if(list1 == null) 
		{
			return new ListNode(list2.val,MergeTwoLists(list1,list2.next));
		}
		else if(list2 == null) 
		{
			return new ListNode(list1.val,MergeTwoLists(list1.next,list2));
		}

		if(list1.val <= list2.val) 
		{
			return new ListNode(list1.val,MergeTwoLists(list1.next, list2));
		}
		else if (list2.val < list1.val) 
		{
			return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
		}

		return null;

	}
}