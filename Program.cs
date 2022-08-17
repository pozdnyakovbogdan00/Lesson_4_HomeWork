int Answer = Program_Main_InputData();

switch (Answer)
{
    case 1: ExpansionExponentiation.ExpansionExponentiationMain(); break;  
    case 2: ExpansionSummDigits.ExpansionSummDigitsMain(); break;
    case 3: ExpansionCreateArray.ExpansionCreateArrayMain(); break;
    case 4: ExpansionZeroOneNArray.ExpansionZeroOneNArrayMain(); break;
    case 5: BinaryToDecimalNumbersSystems.BinaryToDecimalNumbersSystemsMain(); break;
    case 6: DecimalNumbersTranslater.DecimalNumbersTranslaterMain(); break;
    default: Console.WriteLine("You have entered an invalid value (Enter 1 - 6)."); break;
}

// START Procedures and functions

static int Program_Main_InputData()
{
    Console.WriteLine("Choose one of the suggested values: ");
    Console.WriteLine("1: Задача 25. Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
    Console.WriteLine("2: Задача 27. Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе");
    Console.WriteLine("3: Задача 29: Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.");
    Console.WriteLine("4: Написать метод, который генерирует массив 0 и 1 заданного количества N.");
    Console.WriteLine("5: Написать метод, принимающий бинарное представление числа и возвращающее десятиченое представление числа");
    Console.WriteLine("6: Написать метод, принимающий десятиченое представление и основание СС в которую нужно это число перевести, 2<= основание СС<= 9");
    Console.WriteLine("Your choice? ");
    int InputData = Convert.ToInt32(Console.ReadLine());
    
    return InputData; 
}

// END Procedures and functions