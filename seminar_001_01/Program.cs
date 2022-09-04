//Задача 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

//3 -> Среда
//5 ->  Пятница

Console.WriteLine("Введите номер дня недели");

int x = int.Parse(Console.ReadLine());

if (x > 7 || x <= 0){Console.WriteLine("неверное число");}
if (x == 1){Console.WriteLine("понедельник");}
if (x == 2){Console.WriteLine("вторник");}
if (x == 3){Console.WriteLine("среда");}
if (x == 4){Console.WriteLine("четверг");}
if (x == 5){Console.WriteLine("пятница");}
if (x == 6){Console.WriteLine("суббота");}
if (x == 7){Console.WriteLine("воскресенье");}