namespace Rational2
{
    public class Rational
    {
        /// <summary>
        /// Числитель дроби
        /// </summary>
        private int m;
        /// <summary>
        /// Знаменатель дроби
        /// </summary>
        private int n;
        /// <summary>
        /// Конструктор без аргументов, который ставит значение по умолчанию - нуль
        /// </summary>
        public Rational()
        {
            m = 0;
            n = 1;
        }
        /// <summary>
        /// Конструктор с одним аргументом, который создает экземпляр класса
        /// с числителем, данным в аргументах, и знаменателем, равным единице
        /// </summary>
        /// <param name="k">Целое число, числитель дроби 
        /// со знаменателем равным единице</param>
        public Rational (int k)
        {
            m = k;
            n = 1;
        }
        /// <summary>
        /// Конструктор с двумя аргументами, позволяющий создать
        /// произвольное рациональное число вида m / n
        /// </summary>
        /// <param name="m">Числитель дроби</param>
        /// <param name="n">Знаменатель дроби</param>
        /// <exception cref="ArgumentException">
        /// Исключение, возникающее в случае, если осущствляется попытка
        /// создать экземпляр класса с нулем в знаменателе
        /// </exception>
        public Rational (int m, int n)
        {
            if (n == 0)
                throw new ArgumentException("Создание рационального числа с 0 " +
                    "в знаменателе невозможно!");
            (this.m, this.n) = Reduce(m, n);

        }
        /// <summary>
        /// Возвращает текущий числитель
        /// </summary>
        /// <returns>Числитель текущего объекта</returns>
        public int GetNumerator()
        {
            return this.m;
        }
        /// <summary>
        /// Возвращает текущий знаменатель
        /// </summary>
        /// <returns>Знаменатель текущего объекта</returns>
        public int GetDenominator()
        {
            return this.n;
        }
        /// <summary>
         /// Метод, складывающий два рациональных числа
         /// </summary>
         /// <param name="second"></param> Рациональное число, 
         /// с которым производятся арифмитические операции 
         /// <returns>
         /// Возвращает результат сложения двух рациональных чисел
         /// </returns>
        private Rational Add (Rational second)
        {
            m = (m * second.n + second.m * n);
            n *= second.n;
            (this.m, this.n) = Reduce(this.m, this.n);
            return this;
        }
        /// <summary>
        /// Метод, перемножающий два рациональных числа
        /// </summary>
        /// <param name="second"></param> Рациональное число, 
        /// с которым производятся арифмитические операции
        /// <returns>
        /// Возвращает результат перемножения двух рациональных чисел
        /// </returns>
        private Rational Multiply (Rational second)
        {
            m *= second.m;
            n *= second.n;
            (this.m, this.n) = Reduce(this.m, this.n);
            return this;
        }
        /// <summary>
        /// Метод, позволяющий вычесть из одного рационального числа другое
        /// </summary>
        /// <param name="second"></param> Рациональное число, 
        /// с которым производятся арифмитические операции
        /// <returns>
        /// Возвращает результат вычитания двух рациональных чисел
        /// </returns>
        private Rational Sub(Rational second)
        {
            if (n != second.n)
            {
                int commonN = n * second.n;
                int newM1 = m * second.n;
                int newM2 = second.m * n;

                int resultR = newM1 - newM2;
                return new Rational(resultR, commonN);
            }
            else
            {
                int resultM = m - second.m;
                (this.m, this.n) = Reduce(this.m, this.n);
                return new Rational(resultM, n);
            }
        }
        /// <summary>
        /// Метод, позволяющий поделить одно рациональное число на другое
        /// </summary>
        /// <param name="second"></param> Рациональное число, 
        /// с которым производятся арифмитические операции
        /// <returns>
        /// Возвращает результат деления одного рационального числа на другое
        /// </returns>
        private Rational Divide (Rational second)
        {
            int newM = this.m * second.n;
            int newN = this.n * second.m;
            (this.m, this.n) = Reduce(this.m, this.n);

            return new Rational(newM, newN);
        }
        /// <summary>
        /// Метод, складывающий рациональное число с числом типа int
        /// </summary>
        /// <param name="second"></param> Челое число, 
        /// с которым производятся арифмитические операции 
        /// <returns>
        /// Возвращает результат сложения рационального числа с целым
        /// </returns>
        private Rational Add(int second)
        {
            return this.Add(new Rational(second));
        }
        /// <summary>
        /// Метод, перемножающий рациональное число с числом типа int
        /// </summary>
        /// <param name="second"></param> Челое число, 
        /// с которым производятся арифмитические операции 
        /// <returns>
        /// Возвращает результат умножения рационального числа и целого
        /// </returns>
        private Rational Multiply(int second)
        {
            return this.Multiply(new Rational(second));

        }
        /// <summary>
        /// Метод, позволяющий вычесть из рационального числа число типа int
        /// </summary>
        /// <param name="second"></param> Челое число, 
        /// с которым производятся арифмитические операции 
        /// <returns>
        /// Возвращает результат вычитания из рационального числа целое
        /// </returns>
        private Rational Sub(int second)
        {
            return this.Sub(new Rational(second));
        }
        /// <summary>
        /// Метод, позволяющий поделить рациональное число на целое
        /// </summary>
        /// <param name="second"></param> Челое число, 
        /// с которым производятся арифмитические операции 
        /// <returns>
        /// Возвращает результат деления рационального числа на целое
        /// </returns>
        private Rational Divide(int second)
        {
            return this.Divide(new Rational(second));
        }
        /// <summary>
        /// Оператор, позволяющий складывать два числа(Для Int)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>

