int value = new Random().Next(99, 999);
System.Console.WriteLine(value);
int f_tmp_value = value / 100;
int s_tmp_value = value / 100;
System.Console.WriteLine($"Первая Цифра - {value/100}, Последняя цифра - {value%10}, Сгенерированое трех-значное число без средней цифры - {value/100}{value%10}");