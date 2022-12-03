// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine()); //Введение целого числа: Convert.ToInt32
if(num>9999 && num<=99999) //Если соблюдается условие, когда число в диапозоне от 9999 до 99999 включительно
{
  Console.WriteLine("Является ли это число полиндромом?");
  int numReverse = 0;
  int numCopy = num;
  while (num > 0) //Пока число больше 0
  {
    numReverse = numReverse * 10 + (num %10);
    num = num / 10;
  };
  if (numReverse == numCopy) Console.WriteLine("Да"); //Если условие соблюдается
  else Console.WriteLine("Нет"); //Иначе
} 
else //Иначе
{
  Console.Write("Неправильный диапозон");
};