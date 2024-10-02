namespace lab_2_Algoritmy_i_struktury_dannykh
{
    public partial class Form1 : Form
    {
        // ��������� ����������� ������ ��� ��������� ������
        private int[] searchArray;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomArray();
        }
        // ����� ��� ��������� ����������� ������
        private void GenerateRandomArray()
        {
            Random rand = new Random();
            searchArray = new int[10];

            // �������� �������� ����� � ������� ��
            for (int i = 0; i < searchArray.Length; i++)
            {
                searchArray[i] = rand.Next(1, 100); 
            }
            Array.Sort(searchArray);

            // �������� ����� � �������� ���� ��� ����� ������� ����� ��� �����������
            labelArray.Text = $"����� ��� ������: {string.Join(", ", searchArray)}";
        }

        // ����� ��� �������� ��������� ������, ���� ���� ������� ��������
        private (int, int) BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int iterations = 0;

            while (left <= right)
            {
                iterations++; // ������ ������� ��������
                int mid = (left + right) / 2;
                if (array[mid] == target)
                    return (mid, iterations);
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return (-1, iterations); // ���� �� ��������
        }

        // ����� ��� ������������� ��������� ������, ���� ���� ������� ��������
        private (int, int) OptimizedBinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            int iterations = 0;

            while (left <= right)
            {
                iterations++; // ������ ������� ��������

                // ����������� ���������� ������� �� ����� ��������������� ������� ���������
                int mid = left + (target - array[left]) * (right - left) / (array[right] - array[left]);

                if (mid < left || mid > right) // �������� �� ���
                    mid = (left + right) / 2;

                if (array[mid] == target)
                    return (mid, iterations);
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return (-1, iterations); // ���� �� ��������
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
                throw new FormatException("����������� ���. ���� �����, ������ ���� �����.");
            }
        }

        // ������� ���������� ������ ������
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int target = InputInteger(textBoxInput.Text);

                // �������� ������� �����
                var (baseIndex, baseIterations) = BinarySearch(searchArray, target);
                if (baseIndex != -1)
                    labelBaseResult.Text = $"������� �����: ʳ������ �������� = {baseIterations}";
                else
                    labelBaseResult.Text = $"������� �����: ����� �� ��������. ʳ������ �������� = {baseIterations}";

                // �������� ������������ �����
                var (optimizedIndex, optimizedIterations) = OptimizedBinarySearch(searchArray, target);
                if (optimizedIndex != -1)
                    labelOptimizedResult.Text = $"������������ �����: ʳ������ �������� = {optimizedIterations}";
                else
                    labelOptimizedResult.Text = $"������������ �����: ����� �� ��������. ʳ������ �������� = {optimizedIterations}";
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ����� ��� ��������� ������ ��������
        private string RemoveExtraSpaces(string sentence)
        {
            return string.Join(" ", sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }

        // ������� ���������� ������ ��� ��������� ������ ��������
        private void ButtonRemoveSpaces_Click(object sender, EventArgs e)
        {
            string inputSentence = textBoxSentence.Text.Trim();

            // �������� �� ���������� ������� �������
            if (!inputSentence.EndsWith("."))
            {
                MessageBox.Show("���� �����, �������������, �� ������� ���������� �������.");
                return;
            }

            try
            {
                // ��������� ���� ��������
                string resultSentence = RemoveExtraSpaces(inputSentence);
                labelResult.Text = $"���������: {resultSentence}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("������� �� ��� ������� �������: " + ex.Message);
            }
        }
    }
}
