namespace _206_ReverseLinkedList
{
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
        public static ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }

        static void Main(string[] args)
        {

            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            ListNode reversedHead = ReverseList(head);
            ListNode current = reversedHead;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
        }
    }
}
