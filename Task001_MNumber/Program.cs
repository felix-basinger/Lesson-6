//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 int CountOfNums(string arg)
{
    int num;
    System.Console.Write($"Enter {arg}: ");
    while(!int.TryParse(Console.ReadLine(), out num) || num < 1)
    {
        System.Console.WriteLine("It's not a number or incorrect data!");
        System.Console.Write($"Enter {arg}: ");
    }
    return num;
}

int[] CreateNums(int length)
{
    int count = 0;
    int [] nums = new int [length];
    for (int i = 0; i < nums.Length; i++)
    {   
        count++;
        System.Console.Write($"Enter the {count} number: ");
        while(!int.TryParse(Console.ReadLine(), out nums[i]))
        {
            System.Console.WriteLine("It's not a number!");
            System.Console.Write($"Enter the {count} number: ");
        }
    }
    return nums;
}

void PrintNums(int[] nums)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        System.Console.Write(nums[i] + ", ");
    }
    System.Console.WriteLine(nums[nums.Length - 1] + " ");
}

int AboveZero(int [] nums)
{   
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] > 0) count++;
    }
    return count;
}

int length = CountOfNums("count of numbers");
int [] numb = CreateNums(length);
System.Console.Write("Your numbers is ");
PrintNums(numb);
System.Console.WriteLine($"Count of numbers, which above zero: {AboveZero(numb)}"); 
 


