// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D.


// 15. Дано число. Проверить кратно ли оно 7 и 23
void Number(int a)
{
    if (a%7 ==0 && a%23 ==0)
    Console.WriteLine("Число кратно 7 и 23");
    else Console.WriteLine("Число не кратно 7 и 23");
}
Console.Write("Задание 15: ");
Number(161);

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным


void DayOfWeek(int a)
{
    if (a>5 && a<8)
    Console.WriteLine("Выходной");
    else Console.WriteLine("Будний день");
}
Console.Write("Задание 16: ");
DayOfWeek(5);

// 17. По двум заданным числам проверять является ли одно квадратом другого


void IsSquare(int a, int b)
{
    if (a<b)
    {
    if (a*a == b)
    Console.WriteLine($"{b} - это {a} в квадрате.");
    else Console.WriteLine($"{b} - не равняется {a} в квадрате.");
    }
    if(a>b)
    {
    if (b*b == a)
    Console.WriteLine($"{a} - это {b} в квадрате.");
    else Console.WriteLine($"{a} - не равняется {b} в квадрате.");
    }
}
Console.Write("Задание 17: ");
IsSquare(81,8);

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// bool IsTrue(bool x, bool y)
// {   
//     bool a = !(x|y);
//         if (a == !x & !y)
//         return true;
//         else return false;
// }

bool IsTrue(bool x, bool y)
{   
    bool a = !(x|y);
    bool b = !x && !y;
        if (a == b)
        return true;
        else return false;
}
Console.Write("Задание 18: ");
bool res = IsTrue(false, true);
Console.WriteLine(res);
res = IsTrue(false, false);
Console.WriteLine(res);
res = IsTrue(true, true);
Console.WriteLine(res);
res = IsTrue(true, false);
Console.WriteLine(res);

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Point(int x, int y)
{
    int a = 0;
    if (x>0 && y>0) a = 1;
    if (x>0 && y<0) a = 2;
    if (x<0 && y<0) a = 3;
    if (x<0 && y>0) a = 4;
    return a;
}
int result = Point(-5,-4);
Console.Write("Задание 19: ");
Console.WriteLine(result);

// 20. Задать номер четверти, показать диапазоны для возможных координат

void Coordinats(int a)
{
    if (a == 1) Console.WriteLine("нет решения");
    
    
}

Console.Write("Задание 20: ");
Coordinats(1);

// 21. Программа проверяет пятизначное число на палиндромом.

bool Number5 (int a)
{
    int b = a % 10; // Единицы
    int c = (a % 100 - a % 10) / 10; // Десятки
    int d = (a % 10000 - a % 1000) / 1000; // Тысячи
    int e = (a % 100000 - a % 10000) / 10000; // Десятки тысяч
    if (b == e && c == d)
    return true;
    else return false;
}
Console.Write("Задание 21: ");
bool r = Number5 (34543);
Console.WriteLine(r);


// 22. Найти расстояние между точками в пространстве 2D/3D.

Console.Write("Задание 21: ");

Console.Write("нет решения");
