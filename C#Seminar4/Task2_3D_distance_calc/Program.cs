// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;


int ReadCoord(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] StoreCoords()
{
    int[] temp = new int[3];
    temp[XCOORD] = ReadCoord("Введите X > ");
    temp[YCOORD] = ReadCoord("Введите Y > ");
    temp[ZCOORD] = ReadCoord("Введите Z > ");
    return temp;
}

double Calc(int[] firstCoord, int[] secondCoord)
{
    return Math.Sqrt(Math.Pow(firstCoord[XCOORD] - secondCoord[XCOORD], 2)+ Math.Pow(firstCoord[YCOORD] - secondCoord[YCOORD], 2)+(Math.Pow(firstCoord[ZCOORD]-secondCoord[ZCOORD],2)));
}

int[] firstPoint = StoreCoords();
int[] secondPoint = StoreCoords();
System.Console.WriteLine($"Длина {Calc(firstPoint,secondPoint):f4}");