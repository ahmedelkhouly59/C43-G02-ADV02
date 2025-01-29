using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace ADV_C_02
{
    internal class Program
    {
        public static void countNumberInArr(int[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int c = 0;
                Console.Write("Enter a number to check : ");
                int x = int.Parse(Console.ReadLine() ?? "0");
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < x)
                    {
                        c++;
                    }
                }
                Console.WriteLine($"Number {x} is bigger than {c} elements in array");
            }
        }
        public static bool palindrome(int[] arr) {
            for (int i =0;i< arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                    return false;
            }
            return true;
        }
        public static List<int> ArrayIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in arr1)
            {
                if (countMap.ContainsKey(num))
                    countMap[num]++;
                else
                    countMap[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (countMap.ContainsKey(num) && countMap[num] > 0)
                {
                    result.Add(num);
                    countMap[num]--;  
                }
            }

            return result;
        }
        public static List<int> removeDuplicate (int[] arr)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            List<int> result = new List<int>();

            for (int i=0;i< arr.Length; i++)
            {
                if (!countMap.ContainsKey(arr[i]))
                {
                    countMap[arr[i]] = 1;
                    result.Add(arr[i]);

                }
            }
            return result;
        }
        public static void removeOdd(ArrayList list) {
            for (int i =0;i< list.Count; i++)
            {
                if ((int)list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        public static void ReverseQueue(Queue<int> queue)

        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        public static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        {
            if (queue == null || queue.Count == 0 || k > queue.Count || k <= 0)
                return queue;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
                queue.Enqueue(queue.Dequeue());

            return queue;
        }
        public static void countUntillTarget(Stack<int> stack, int num)
        {
            int len = stack.Count;
            int count = 0;
            while (stack.Count > 0) { 
                if (stack.Pop() == num)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
                else
                {
                    count++;
                }
                if (count == len)
                {
                    Console.WriteLine("Not found");
                    return;
                }
            }
        }
        public static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);  
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0) return false; 

                    char top = stack.Pop(); 
                    
                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; 
        }
        public static ArrayList FindSublistWithSum(ArrayList list, int targetSum)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int currentSum = 0;
                ArrayList currentSublist = new ArrayList();

                for (int j = i; j < list.Count; j++)
                {
                    currentSum += (int)list[j]; 
                    currentSublist.Add(list[j]);

                    if (currentSum == targetSum)
                    {
                        return currentSublist;
                    }
                    else if (currentSum > targetSum)
                    {
                        break;
                    }
                }
            }

            return null; 
        }
        static void Main(string[] args)
        {
            #region q1
            //int[] arr = { 1, 2, 3, 4, 5, 6, 10, 12 };
            //int number = 3;
            //countNumberInArr(arr, 3);
            #endregion
            #region q2
            //int[] arr = { 1, 2, 3, 2, 1 };
            //if (palindrome(arr))
            //    Console.WriteLine("This array is Palindrome");
            //else
            //    Console.WriteLine("This array isn't Palindrome");
            #endregion
            #region q3
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine("Original Queue: " + string.Join(", ", queue)); ReverseQueue(queue);
            //Console.WriteLine("After Reversing : ");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            #endregion
            #region q4
            //string input = "[()]{()}";

            //if (IsBalanced(input))
            //    Console.WriteLine("This is Balanced");
            //else
            //    Console.WriteLine("This is not Balanced");
            #endregion
            #region q5
            //int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 6 };
            //List <int> result = removeDuplicate(arr);
            //for (int i=0; i < result.Count; i++)
            //{
            //    Console.Write($"{result[i]} ");
            //}
            #endregion
            #region q6
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            //removeOdd(arrayList);
            //Console.WriteLine("After removing odd numbers :");
            //for (int i = 0; i < arrayList.Count; i++) { 
            //    Console.Write($"{arrayList[i]} ");
            //}
            #endregion
            #region q7
            //Queue<object> queue = new Queue<object>();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //Console.WriteLine("\nDEQUEUING ELEMENTS NOW :");
            //while (queue.Count > 0) {
            //    Console.WriteLine(queue.Dequeue());
            //}
            #endregion
            #region q8
            //Stack<int> stack = new Stack<int>();
            //stack.Push(0);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //Console.Write("Enter the target number : ");
            //int x = int.Parse(Console.ReadLine() ?? "0");
            //countUntillTarget(stack, x);
            #endregion
            #region q9
            //Console.Write("Enter size of first array: ");
            //int N = int.Parse(Console.ReadLine()??"0");
            //Console.Write("Enter size of second array: ");
            //int M = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("Enter elements of first array:");
            //int[] arr1 = new int[N];
            //for (int i = 0; i < N; i++)
            //    arr1[i] = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("Enter elements of second array:");
            //int[] arr2 = new int[M];
            //for (int i = 0; i < M; i++)
            //    arr2[i] = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine("\nThe intersection points are : ");
            //List<int> intersection = ArrayIntersection(arr1, arr2);
            //for (int i = 0; i < intersection.Count; i++) {
            //    Console.Write($"{intersection[i]} ");
            //}
            #endregion
            #region q10
            ArrayList list = new ArrayList { 1, 2, 3, 7, 5 };
            int targetSum = 12;

            ArrayList result = FindSublistWithSum(list, targetSum);

            if (result != null)
            {
                Console.WriteLine("Sublist found: [");
                foreach (int item in result)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine("]");

            }
            else
            {
                Console.WriteLine("No sublist found.");
            }
            #endregion
            #region q11
            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int k = 3;
            //Queue<int> result = ReverseFirstKElements(queue, k);
            //Console.WriteLine("AFTER DEQUEUING: ");
            //while (result.Count > 0) {
            //    Console.WriteLine(result.Dequeue());
            //}

            #endregion


        }
    }
}