        public static Rational operator +(Rational first, Rational Second)
        {
            return first.Add(Second);
        }
        /// <summary>
         /// Оператор, позволяющий вычитать два числа(Для Rational)
         /// </summary>
         /// <param name="first"></param>
         /// <param name="Second"></param>
         /// <returns></returns>
        public static Rational operator -(Rational first, Rational Second)
        {
            return first.Sub(Second);
        } 
        /// <summary>
          /// Оператор, позволяющий умножать два числа(Для Rational)
          /// </summary>
          /// <param name="first"></param>
          /// <param name="Second"></param>
          /// <returns></returns>
        public static Rational operator *(Rational first, Rational Second)
        {
            return first.Multiply(Second);
        }
        /// <summary>
        /// Оператор позволяющий делить два числа (Для Rational)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Rational operator /(Rational first, Rational Second)
        {
            return first.Divide(Second);
        }
        /// <summary>
        /// Оператор, позволяющий складывать два числа(Для Int)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Rational operator +(Rational first, int Second)
        {
            return first.Add(new Rational(Second));
        }
        /// <summary>
        /// Оператор позволяющий вычитать два числа (Для Int)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Rational operator -(Rational first, int Second)
        {
            return first.Sub(new Rational(Second));
        }
        /// <summary>
        /// Оператор, позволяющий умножать два числа (Для Int)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Rational operator *(Rational first, int Second)
        {
            return first.Multiply(new Rational(Second));
        }
        /// <summary>
        /// Оператор, позволяющий делить два числа (Для Int)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="Second"></param>
        /// <returns></returns>
        public static Rational operator /(Rational first, int Second)
        {
            return first.Divide(new Rational(Second));
        }
        /// <summary>
        /// Возвращает отображение текущего рационального числа в виде строки
        /// </summary>
        /// <returns>Строка, отображающая текущий объект</returns>
        public override string ToString()
        {
            if (n != 1)
                return $"{m} / {n}";
            return $"{m}";
        }
        /// <summary>
        /// Функция, позвляющая получить хэш-код для экземпляра объекта
        /// </summary>
        /// <returns>Значение хэш-функции для текущего объекта</returns>
        public override int GetHashCode()
        {
            return (int)Math.Pow(m, n) % 65537;
        }
        /// <summary>
        /// Проверяет на равенство это рациональное число
        /// и данный объект
        /// </summary>
        /// <param name="rational">Объект - предположительно, рациональное число</param>
        /// <returns>
        /// true: данное рациональное число равно текущему
        /// либо они ссылаются на один и тот же объект
        /// false: данное рациональное число не равно текущемы
        /// либо это объекты разных типов 
        /// </returns>
        public override bool Equals(object? rational)
        {
            if (rational == this)
                return true;

            Rational num;
            if (rational == null)
                return false;

            if (rational is Rational)
                num = (Rational)rational;
            else
                return false;

            if (this.GetHashCode() == num.GetHashCode())
                if (this.m == num.m && this.n == num.n)
                    return true;
            return false;
        }
        public static Rational Copy(Rational first)
        {
            return new Rational(first.n, first.m);
        }
        /// <summary>
        /// Метод, позволяющий привести числитель и знаменатель
        /// к несократимому виду
        /// </summary>
        /// <param name="m">Сокращаемый числитель</param>
        /// <param name="n">Сокращаемый знаменатель</param>
        /// <returns>
        /// Кортеж из двух чисел - 
        /// нового несократимного числителя и нового знаменателя
        /// </returns>
        private (int, int) Reduce(int m, int n)
        {
            if (m == 0)
                return (0, 1);
            int a, b, nod;
            bool isNegative = m < 0 && n > 0 || m > 0 && n < 0;

            a = Math.Abs(m);
            b = Math.Abs(n);
            nod = NOD(a, b);
            m /= nod;
            n /= nod;

            if (isNegative)
                return (-Math.Abs(m), Math.Abs(n));
            else
                return (Math.Abs(m), Math.Abs(n));
        }
        /// <summary>
        /// Метод, находящий наибольший общий делитель двух чисел
        /// с помощью алгоритма Евклида
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>НОД двух чисел</returns>
        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
        /// <summary>
        /// Позволяет преобразовать строку к рациональному числу
        /// </summary>
        /// <param name="num">Приводимая строка</param>
        /// <returns>Rational число, содержащееся в строке</returns>
        /// <exception cref="Exception">Исключение, возникающее в случае,
        /// если приведение к Rational невозможно
        /// </exception>
        public static Rational Parse(string num)
        {
            string res = num.Trim();
            string[] nums = res.Split("/");
            if (nums.Length != 2 && nums.Length != 1)
            {
                throw new Exception("Приведение к Rational невозможно");
            }

            Rational result = new Rational();
            if (nums.Length == 2)
            {
                int m = Convert.ToInt32(nums[0]), n = Convert.ToInt32(nums[1]);
                result = new Rational(m, n);
            }
            if (nums.Length == 1)
            {
                int m = Convert.ToInt32(nums[0]);
                result = new Rational(m);
            }
            return result;
        }
    }
}