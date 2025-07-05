namespace MergeTwoSortedList;

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

internal class Program
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode newList = new ListNode();
        ListNode current = newList;

        while (list2 != null && list1 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        current.next = list1 ?? list2;

        return newList.next;
    }

    public static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val);
            if (head.next != null) Console.Write(" → ");
            head = head.next;
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        ListNode merged = MergeTwoLists(list1, list2);

        PrintList(merged);
    }
}
