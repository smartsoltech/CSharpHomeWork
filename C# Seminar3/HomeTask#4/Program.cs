System.Console.WriteLine("Введите Трех-значное число > ");
string promt = System.Console.ReadLine();
int value = int.Parse(promt);
System.Console.WriteLine($"   Вы ввели: {value}");
int tmp_value = value / 10;
System.Console.WriteLine($" Вторая цифра - {tmp_value%10},");