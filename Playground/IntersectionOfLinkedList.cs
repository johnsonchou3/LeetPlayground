using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class IntersectionOfLinkedList
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }
            var seen = new HashSet<ListNode>();
            while (headA != null)
            {
                seen.Add(headA);
                headA = headA.next;
            }
            while (headB != null)
            {
                if (seen.Contains(headB))
                {
                    return headB;
                }
                headB = headB.next;
            }
            return null;
        }
    }
}
