// Task 1
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[n];

// for(int i = 0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 1;
// int max = 1;

// for(int i=0; i<n; i++)
// {
//     if (arr[i] == arr[i - 1])
//     {
//         cnt++;
//     }
//     else
//     {
//         cnt = 1;
//     }
//     if (cnt > max)
//     {
//         max=cnt;
//     }
// }
// System.Console.WriteLine(max);


// Task 2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i=0; i<n; i++){
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// bool palindrome = true;

// for(int i=0; i<n/2; i++)
// {
//     if (arr[i] != arr[n - 1 - i])
//     {
//         palindrome = false;
//         break;
//     }
// }
// if (palindrome)
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
//     System.Console.WriteLine("No");
// }





// Task 5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for(int i=0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int max = arr[0];

// for(int i = 0; i<n; i++)
// {
//     if(arr[i]>max)
//     max=arr[i];
// }
// System.Console.WriteLine(max);



// Task 6
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DigitRecurs(n));

// int SumDigit(int n)
// {
//     if(n == 0)
//     {
//         return 0;
//     }
//     return n%10+SumDigit(n/10);
// }

// int DigitRecurs(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     return DigitRecurs(SumDigit(n));
// }



// Task 7
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// multiply(ref a, ref b);

// void multiply(ref int a, ref int b)
// {
//     a = a * 2;
//     b = b * 2;
// }
// System.Console.WriteLine("a = "+a);
// System.Console.WriteLine("b = "+b);


// Task 8
// int CountEvenNumbers(int[] arr)
// {
//     int count = 0;

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//             count++;
//     }

//     return count;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine(CountEvenNumbers(arr));



// Task 9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// int sum = 0;

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
//     sum += arr[i];
// }

// double average = (double)sum / n;

// int count = 0;

// for (int i = 0; i < n; i++)
// {
//     if (arr[i] > average)
//         count++;
// }

// Console.WriteLine(count);


// Task 10
// void PrintNumbers(int n)
// {
//     if (n < 1)
//         return;

//     Console.Write(n + " ");

//     PrintNumbers(n - 1);
// }

// int num = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(num);



//task3
string text = Console.ReadLine() ?? "";

int vowels = 0;
int consonants = 0;

for (int i = 0; i < text.Length; i++)
{
    char c = text[i];

    if (char.IsLetter(c))
    {
        char lower = char.ToLower(c);

        if (lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u')
        {
            vowels++;
        }
        else
        {
            consonants++;
        }
    }
}

Console.WriteLine("Vowels: " + vowels);
Console.WriteLine("Consonants: " + consonants);