/*

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int Cub(int numberA, int numberB)

{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  
  {
    result = result * numberA;
  }
        return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int cub = Cub(numberA, numberB);
  Console.WriteLine(cub);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

  int SumN(int N)
  
  {
    
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = N - N % 10;
      result = result + (N - advance);
      N = N / 10;
    }
   return result;
  }

int sumN = SumN(N);
Console.WriteLine(sumN);



// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

Console.Clear();

Console.Write("Введите ряд чисел через запятую: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    

string NoSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Введите цифры");

      }
}


int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];   

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();   
    }
    j++;
  }
  return arrayOfNumbers;
}


void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = NoSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);


*/
