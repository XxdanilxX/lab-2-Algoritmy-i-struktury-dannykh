namespace lab_2_Algoritmy_i_struktury_dannykh
{
    public partial class Form1 : Form
    {
        // Генерація випадкового масиву для двійкового пошуку
        private int[] searchArray;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomArray();
        }
        // Метод для генерації випадкового масиву
        private void GenerateRandomArray()
        {
            Random rand = new Random();
            searchArray = new int[10];

            // Генеруємо випадкові числа і сортуємо їх
            for (int i = 0; i < searchArray.Length; i++)
            {
                searchArray[i] = rand.Next(1, 100); 
            }
            Array.Sort(searchArray);

            // Виводимо масив у текстове поле або інший елемент форми для відображення
            labelArray.Text = $"Масив для пошуку: {string.Join(", ", searchArray)}";
        }

        // Метод для базового двійкового пошуку, який рахує кількість ітерацій
        private (int, int) BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int iterations = 0;

            while (left <= right)
            {
                iterations++; // Рахуємо кількість ітерацій
                int mid = (left + right) / 2;
                if (array[mid] == target)
                    return (mid, iterations);
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return (-1, iterations); // Якщо не знайдено
        }

        // Метод для оптимізованого двійкового пошуку, який рахує кількість ітерацій
        private (int, int) OptimizedBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int iterations = 0;

            while (left <= right)
            {
                iterations++; // Рахуємо кількість ітерацій

                // Оптимізоване обчислення індексу на основі передбачуваного лінійного зростання
                int mid = left + (target - array[left]) * (right - left) / (array[right] - array[left]);

                if (mid < left || mid > right) // Перевірка на межі
                    mid = (left + right) / 2;

                if (array[mid] == target)
                    return (mid, iterations);
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return (-1, iterations); // Якщо не знайдено
        }

        private int InputInteger(string input)
        {
            int value;
            if (int.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                throw new FormatException("Некоректний ввід. Будь ласка, введіть ціле число.");
            }
        }

        // Обробка натискання кнопки пошуку
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int target = InputInteger(textBoxInput.Text);

                // Виконуємо базовий пошук
                var (baseIndex, baseIterations) = BinarySearch(searchArray, target);
                if (baseIndex != -1)
                    labelBaseResult.Text = $"Базовий пошук: Кількість ітерацій = {baseIterations}";
                else
                    labelBaseResult.Text = $"Базовий пошук: Число не знайдено. Кількість ітерацій = {baseIterations}";

                // Виконуємо оптимізований пошук
                var (optimizedIndex, optimizedIterations) = OptimizedBinarySearch(searchArray, target);
                if (optimizedIndex != -1)
                    labelOptimizedResult.Text = $"Оптимізований пошук: Кількість ітерацій = {optimizedIterations}";
                else
                    labelOptimizedResult.Text = $"Оптимізований пошук: Число не знайдено. Кількість ітерацій = {optimizedIterations}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Метод для видалення зайвих пропусків
        private string RemoveExtraSpaces(string sentence)
        {
            return string.Join(" ", sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        // Обробка натискання кнопки для видалення зайвих пропусків
        private void ButtonRemoveSpaces_Click(object sender, EventArgs e)
        {
            string inputSentence = textBoxSentence.Text.Trim();

            // Перевірка чи закінчується речення крапкою
            if (!inputSentence.EndsWith("."))
            {
                MessageBox.Show("Будь ласка, переконайтеся, що речення закінчується крапкою.");
                return;
            }

            try
            {
                // Видаляємо зайві пропуски
                string resultSentence = RemoveExtraSpaces(inputSentence);
                labelResult.Text = $"Результат: {resultSentence}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час обробки речення: " + ex.Message);
            }
        }
    }
}
