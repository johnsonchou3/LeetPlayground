using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
            {
                return null;
            }
            var leftDummy = new ListNode();
            var rightDummy = new ListNode();
            var leftPointer = leftDummy;
            var rightPointer = rightDummy;
            while (head != null)
            {
                ListNode temp = head.next;
                if (head.val < x)
                {
                    leftPointer.next = head;
                    leftPointer = leftPointer.next;
                    leftPointer.next = null;
                }
                else
                {
                    rightPointer.next = head;
                    rightPointer = rightPointer.next;
                    rightPointer.next = null;
                }
                head = temp;
            }
            if (leftDummy.next == null)
            {
                return rightDummy.next;
            }
            leftDummy = leftDummy.next;
            rightDummy = rightDummy.next;
            leftPointer.next = rightDummy;
            return leftDummy;
        }
    }
}
