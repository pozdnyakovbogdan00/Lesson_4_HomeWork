
/////////////////////////   Common methods   /////////////////////////
class ExpansionCommonMethod
{
    public static string[] DataInput(string[] OffersToInPut)
    {
        int DataRequired = OffersToInPut.Length;
        string[] InputTextArr = new string[DataRequired];

        int i = 0;
        while (i < DataRequired)
        {
            Console.WriteLine(OffersToInPut[i]);
            InputTextArr[i] = Console.ReadLine();
            i++;
        }

        return InputTextArr;
    }
    public static void OutPutData(string OutPutText)
    {
        Console.WriteLine(OutPutText);
    }
}
///////////////////////// END Common methods /////////////////////////

/////////////////////////     Exercise 25    /////////////////////////
class ExpansionExponentiation
{
    // Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // нельзя использовать pow

    // Exercise 25 
    public static void ExpansionExponentiationMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter the value A", "Enter the value B" });
        int result = ExpansionExponentiationCalculateSqrt(Convert.ToInt32(ReceivedData[0]), Convert.ToInt32(ReceivedData[1]));
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static int ExpansionExponentiationCalculateSqrt(int A, int B)
    {
        int result = 1;
        if (B == 0)
        {
            result = 1;
        }
        else
        {
            for (int i = 1; i <= B; i++)
            {
                result = result * A;
            }
        }


        return result;
    }
}
/////////////////////////   END Exercise 25  /////////////////////////

/////////////////////////     Exercise 27    /////////////////////////
class ExpansionSummDigits
{
    // Задача 27: Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.

    // Exercise 27 
    public static void ExpansionSummDigitsMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter your number" });
        int result = ExpansionSummFindSummDigits(Convert.ToInt32(ReceivedData[0]));
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static int ExpansionSummFindSummDigits(int A)
    {
        int result = 0;
        int NewValueNumber = A;
        while (NewValueNumber != 0)
        {
            result = result + (NewValueNumber % 10);
            NewValueNumber = NewValueNumber / 10;
        }

        return result;
    }
}
/////////////////////////   END Exercise 27  /////////////////////////

/////////////////////////     Exercise 29    /////////////////////////
class ExpansionCreateArray
{
    // Задача 29: Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
    //пример вывода

    // Exercise 29 
    public static void ExpansionCreateArrayMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter the dimension of the array" });
        string result = ExpansionCreateArrayNewArray(Convert.ToInt32(ReceivedData[0]));
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static string ExpansionCreateArrayNewArray(int LengthArray)
    {
        int[] NewArray = new int[LengthArray];

        for (int i = 0; i < LengthArray; i++)
        {
            Random rand = new Random();
            NewArray[i] = rand.Next(1, 100);
        }

        string result = "[";
        foreach (var item in NewArray)
        {
            result = result + item + ";";
        }

        result = result + "]";

        return result;
    }
}
/////////////////////////   END Exercise 29  /////////////////////////

/////////////////////////  Exercise 1 (HARD) /////////////////////////
class ExpansionZeroOneNArray
{
    // Написать метод, который генерирует массив 0 и 1 заданного количества N

    // Exercise 1 (HARD)
    public static void ExpansionZeroOneNArrayMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter the length array (N)" });
        string result = ExpansionZeroOneNArrayNewNArray(Convert.ToInt32(ReceivedData[0]));
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static string ExpansionZeroOneNArrayNewNArray(int LengthArray)
    {
        int[] NewArray = new int[LengthArray];

        for (int i = 0; i < LengthArray; i++)
        {
            Random rand = new Random();
            NewArray[i] = Convert.ToInt32((float)rand.NextDouble());
        }

        string result = "[";
        foreach (var item in NewArray)
        {
            result = result + item + ";";
        }

        result = result + "]";

        return result;
    }
}
//////////////////////// END Exercise 1 (HARD)////////////////////////

/////////////////////////  Exercise 2 (HARD) /////////////////////////
class BinaryToDecimalNumbersSystems
{
    // Написать метод, принимающий бинарное представление числа
    // и возвращающее десятиченое представление числа

    // Exercise 2 (HARD)
    public static void BinaryToDecimalNumbersSystemsMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter the your number in binary number system" });
        int result = BinaryToDecimalNumbersSystemsTranslateData(ReceivedData[0]);
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static int BinaryToDecimalNumbersSystemsTranslateData(string BinaryNumber)
    {

        int result = 0;
        char[] ArrayBinaryNumbers = BinaryNumber.ToCharArray();
        int CurrentDegree = ArrayBinaryNumbers.Length - 1;
        int CurrentElement = 0;

        foreach (var item in ArrayBinaryNumbers)
        {
            CurrentElement = Convert.ToInt32(Char.GetNumericValue(item));
            if (CurrentElement == 1)
            {
                result = result + ExpansionExponentiation.ExpansionExponentiationCalculateSqrt(2, CurrentDegree);
            }
            CurrentDegree--;
        }


        return result;
    }
}
//////////////////////// END Exercise 2 (HARD)////////////////////////

/////////////////////////  Exercise 3 (HARD) /////////////////////////
class DecimalNumbersTranslater
{
    // Написать метод, принимающий десятиченое представление и 
    //основание СС в которую нужно это число перевести, 2<= основание СС<= 9
    
    // Exercise 3 (HARD)
    public static void DecimalNumbersTranslaterMain()
    {
        string[] ReceivedData = ExpansionCommonMethod.DataInput(new[] { "Enter a number ", "Enter the base " });
        string result = DecimalNumbersTranslaterData(Convert.ToInt32(ReceivedData[0]), Convert.ToInt32(ReceivedData[1]), ReceivedData[0].Length);
        ExpansionCommonMethod.OutPutData("Result: " + result);
    }

    public static string DecimalNumbersTranslaterData(int A, int B, int LengthArray)
    {

        string StringNumber = "";
        int Quotient = 0;
        int Divisible = A;
        int Divisor = B;
        int i = 0;
        string QuotientToString = "";

        while (Divisible >= B)
        {
            Quotient = Divisible % Divisor;
            if (B > 10 & Quotient >= 10)
            {
                QuotientToString = DecimalNumbersTranslaterReplaceDecimalNumbers(Quotient);      
            }
            else
            {
                QuotientToString = Convert.ToString(Quotient);
            }
            StringNumber = StringNumber + QuotientToString;
            Divisible = Convert.ToInt32(Divisible / Divisor);
            i++;
        }
        StringNumber = StringNumber + Divisible;

        char[] arr = StringNumber.ToCharArray();
        Array.Reverse(arr);
        string result = new string(arr);

        return result;
    }
    public static string DecimalNumbersTranslaterReplaceDecimalNumbers(int Number)
    {
        string result = "";

        if (Number == 10) {result = "A";}
        if (Number == 11) {result = "B";}
        if (Number == 12) {result = "C";}
        if (Number == 13) {result = "D";}
        if (Number == 14) {result = "E";}
        if (Number == 15) {result = "F";}

        return result;
    }
}
//////////////////////// END Exercise 3 (HARD)////////////////////////
