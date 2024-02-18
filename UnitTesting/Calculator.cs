namespace UnitTesting
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Метод нахождения суммы 2 чисел
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns>Сумму чисел</returns>
        public Int32 Addition(Int32 a, Int32 b) =>
            a + b;

        /// <summary>
        /// Метод нахождения разности 2 чисел
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность чисел</returns>
        public Int32 Subtraction(Int32 a, Int32 b) =>
            a - b;

        /// <summary>
        /// Метод нахождения произведения 2 чисел
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Произведение чисел</returns>
        public Int32 Multiplication(Int32 a, Int32 b) =>
            a * b;

        /// <summary>
        /// Метод нахождения частного 2 чисел
        /// </summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Частное чисел</returns>
        public Int32 Division(Int32 a, Int32 b) =>
            a / b;
    }
}