namespace Tyuiu.FilimonchukED.Sprint6.Review.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static class ArrayUtils
        {
            public static void ValidateIndices_Click(int K, int L, int C, int rows, int cols)
            {
                if (K < 0 || L >= rows || K > L)
                {
                    MessageBox.Show("Некорректные индексы для диапазона строк");
                    throw new ArgumentException();
                }
                if (C < 0 || C >= cols)
                {
                    MessageBox.Show($"Столбец C должен быть в пределах от 0 до {cols - 1}.");
                    throw new ArgumentException();
                }
            }

            public static void ValidateRange_Click(int n1, int n2)
            {
                if (n1 >= n2) {
                    MessageBox.Show("n1 должен быть меньше n2");
                    throw new ArgumentException();
                }
            }
        }
    }
}
