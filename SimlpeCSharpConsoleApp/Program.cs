using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace SimlpeCSharpConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            //Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.WriteLine("***************************");
            Console.WriteLine("*Welcome to My Rocking App*");
            Console.WriteLine("***************************");

            // Вспомогательный метод внутри класса Program.
            

            //EndOfLearningPage();
            Console.ReadLine();
            return -1;
        }

        static void EndOfLearningPage()
        {
            Console.WriteLine("Вы остановились на {0} странице", 126);
            Console.WriteLine();
        }

        static void ShowEnvironmentDetails()
        {
            // Вывести информацию о дисковых устройствах
            // данной машины и другие интересные детали,
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive); // Логические устройства
            Console.WriteLine("OS: {0}", Environment.OSVersion); // Версия
                                                                 // операционной системы
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount); // Количество процессоров
            Console.WriteLine(".NET Version: {0}",
            Environment.Version); // Версия платформы .NET
        }

        // Демонстрация применения некоторых дескрипторов формата,
        static void FormatNumericalData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Обратите внимание, что использование для символа шестнадцатеричного формата
            // верхнего или нижнего регистра определяет регистр отображаемых символов.
            Console.WriteLine("Е format: {0:Е}", 99999);
            Console.WriteLine("е format: {0:е}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }

        static void DisplayMessage()
        {
            // Использование string.Format() для форматирования строкового литерала,
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            // Для успешной компиляции этой строки кода требуется
            // ссылка на библиотеку PresentationFramework.dll!
            System.Windows.MessageBox.Show(userMessage);
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");
            // Ключевое слово int языка C# - это в действительности сокращение для
            // типа System.Int32, который наследует от System.Object следующие члены:
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals (23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString () = {0}", 12.ToString());
            Console.WriteLine("12.GetType () = {0}", 12.GetType());
            Console.WriteLine();
        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.Negativelnfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ( 'a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ( 'a ’ ) : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation(’?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // Этот конструктор принимает год, месяц и день.
            DateTime dt = new DateTime(2015, 10, 17);
            // Какой это день месяца?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Сейчас месяц декабрь.
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // Этот конструктор принимает часы, минуты и секунды.
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Вычесть 15 минут из текущего значения TimeSpan и вывести результат.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        static void UseBiglnteger()
        {
            Console.WriteLine("=> Use Biglnteger:");

            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy - четное?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            // biggy - степень 2?
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // значение reallyBig
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\" ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug ");
            // Добавить четыре пустых строки и снова выдать звуковой сигнал.
            Console.WriteLine("All finished.\n\n\n ");
            // Следующая строка воспроизводится дословно,
            // так что отображаются все управляющие символы.
            Console.WriteLine(@"С:\MyApp\bin\Debug");
            // При использовании дословных строк пробельные символы предохраняются,
            string myLongString = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine(myLongString);
            //          Применяя дословные строки, в литеральную строку можно также напрямую вставлять
            //          символы двойной кавычки, просто дублируя знак ":
            Console.WriteLine(@"Cerebus said ""Darrr! Pret - ty sun - sets""");
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Проверить строки на равенство.
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("=> String equality (Case Insensitive:");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("si = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Проверить результаты изменения стандартных правил сравнения.
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ordinal: s1.Equals(s2, StringComparison.Ordinal): {0}", s1.Equals(s2, StringComparison.Ordinal));
            Console.WriteLine("Ordinal Ignore Case: s1.Equals(s2, StringComparison.OrdinallgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Invariant Culture: s1.Equals(s2, StringComparison.InvariantCulture): {0}", s1.Equals(s2, StringComparison.InvariantCulture));
            Console.WriteLine("Invariant Culture Ignore Case: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("Current Culture: s1.Equals(s2, StringComparison.CurrentCulture): {0}", s1.Equals(s2, StringComparison.CurrentCulture));
            Console.WriteLine("Current Culture Ignore Case: s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine();
            //IndexOf
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ordinal: s1.IndexOf(\"E\", StringComparison.Ordinal): {0}", s1.IndexOf("E", StringComparison.Ordinal));
            Console.WriteLine("Ordinal Ignore Case: s1.IndexOf(\"E\", StringComparison.OrdinallgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCulture): {0}", s1.IndexOf("E", StringComparison.InvariantCulture));
            Console.WriteLine("Invariant Culture Ignore Case: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine("Current Culture: s1.IndexOf(\"E\", StringComparison.CurrentCulture): {0}", s1.IndexOf("E", StringComparison.CurrentCulture));
            Console.WriteLine("Current Culture Ignore Case: s1.IndexOf(\"E\", StringComparison.CurrentCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}

