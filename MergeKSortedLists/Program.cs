namespace MergeKSortedLists
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

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;

            PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

            foreach (var head in lists)
            {
                if (head != null)
                    minHeap.Enqueue(head, head.val);
            }

            ListNode result = new ListNode();
            ListNode current = result;

            while (minHeap.Count > 0)
            {
                var node = minHeap.Dequeue();
                current.next = node;
                current = current.next;

                if (node.next != null)
                    minHeap.Enqueue(node.next, node.next.val);
            }

            return result.next;
        }

        static void Main(string[] args)
        {
            ListNode[] lists = new ListNode[]
            {
                new ListNode(1, new ListNode(4, new ListNode(5))),
                new ListNode(1, new ListNode(3, new ListNode(4))),
                new ListNode(2, new ListNode(6))
            };
            ListNode mergedList = MergeKLists(lists);

            while (mergedList != null)
            {
                Console.Write(mergedList.val + " ");
                mergedList = mergedList.next;
            }
        }
    }
}
