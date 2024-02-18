//дз 5.1
//const double MM_TO_CM = 0.1;
//const double MM_TO_M = 0.0001;
//const double MM_TO_KM = 0.000001;
//const double MM_TO_MILI = 6.213711922373341e-7;
//const double MM_TO_YD = 0.0010936132983;


//Console.WriteLine("Введите колличество мм: ");
//double mm = double.Parse(Console.ReadLine());
//double cm = mm * MM_TO_CM;
//Console.WriteLine($"{cm}см");


//double m = mm * MM_TO_M;
//Console.WriteLine($"{m}м");


//double km = mm * MM_TO_KM;
//Console.WriteLine($"{km}км");


//double mili = mm * MM_TO_MILI;
//Console.WriteLine($"{mili}мили");


//double yd = mm * MM_TO_YD;
//Console.WriteLine($"{yd}ярд");


// дз 5.2
// Первый продукт "кофе стандарт" цена 69,0 ; колличество 1

//Console.WriteLine("Укажите продукт: ");
//string firstProductName = Console.ReadLine();
//Console.WriteLine($"Укажите цену {firstProductName}: ");
//decimal firstProductPrice = decimal.Parse(Console.ReadLine());
//Console.WriteLine($"Укажите колличество продукта {firstProductName} , по цене {firstProductPrice}: ");
//int firstProductQuantity = int.Parse(Console.ReadLine());
//decimal sum = firstProductPrice * firstProductQuantity;

////// Второй продукт "рулет-спринг тв из ку" цена 70,0 ; колличество 1

//Console.WriteLine("Укажите продукт: ");
//string secondProductName = Console.ReadLine();
//Console.WriteLine($"Укажите цену {secondProductName}: ");
//decimal secondProductPrice = decimal.Parse(Console.ReadLine());
//Console.WriteLine($"Укажите колличество продукта {secondProductName} , по цене {secondProductPrice}: ");
//int secondProductQuantity = int.Parse(Console.ReadLine());
//decimal sum2 = secondProductPrice * secondProductQuantity;

//Console.WriteLine("*********************************************************");
//Console.WriteLine("№ Название\t\t\tЦена\tКолличество\tСумма");
//Console.WriteLine($"№1 {firstProductName}\t\t{firstProductPrice}\t{firstProductQuantity}\t\t{sum}");
//Console.WriteLine("НДС с расчитаной ставкой 18%\t\t\t\t10.53");
//Console.WriteLine($"№2 {secondProductName}\t{secondProductPrice}\t{secondProductQuantity}\t\t{sum2}");
//Console.WriteLine("НДС с расчитаной ставкой 10%\t\t\t\t6.36");
//Console.WriteLine("*********************************************************");
//Console.WriteLine($"Итого: {sum + sum2}");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine($"Электронные средства:\t\t\t\t{sum + sum2}");
//Console.WriteLine("НДС итога чека с расчитаной ставкой\n18%\t10.53");
//Console.WriteLine("НДС итога чека с расчитаной ставкой\n10%\t6.36");
//Console.WriteLine(" ");
//Console.WriteLine(" ");
//Console.WriteLine("*********************************************************");
//Console.WriteLine("ВИД НАЛОГООБЛАЖЕНИЯ: ОСН");
//Console.WriteLine("РЕГ. НОМЕР ККТ: 0000143873023483");
//Console.WriteLine("ЗАВОД. №:");
//Console.WriteLine("ФН. №: 8710000100265168");
//Console.WriteLine("ФД. №: 6026");
//Console.WriteLine("ФПД: 3322278314");

//дз 6.1
//string myString = "28";
//Console.WriteLine(myString);
//byte myByte = byte.Parse(myString);
//Console.WriteLine(myByte);
//nint myNint = nint.Parse(myString);
//Console.WriteLine(myNint);
//int myInt = int.Parse(myString);
//Console.WriteLine(myInt);
//long myLong = long.Parse(myString);
//Console.WriteLine(myLong);
//double myDouble = double.Parse(myString);
//Console.WriteLine(myDouble);

// дз 6.2
//string firstString = "512";
//int number = int.Parse(firstString);
//Console.WriteLine(number.GetType());
//string secondString = number.ToString();
//Console.WriteLine(secondString.GetType());
//Console.WriteLine(secondString);

