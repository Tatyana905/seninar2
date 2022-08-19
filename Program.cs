// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
/*
int number = new Random().Next(10,100);  // [10,100) -> [10,99]
//Console.WriteLine(number);
int fistDigit = number / 10;
int secondDigit = number % 10;

int maximum = fistDigit;
if (secondDigit > maximum) maximum = secondDigit;

Console.WriteLine($"Mаксимальная цифра в числе {number} - это {maximum}");
*/


// Программа, к-рая выводит случайное трехзначное число и удаляет вторую 
// цифру этого числа
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);  
Console.WriteLine(number);
int fistDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine(fistDigit + "" + thirdDigit);