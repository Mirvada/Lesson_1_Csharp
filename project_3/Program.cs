//int numberA = 3;
//int numberB = 5;
//int result = numberA + numberB;
//Console.WriteLine(result);

//new Random().Next(min, max) выдает целое число. max-1

int numberA = new Random().Next(1, 10); //числа от 1-9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
Console.WriteLine(numberA / numberB);