//string a = "100";
//int b = int.Parse(a);
//Console.WriteLine(b.GetType());
//string c = b.ToString();
//Console.WriteLine(c.GetType());
//Console.WriteLine(c);

//7.1-2
//1
//double PI = 3.14;
//Console.WriteLine("Введите радиус окружности: ");
//double radius = double.Parse(Console.ReadLine());
//Console.WriteLine("Площадь круга равна: ");
//Console.WriteLine(PI * radius * radius);
//2
//Console.WriteLine("Введите ваше имя: ");
//string name = Console.ReadLine();
//Console.WriteLine("Введите вашу фамилию: ");
//string surname = Console.ReadLine();
//Console.WriteLine("Введите ваше отчество: ");
//string familyName = Console.ReadLine();
//Console.WriteLine("Укажите место работы: ");
//string job = Console.ReadLine();
//Console.WriteLine("Семейное положение: ");
//string familyStatus = Console.ReadLine();
//Console.WriteLine("Есть ли у вас дети: ");
//string children = Console.ReadLine();
//Console.WriteLine($"{name}\n{surname}\n{familyName}\n{job}\n{familyStatus}\n{children}");

////9.2
////1
//long a = 264895468854;
//Console.WriteLine(a + "=" + Convert.ToString(a, 2));
//Console.WriteLine(~a + "=" + Convert.ToString(~a, 2));
//long b = 256;
//Console.WriteLine(b + "=" + Convert.ToString(b, 2));
//Console.WriteLine(~b + "=" + Convert.ToString(~b, 2));
////2
//int c = 256;
//c >>= 1;
//Console.WriteLine(c);
//c <<= 1;
//Console.WriteLine(c);
////3
//int d = 289;
//d += 2487;
//Console.WriteLine(d);
//d *= 2487;
//Console.WriteLine(d);
//d -= 2487;
//Console.WriteLine(d);
//d /= 2487;
//Console.WriteLine(d);
//d %= 2487;
//Console.WriteLine(d);
//d >>= 2487;
//Console.WriteLine(d);
//d <<= 2487;
//Console.WriteLine(d);

//int g = 144;
//g += 2487;
//Console.WriteLine(g);
//g *= 2487;
//Console.WriteLine(g);
//g -= 2487;
//Console.WriteLine(g);
//g /= 2487;
//Console.WriteLine(g);
//g %= 2487;
//Console.WriteLine(g);
//g >>= 2487;
//Console.WriteLine(g);
//g <<= 2487;
//Console.WriteLine(g);

//int e = 36274;
//e += 2487;
//Console.WriteLine(e);
//e *= 2487;
//Console.WriteLine(e);
//e -= 2487;
//Console.WriteLine(e);
//e /= 2487;
//Console.WriteLine(e);
//e %= 2487;
//Console.WriteLine(e);
//e >>= 2487;
//Console.WriteLine(e);
//e <<= 2487;
//Console.WriteLine(e);

// дз 10.1

//Console.Write("Введите радиус:");
//double R = double.Parse(Console.ReadLine());
//double S = Math.PI * R * R;
//double L = 2 * Math.PI * R;
//Console.WriteLine($"Площадь окружности = {S:F2}");
//Console.WriteLine($"Длинна окружности = {L:F2}");

// дз 10.2

//Console.Write("Введите катет А: ");
//double A = double.Parse(Console.ReadLine());
//Console.Write("Введите гипотенузу C: ");
//double C = double.Parse(Console.ReadLine());
//double B = Math.Sqrt(C * C - A * A);
//Console.WriteLine($"Значение второго катета = {B:F2}");

// дз 11.1

