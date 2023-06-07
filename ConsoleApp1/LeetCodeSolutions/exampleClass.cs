namespace ConsoleApp1.LeetCodeSolutions
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

    public class teasdads
    {

        public void naberr(Func<string, int> methodsx)
        {
            var result = methodsx.Invoke("45");
            Console.WriteLine("func dan gelen deger:" + result.ToString());
        }

        public void islem(Action isgor)
        {
            isgor.Invoke();
        }

    }



    public class Solutionfx
    {

        public int stepper(int[] nums)
        {
            List<int> result = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int next = i + 1;
                if (next > nums.Length - 1)
                {
                    next = i;
                }
                int nextValue = nums[next];
                int value = nums[i];


                if (value <= nextValue)
                {

                }
            }

            return 0;

        }


        public int TotalSteps(int[] nums)
        {
            List<int> result = new List<int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int next = i + 1;
                if (next > nums.Length - 1)
                {
                    next = i;
                }
                int nextValue = nums[next];
                int value = nums[i];


                if (value <= nextValue)
                {
                    result.Add(i);
                }
            }

            return 0;

        }

        //public ListNode MergeKLists(ListNode[] lists)
        //{
        //    List<int> sayilar = new List<int>();
        //    void nexalici(ListNode node)
        //    {
        //        sayilar.Add(node.val);
        //        if (node.next != null)
        //        {
        //            nexalici(node.next);
        //        }
        //    }

        //    ListNode oteleyici(ListNode node)
        //    {
        //        var temp = node;
        //        node.next = temp;
        //        node.next.val = temp.val;
        //        return node;
        //    }

        //    foreach (var item in lists)
        //    {
        //        nexalici(item);
        //    }
        //    var order = sayilar.OrderBy(x => x);

        //    ListNode dummyHead = new ListNode(0);
        //    ListNode current = dummyHead;

        //    foreach (var item in order)
        //    {
        //        current.next = new ListNode(item);
        //        current = current.next;
        //    }
        //    return dummyHead.next;
        //}

    }




}
