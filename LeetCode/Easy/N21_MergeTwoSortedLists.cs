using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class N21_MergeTwoSortedLists : IProblem
    {
        /*
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int val=0, ListNode next=null) {
         *         this.val = val;
         *         this.next = next;
         *     }
         * }
         */

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

        public int Index => 21;

        public string Name => "Merge Two Sorted Lists";

        public string Description =>    "Given the heads of sorted lists, return the head of A list that is a merged AND sorted version of the lists." +
                                        "The head is a class ListNode which is defined above";

        public string Link => "https://leetcode.com/problems/merge-two-sorted-lists/";

        public DateTime SolvedDate => new (2023, 09, 14);

        public void BestCode()
        {
            throw new NotImplementedException();
        }

        public void TestCode()
        {
            ListNode list1_2 = new ListNode(4);
            ListNode list1_1 = new ListNode(2, list1_2);
            ListNode list1 = new ListNode(1, list1_1);

            ListNode list2_2 = new ListNode(4);
            ListNode list2_1 = new ListNode(3, list2_2);
            ListNode list2 = new ListNode(1, list2_1);

            ListNode result = MergeTwoSortedLists(list1, list2);

            int count = 0;
            while(result != null)
            {
                Console.WriteLine(count + ": " + result.val);
                result = result.next;
                count++;
            }
        }

        public ListNode MergeTwoSortedLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            else if (list2 == null) return list1;

            int listCount = 2;
            
            ListNode tmp1 = list1;
            ListNode tmp2 = list2;

            while (true)
            {
                if (tmp1.next != null)
                {
                    listCount++;
                    tmp1 = tmp1.next;
                }

                if (tmp2.next != null)
                {
                    listCount++;
                    tmp2 = tmp2.next;
                }

                if (tmp1.next == null && tmp2.next == null) break;
            }

            ListNode[] mainArr = new ListNode[listCount];

            for (int i = 0; i < listCount; i++)
            {
                if (list2 == null || (list1 != null && list1.val <= list2.val))
                {
                    mainArr[i] = list1!;
                    list1 = list1!.next;
                }
                else
                {
                    mainArr[i] = list2;
                    list2 = list2.next;
                }

                if(i != 0)
                    mainArr[i - 1].next = mainArr[i];
            }

            return mainArr[0];
        }
    }
}