//Console.WriteLine("Введите первое чисело: ");
//int one = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе чисело: ");
//int two = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите третье чисело: ");
//int three = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите четвертое чисело: ");
//int four = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите пятое чисело: ");
//int five = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите шестое чисело: ");
//int six = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите седьмое чисело: ");
//int seven = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите восьмое чисело: ");
//int eight = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите девятое чисело: ");
//int nine = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите десятое чисело: ");
//int ten = int.Parse(Console.ReadLine());
//Console.WriteLine(" ");
//int sum = one + two + three + four + five + six + seven + eight + nine + ten;
//Console.WriteLine($"Сумма введеных вами чисел = {sum}");
//Console.WriteLine(" ");
//Console.WriteLine((one > 10) ? one : (one < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((two > 10) ? two : (two < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((three > 10) ? three : (three < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((four > 10) ? four : (four < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((five > 10) ? five : (five < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((six > 10) ? six : (six < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((seven > 10) ? seven : (seven < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((eight > 10) ? eight : (eight < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((nine > 10) ? nine : (nine < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine((ten > 10) ? ten : (ten < 10) ? "Меньше 10" : "Равно");
//Console.WriteLine(" ");
//Console.WriteLine((one > -10) ? "Больше -10" : (one < -10) ? one : "Равно");
//Console.WriteLine((two > -10) ? "Больше -10" : (two < -10) ? two : "Равно");
//Console.WriteLine((three > -10) ? "Больше -10" : (three < -10) ? three : "Равно");
//Console.WriteLine((four > -10) ? "Больше -10" : (four < -10) ? four : "Равно");
//Console.WriteLine((five > -10) ? "Больше -10" : (five < -10) ? five : "Равно");
//Console.WriteLine((six > -10) ? "Больше -10" : (six < -10) ? six : "Равно");
//Console.WriteLine((seven > -10) ? "Больше -10" : (seven < -10) ? seven : "Равно");
//Console.WriteLine((eight > -10) ? "Больше -10" : (eight < -10) ? eight : "Равно");
//Console.WriteLine((nine > -10) ? "Больше -10" : (nine < -10) ? nine : "Равно");
//Console.WriteLine((ten > -10) ? "Больше -10" : (ten < -10) ? ten : "Равно");
//Console.WriteLine(" ");

//int max = Math.Max();
//доделать

//11.2

//Console.WriteLine("Введите температуру на улице: ");
//double T = double.Parse(Console.ReadLine());
//if (T < 35 && T > 20) Console.WriteLine("На улицу выходят гулять: Слоны,Жирафы,Львы.");
//else if (T > -35 && T < 20) Console.WriteLine("На улицу выходят гулять: Медведи,Волки,Пингвины.");
//else if (T == 20) Console.WriteLine("На улицу выходят гулять: Кенгуру.");
//else Console.WriteLine("Такой температуры не существует");

//11.3
//1
//Random random = new Random();
//Console.WriteLine("Введите и угадайте число от 0 до 5 загаданое компьютером:");
//int userNumber = int.Parse(Console.ReadLine());
//int number = random.Next(0, 6);
//Console.WriteLine(number);
//if (userNumber == number) Console.WriteLine("Победа!");
//else Console.WriteLine("Вы не угадали");
////2
//Console.Write("Введите номер месяца:");
//byte n = byte.Parse(Console.ReadLine());
//Console.Write("Введите температуру:");
//double t = double.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//    case 2:
//    case 12:
//        {
//            if (t > 0) Console.WriteLine("Дождьливая зима");
//            Console.WriteLine("Зима"); break;
//        }
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Такого месяца нет"); break;
//}

//11.4

//Console.WriteLine("Введите ваш возраст: ");
//int age = int.Parse(Console.ReadLine());
//if (age < 18) Console.WriteLine("Вы слишком молоды для участия в выборах");
//else if (age >= 18 && age <= 35) Console.WriteLine("Вы можете участвовать в выборах в качестве депутата");
//else if (age >= 36 && age <= 65) Console.WriteLine("Вы можете участвовать в выборах в качестве кандидата в президенты");
//else Console.WriteLine("Ваш возраст слишком велик для участия в выборах");
//Console.WriteLine("За кого отдадите свой голос?\n" + "1-Незнайка\n" + "2-Лунтик\n" + "3-Карлсон\n" + "4-Дядя Фёдор\n");
//int number = int.Parse(Console.ReadLine());
//switch (number)
//{
//    case 1: Console.WriteLine("Незнайка - А у тебя в животе арбуз вырастет!!!"); break;
//    case 2: Console.WriteLine("Лунтик - Да, я хочу летать! Я хочу, править миром!"); break;
//    case 3: Console.WriteLine("Карлсон - Спокойствие, только спокойствие!"); break;
//    case 4: Console.WriteLine("Дядя Фёдор - Чтобы продать что-нибудь не нужное, надо купить что-нибудь не нужное, а унас денег нет!"); break;
//    default: Console.WriteLine("Такого кандидата нет!"); break;
//}

