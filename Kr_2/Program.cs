using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // Кодування, яке використовується для виведення тексту в консоль.

        const int arraySize = 10; // Константа, яка задає розмір масиву
        int[] numbers = new int[arraySize]; // Масив для зберігання чисел, введених користувачем

        Console.WriteLine($"Введіть {arraySize} цілих чисел:");

        // Цикл для введення чисел користувачем
        for (int i = 0; i < arraySize; i++)
        {
            while (true) // Безкінечний цикл для перевірки коректності введення
            {
                Console.Write($"Число {i + 1}: "); // Запит на введення числа
                string input = Console.ReadLine(); // Зчитування введеного значення

                // Перевірка, чи введене значення є цілим числом
                if (int.TryParse(input, out int number))
                {
                    numbers[i] = number; // Збереження числа в масив
                    break; // Вихід із циклу, якщо введення коректне
                }
                else
                {
                    Console.WriteLine("Невірний формат. Введіть ціле число."); // Повідомлення про помилку введення
                }
            }
        }

        // Знаходження максимального значення в масиві
        int max = numbers.Max();
        // Знаходження мінімального значення в масиві
        int min = numbers.Min();

        // Виведення максимального і мінімального значень
        Console.WriteLine($"Максимальне значення: {max}");
        Console.WriteLine($"Мінімальне значення: {min}");

        // Сортування масиву в порядку зростання
        Array.Sort(numbers);
        // Реверс масиву для отримання порядку спадання
        Array.Reverse(numbers);

        // Виведення відсортованого масиву
        Console.WriteLine("Масив, відсортований у порядку спадання:");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
