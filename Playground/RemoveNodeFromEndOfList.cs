namespace Playground;

public class RemoveNodeFromEndOfList
{
    // 0 1 2 3 4 5 6 7 ; 4
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var right = head;
        var lastLeft = head;
        var left = head;
        var result = head;

        for (int i = 1; i < n; i++)
        {
            if (right.next == null)
            {
                return null;
            }
            right = right.next;
        }

        while (right.next != null)
        {
            right = right.next;
            lastLeft = left;
            left = left.next;
        }
        
        RemoveNode(left, lastLeft);
        return result;
        void RemoveNode(ListNode cur, ListNode last)
        {
            var temp = cur.next;
            last.next = temp;
        }
    }
}