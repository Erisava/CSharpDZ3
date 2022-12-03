// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.Write("Найдем расстояние кооринат в 3D пространстве. ");

Console.Write("Введите X координату точки A: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X координату точки B: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B: ");                                                         // 2 знака после запятой
int Z2 = Convert.ToInt32(Console.ReadLine());                                                            // |
double length = Math.Round((Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2))),2); //sqrt - квадратный корень
Console.WriteLine("Координа точек A и B равна: " + length);

// Метод Math.round () возвращает число, округлённое к ближайшему целому

// Math.Sqrt() – математическая функция которая извлекает квадратный корень.
// В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень.

// Math.Pow() – возведения числа в степень.
// В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень,
// 2-ой – степень, в которую возводим число).