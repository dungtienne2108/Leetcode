namespace _141_LinkedListCycle
{
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
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next; // chay 1 lan
                fast = fast.next.next; // chay 2 lan

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            ListNode head = new ListNode(3, new ListNode(2, new ListNode(0, new ListNode(-4))));
            head.next.next.next = head.next;
            bool hasCycle = HasCycle(head);
            Console.WriteLine(hasCycle ? "yes" : "no");
        }
    }
}
