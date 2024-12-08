

//************************Part 1***********

#region Problem01 1D Array
//int[] nums1 = new int[4] { 1, 2, 3, 4 };
//Console.WriteLine("----------First Array-----------");
//foreach (int item in nums1)
//{
//	Console.Write(item + " ");
//}

//////List  => Dynamic
//List<int> nums2 = new List<int> { 5, 6, 7 };
//Console.WriteLine("\n----------second Array-----------");
//foreach (int item in nums2)
//{
//	Console.Write(item + " ");
//}

//// Syntax suger
//int[] nums3 = { 7, 8, 9 };
//Console.WriteLine("\n----------Third Array-----------");
//foreach (int item in nums3)
//{
//	Console.Write(item + " ");
//}
//Console.WriteLine(); 
#endregion
#region Problem02 (shallow & Deep Copy)
// shalow copy
using System.Security.Cryptography;

int[] arr01 = new int[] { 1, 2, 3 };
int[] arr02 = new int[] { 7, 8, 9 };

//arr02 = arr01;
//arr02[0] = 30;
//Console.WriteLine(arr02[0]); //30
//Console.WriteLine(arr01[0]);// 30

//Deep copy 
//Console.WriteLine(arr01.GetHashCode());
//Console.WriteLine(arr02.GetHashCode());
//arr02 = (int[])arr01.Clone();
//Console.WriteLine(arr01.GetHashCode());
//Console.WriteLine(arr02.GetHashCode());
//arr02[0] = 40;
//Console.WriteLine(arr01[0]); //1
//Console.WriteLine(arr02[0]);// 40
//arr01[0] = 50;
//Console.WriteLine(arr01[0]);//50
//Console.WriteLine(arr02[0]);//40 
#endregion

#region problem03 2D array
//int[,] Student_grade = new int[3, 3];
//Console.WriteLine($"Student_grade.Length: {Student_grade.Length}");
//Console.WriteLine($"Student_grade.GetLength(0):{Student_grade.GetLength(0)}");
//Console.WriteLine($"Student_grade.GetLength(1):{Student_grade.GetLength(1)}");

////Input Grades for each student
//for (int i = 0; i < Student_grade.GetLength(0); i++)
//{
//	Console.WriteLine($"\tEnter grade of Student=> {i + 1} : ");

//	for (int j = 0; j < Student_grade.GetLength(1); j++)
//	{
//		Console.Write($"Grade of subject {j + 1}: ");
//		int grade = int.Parse(Console.ReadLine());
//		Student_grade[i, j] = grade;
//	}
//}
////Display Grades for each student
//Console.WriteLine("\n\tDisplay Grades ");
//for (int i = 0; i < Student_grade.GetLength(0); i++)
//{
//	Console.WriteLine($"\t Grades of Student=> {i + 1} : ");

//	for (int j = 0; j < Student_grade.GetLength(1); j++)
//	{
//		Console.WriteLine($"Subject {j + 1}: {Student_grade[i, j]}");

//	}
//}
#endregion

#region Problem04 Array Functions
//int[] Source = new int[] { 5, 4, 1, 2, 3 };
//int[] Destenation = new int[3];

////Sort
//Array.Sort(Source); //1 2 3 4 5
//					//Copy
//					//Array.Copy(Source, Destenation, 3); //1 2 3					

////ConstrainedCopy
//Array.ConstrainedCopy(Source, 1, Destenation, 0, 2);// 2 3 0

//// Reverse
//Array.Reverse(Destenation);//3 2 1

//// Cleare 
////Array.Clear(Source); // 0 0 0 0
////
//int index = Array.IndexOf(Source, 2);
//Console.WriteLine($"index: {index}\t");// 1

#endregion

#region Problem05 Loops

//int[] arr = new int[] { 1, 2, 3, 4, 5 };
////for
//Console.WriteLine("print using For: ");
//for (int i = 0; i < arr.Length; i++)
//{
//	Console.Write($"{arr[i]} ");
//}
//Console.WriteLine();
////foreach
//Console.WriteLine("print using Foreach: ");
//foreach (var item in arr)
//{
//	Console.Write(item + " ");
//}
//Console.WriteLine();

//int len = arr.Length - 1;
//// while
//Console.WriteLine("print using reverse while: ");
//while (len >= 0)
//{
//	Console.Write(arr[len] + " ");
//	len--;
//} 
#endregion

#region Prolem06 Enven numbers
//int num;
//do
//{
//	Console.WriteLine("Enter Even number: ");
//	bool flag = int.TryParse(Console.ReadLine(), out num);
//}
//while (num % 2 == 0&&flag); 
#endregion

#region Problem07 Formatting Fixd Array
//int[,] arr = new int[3, 3]
//	{
//		{ 1,2,3},
//		{4,5,6},
//		{ 7,8,9}
//	};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//	for (int j = 0; j < arr.GetLength(1); j++)
//	{
//		Console.Write(arr[i, j] + " ");
//	}
//	Console.WriteLine();
//}


#endregion

#region problem08 Conditions
//Console.Write("Enter Number of Mounth: ");
//int numOfMounth = int.Parse(Console.ReadLine());

//string monthName = "Invalid Number";
//if (numOfMounth == 1) monthName = "January";
//else if (numOfMounth == 2)
//	monthName = "February";
//else if (numOfMounth == 3)
//	monthName = "March";
//else if (numOfMounth == 4)
//	monthName = "April";
//else if (numOfMounth == 5)
//	monthName = "May";
//else if (numOfMounth == 6)
//	monthName = "June";
//else if (numOfMounth == 7)
//	monthName = "July";
//else if (numOfMounth == 8)
//	monthName = "August";
//else if (numOfMounth == 9)
//	monthName = "September";
//else if (numOfMounth == 10)
//	monthName = "October";
//else if (numOfMounth == 11)
//	monthName = "November";
//else if (numOfMounth == 12)
//	monthName = "December";
//Console.WriteLine(monthName); 
#endregion

#region Problem09 LastIndexOf VS IndexOf 
//int[] arr = new int[] { 5, 8, 6, 8, 2, 3, 1 };


//int index = Array.IndexOf(arr, 8);//1
//Console.WriteLine(index);
//int lastindex = Array.LastIndexOf(arr, 8);//3
//Console.WriteLine(lastindex);
//Array.Sort(arr); 
#endregion

#region problem10 Summation
//int[] arr = new int[] { 5, 8, 6, 8, 2, 3, 1 };

//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//	sum += arr[i];
//}
//Console.WriteLine($"Sum= {sum}");
//int sum2 = 0;
//foreach (var item in arr)
//{
//	sum2 += item;
//}
//Console.WriteLine($"Sum2= {sum2}");

#endregion
#region Problem11 Enum
//Console.WriteLine("Enter number between range of 1 to 7");
//int dayNum;
//bool flag = int.TryParse(Console.ReadLine(), out dayNum);
//string dayName = ((DaysOfWeek)dayNum + 1).ToString();
//Console.WriteLine(dayName);
//enum DaysOfWeek
//{
//	Sunday,     // 0
//	Monday,     // 1
//	Tuesday,    // 2
//	Wednesday,  // 3
//	Thursday,   // 4
//	Friday,     // 5
//	Saturday    // 6
//} 
#endregion


