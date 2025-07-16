namespace AddTwoNumbers;

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
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(0);
        ListNode current = result;
        int carry = 0; // -> nhớ

        while (l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;

            int sum = x + y + carry;
            carry = sum / 10; // cập nhật phần nhớ
            int digit = sum % 10; // lấy chữ số hàng đvi

            current.next = new ListNode(digit);
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        return result.next;
    }

    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        ListNode listResult = AddTwoNumbers(l1, l2);
        while (listResult != null)
        {
            Console.Write(listResult.val);
            if (listResult.next != null) Console.Write(" -> ");
            listResult = listResult.next;
        }

    }
}
