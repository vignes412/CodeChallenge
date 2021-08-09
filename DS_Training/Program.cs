using DS_Training.Data_structure;
using DS_Training.Data_structure.String;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DS_Training
{
    public  class test
    {
        public test1 MyProperty { get; set; }
    }
    public class test1
    {
        public int MyProperty { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            KMPPatternSearch kp = new KMPPatternSearch();
                kp.StrStr("ABABDABACDABABCABAB", "ABABCABAB");
            string x = "65465164864654684";
            //Console.WriteLine(int.Parse(x));
            //Console.WriteLine(LongestSubSequenceArray.LengthOfLIS2(JsonConvert.DeserializeObject<int[]>(" [0,1,0,3,2,3]")));    
            var test = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ReverseNodeKGroup rg = new ReverseNodeKGroup();
            rg.ReverseKGroup2(test, 3);
            Console.WriteLine(FirstUniqChar.Solution("aabb"));

            Console.ReadLine();
        }
        public static void Main1()
        {
            Console.WriteLine("Welcome");
            int key = -1;
            while (key != 0)
            {
                Console.WriteLine("Select your option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Search");
                Console.WriteLine("2.Sort");
                Console.Write("Enter the number: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        SearchCase();
                        break;
                    case 2:
                        SortCase();
                        break;
                   
                }
               
            Console.ReadKey();
            }
       
        }
        #region Menu settings
        private static void SearchCase()
        {
            Console.WriteLine("1.Binary search");
            Console.WriteLine("2.Pair In Sorted Array");
            Console.WriteLine("3.Jump Search");
            Console.WriteLine("4.Interpolation Search");
            Console.Write("Enter the number: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    BinarySearchCase();
                    break;
                case 2:
                    PairInSortedArrayCase();
                    break;
                case 3:
                    JumpSearchCase();
                    break;
                case 4:
                    InterpolationSearchCase();
                    break;
            }
        }
        private static void SortCase()
        {
            Console.WriteLine("1.Selection Sort");
            Console.WriteLine("2.Bubble Sort");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("4.Quick Sort");
            Console.WriteLine("5.Merge Sort");
            Console.Write("Enter the number: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    SelectionSortCase();
                    break;
                case 2:
                    BubbleSortCase();
                    break;
                case 3:
                    InsertionSortCase();
                    break;
                case 4:
                    QuickSortCase();
                    break;
                case 5:
                    MergeSortCase();
                    break;
            }
        }


        #endregion

        #region Sort
        private static void SelectionSortCase()
        {
            Console.WriteLine("********************Selection Sort*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            SelectionSort.Sort(input);
            Console.WriteLine(JsonConvert.SerializeObject(input));
        }
        private static void BubbleSortCase()
        {
            Console.WriteLine("********************Bubble Sort*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            BubbleSort.Sort(input);
            Console.WriteLine(JsonConvert.SerializeObject(input));
        }
        private static void InsertionSortCase()
        {
            Console.WriteLine("********************Insertion Sort*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            InsertionSort.Sort(input);
            Console.WriteLine(JsonConvert.SerializeObject(input));
        }
        private static void QuickSortCase()
        {
            Console.WriteLine("********************Quick Sort*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            QuickSort.Sort(input);
            Console.WriteLine(JsonConvert.SerializeObject(input));
        }
        private static void MergeSortCase()
        {
            Console.WriteLine("********************Merge Sort*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            MergeSort.Sort(input);
            Console.WriteLine(JsonConvert.SerializeObject(input));
        }
        #endregion

        #region Array Related methods
        public static void BinarySearchCase()
        {
            Console.WriteLine("********************Binary Search*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the sorted array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            Console.WriteLine("Enter the Search Value:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BinarySearch.IterativeSearch(input, 0, input.Length, value));
            Console.WriteLine(BinarySearch.count);
        }
        public static void PairInSortedArrayCase()
        {
            Console.WriteLine("********************Pair in Sorted Array*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the sorted array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            Console.WriteLine("Enter the Value:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PairInSortedArray.pairsInSortedRotated(input, input.Length, value));
            //Console.WriteLine(BinarySearch.count);
        } 
        public static void JumpSearchCase()
        {
            Console.WriteLine("********************Jump Search*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the sorted array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            Console.WriteLine("Enter the Value:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(JumpSearch.Search(input, input.Length, value));
        }
        private static void InterpolationSearchCase()
        {
            Console.WriteLine("********************Interpolation Search*************************");
            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)}";
            Console.WriteLine("Enter the sorted array string :");
            string test = Console.ReadLine();
            int[] input = JsonConvert.DeserializeObject<int[]>(test);
            Console.WriteLine("Enter the Search Value:");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(InterpolationSearch.Search(input, 0, input.Length - 1, value));
        }
        #endregion


        #region load json side methods
        public T LoadJson<T>(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                T items = JsonConvert.DeserializeObject<T>(json);
                return items;
            }
        }
        public static T[] stringToArray<T>(string value)
        {
            return value.Split(',')
                .Select(x => (T)Convert.ChangeType(x, typeof(T)))
                .ToArray();
        }
        public static int max(int x, int y)
        {
            return y > x ? y : x;
        }
        public static int GetDecimalValue(MyNode head)
        {
            int num = 0;
            while (head != null)
            {
                num = (num * 2) + head.data;
                head = head.next;
            }
            return num;
        } 
        #endregion
      
        
        /*static void Main(string[] args)
        {
            Console.WriteLine( "Test");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(10);
            linkedList.Add(10);
            linkedList.Add(30);
            linkedList.Add(30);
            linkedList.Add(50);
            linkedList.Add(50);
            linkedList.Add(70);
            linkedList.Add(70);
            linkedList.Add(90);
            linkedList.Add(90);
            //linkedList.RemoveNthFromEnd(linkedList.Head, 2);
            linkedList.DeleteDuplicates(linkedList.Head);
            linkedList.DisplayAllNode();

            Console.ReadKey();
        }*/
    }
}
