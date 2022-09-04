void WeekDay(int daynumber)
{
    switch (daynumber)
    {
        case < 1:
        case > 7:
            Console.WriteLine($"К сожалению, {daynumber}; не существует в природе.");
            break;
        case 1: 
            Console.WriteLine($" {daynumber}. -ый день недели - Это поденельник. Работаем");
            break;
        case 2:
            Console.WriteLine($" {daynumber}. -ый день недели - Это Вторник. Работаем");
            break;
        case 3:
            Console.WriteLine($" {daynumber}. -ий день недели - Это Среда. Работаем");
            break;
        case 4:
            Console.WriteLine($" {daynumber}. -ый день недели - Это Четверг. Работаем");
            break;
        case 5: 
            Console.WriteLine($" {daynumber}. -ый день недели - Это Пятница. Работаем");
            break;
        case 6:
            Console.WriteLine($" {daynumber}. -ой день недели - Это Суббота. ВЫХОДНОЙ!!!!");
            break;
        case 7: 
            Console.WriteLine($" {daynumber}. -ой день недели - Это ВОСКРЕСЕНЬЕ. ВЫХОДНОЙ!!!!");
            break;        
        default:
            Console.WriteLine($"Measured value is {daynumber}.");
            break;
    }
}
System.Console.Write("Введите номер дня недели> ");
int daynum = int.Parse(Console.ReadLine() ?? "0");
WeekDay(daynum); 	