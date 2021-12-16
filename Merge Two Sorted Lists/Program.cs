var sol = new Solution();
var lista1 = new ListNode(1, new ListNode(2, new ListNode(4)));
var lista2 = new ListNode(1, new ListNode(3, new ListNode(4)));


sol.MergeTwoLists(lista1, lista2 );


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


		var current_list_node = list1;
		do
		{
			Console.WriteLine(current_list_node.val);
			current_list_node = current_list_node.next;
		} while (current_list_node != null);

		return new ListNode();
	}
}