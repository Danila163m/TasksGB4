int programm, num;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()");
    Console.WriteLine("2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. (для получения цифр числа операцию приведения числа к строке не использовать)");
    Console.WriteLine("3.  Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
            int Exponentiation(int numberA, int numberB){
            int result = 1;
            for(int i=1; i <= numberB; i++) {
                result = result * numberA;
            }
                return result;
            }

            Console.Write("Введите число A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int exponentiation = Exponentiation(numberA, numberB);
            Console.WriteLine("Ответ: " + exponentiation);
            break;

        case 2:
            
            Console.Write("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int SumNumber(int numberN){
                
                int counter = Convert.ToString(numberN).Length;
                int advance = 0;
                int result = 0;
                if (numberN % counter == 0)
                for (int i = 0; i < counter; i++){
                advance = numberN - numberN % 10;
               // if (numberN % advance == 0) {
                result = result + (numberN - advance);
                numberN = numberN / 10;
                //}
            }
            return result;
            }

            int sumNumber = SumNumber(numberN);
            Console.WriteLine("Сумма цифр в числе: " + sumNumber);
            break;
    }
}