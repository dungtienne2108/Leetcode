public class ListNode
{
    public int Value { get; set; }
    public ListNode Next { get; set; }
    public ListNode(int value = 0, ListNode next = null)
    {
        Value = value;
        Next = next;
    }
}

internal class Program
{
    public static ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode temp = head;
        for (int i = 0; i < k; i++)
        {
            if (temp == null) return head;
            temp = temp.Next;
        }

        ListNode previous = null;
        ListNode current = head;

        for (int i = 0; i < k; i++)
        {
            ListNode next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        head.Next = ReverseKGroup(temp, k);

        return previous;
    }

    static void Main(string[] args)
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode reversed = ReverseKGroup(head, 3);
        while (reversed != null)
        {
            Console.Write($"{reversed.Value} ->");
            reversed = reversed.Next;
        }
    }
}