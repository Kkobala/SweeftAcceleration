using System.Collections.Immutable;

public class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(IsPalindrome("repaper"));
        //Console.WriteLine(MinSplit(120));
        //Console.WriteLine(NotContains(new int[] { 1,2,3,5 }));
        //Console.WriteLine(IsProperly("(()())"));
        Console.WriteLine(CountVariants(5));
    }

    //პირველი დავალება
    public static bool IsPalindrome(string str)
    {
        if (str == null)
        {
            return false;
        }

        char[] c = str.ToCharArray();
        Array.Reverse(c);

        return new string(c).Equals(str);
    }

    //მეორე დავალება
    public static int MinSplit(int amount)
    {
        int[] coins = { 50, 20, 10, 5, 1 };

        int countMin = 0;

        foreach (int coin in coins)
        {
            countMin += amount / coin;
            amount %= coin;
        }

        return countMin;
    }

    //მესამე დავალება
    public static int NotContains(int[] array)
    {
        int smallestNumber = Enumerable.Range(1, 100000).Except(array).Min();

        return smallestNumber;
    }

    //მეოთხე დავალება
    public static bool IsProperly(string sequence)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char character in sequence)
        {
            if (character == '(')
            {
                stack.Push(character);
            }
            else if (character == ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    //მეხუთე დავალება
    public static int CountVariants(int stairCount)
    {
        if (stairCount <= 0)
        {
            return 0;
        }
        else if (stairCount == 1)
        {
            return 1;
        }
        else if (stairCount == 2)
        {
            return 2;
        }
        else
        {
            int[] variants = new int[stairCount];
            variants[0] = 1;
            variants[1] = 2;

            for (int i = 2; i < stairCount; i++)
            {
                variants[i] = variants[i - 1] + variants[i - 2];
            }

            return variants[stairCount - 1];
        }
    }
}