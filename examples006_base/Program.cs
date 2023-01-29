int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

// Если значение больше а, то выводит соответсвующее максимальное число

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

//Выводит подсказку на экран для пользователя вводившего значение, (т.е. max = число)
Console.Write("max = ");
// Вывод на экране значение нашего максимального числа
Console.WriteLine(max);