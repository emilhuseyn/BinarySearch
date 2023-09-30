Console.WriteLine("Welcome the find to searching number with Binary Search Alghoritm");
Console.Write("Please enter the array lenght:");
int len=Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the numbers:");
int[] arr=new int[len];
for(int i=0; i<len; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int left = 0, right = arr.Length - 1, mid;
bool found = false;
Console.WriteLine("Please enter the number:");
int target = Convert.ToInt32(Console.ReadLine()); 

while (left <= right)
{
    mid = (left + right) / 2;

    if (arr[mid] == target)
    {
        Console.WriteLine("The index is " + mid);
        found = true;
        break;
    }
    else if (arr[mid] < target)
    {
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }
}

if (!found)
{
    Console.WriteLine("Number was not found");
}
