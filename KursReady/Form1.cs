using System.Text;

namespace KursReady
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MakeSort_Click(object sender, EventArgs e)
        {
            // �������� ��������� ������������� �����
            string plaintext = input.Text;

            // ������� ����� ��� ����� �����
            int[,] keyMatrix = { { 6, 24, 1 }, { 13, 16, 10 }, { 20, 17, 15 } }; // ������ ������� �����

            // ����������� ������� �����
            int dimension = 3; // ������ �����������

            // ���������� ������
            string ciphertext = HillCipherEncrypt(plaintext, keyMatrix, dimension);

            // ����� �������������� ������
            output.Text = ciphertext;
        }

        // ����� ��� ���������� ������ � �������������� ����� �����
        private string HillCipherEncrypt(string plaintext, int[,] keyMatrix, int dimension)
        {
            StringBuilder ciphertext = new StringBuilder();

            // ����������� ����� � ������� �������
            plaintext = plaintext.ToUpper();

            // ��������� ������� ��� ������� ���������� ������
            if (plaintext.Length % dimension != 0)
            {
                plaintext = plaintext.PadRight(plaintext.Length + (dimension - (plaintext.Length % dimension)), 'X');
            }

            // ������� ����� ������
            for (int i = 0; i < plaintext.Length; i += dimension)
            {
                int[] block = new int[dimension];
                for (int j = 0; j < dimension; j++)
                {
                    block[j] = plaintext[i + j] - 'A';
                }

                // �������� ���� �� ������� �����
                int[] encryptedBlock = new int[dimension];
                for (int j = 0; j < dimension; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < dimension; k++)
                    {
                        sum += keyMatrix[j, k] * block[k];
                    }
                    encryptedBlock[j] = sum % 26;
                }

                // ����������� ����� ������� � �������
                foreach (int num in encryptedBlock)
                {
                    ciphertext.Append((char)(num + 'A'));
                }
            }

            return ciphertext.ToString();
        }
        // ����� ��� ������������ ������ � �������������� ����� �����
        // ����� ��� ������������ ������ � �������������� ����� �����
        private string HillCipherDecrypt(string ciphertext, int[,] keyMatrix, int dimension)
        {
            StringBuilder plaintext = new StringBuilder();

            // ��������� ����� ������
            for (int i = 0; i < ciphertext.Length; i += dimension)
            {
                int[] block = new int[dimension];
                for (int j = 0; j < dimension; j++)
                {
                    block[j] = ciphertext[i + j] - 'A';
                }

                // ������� �������� ������� �����
                int[,] inverseKeyMatrix = InverseMatrix(keyMatrix);

                // �������� ���� �� �������� ������� �����
                int[] decryptedBlock = new int[dimension];
                for (int j = 0; j < dimension; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < dimension; k++)
                    {
                        sum += inverseKeyMatrix[j, k] * block[k];
                    }
                    decryptedBlock[j] = sum % 26;
                }

                // ����������� ����� ������� � �������
                foreach (int num in decryptedBlock)
                {
                    plaintext.Append((char)(num + 'A'));
                }
            }

            // ������� �������������� ����� � ������� output
            output.Text = plaintext.ToString();

            return plaintext.ToString();
        }
        // ����� ��� ���������� �������� �������
        private int[,] InverseMatrix(int[,] matrix)
        {
            int dimension = matrix.GetLength(0);
            int[,] inverseMatrix = new int[dimension, dimension];

            int determinant = CalculateDeterminant(matrix, dimension);
            int modularInverse = CalculateModularInverse(determinant);

            // ������� �������������� ���������� ��� ������� �������� �������
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    int[,] minorMatrix = GetMinor(matrix, i, j);
                    int minorDeterminant = CalculateDeterminant(minorMatrix, dimension - 1);
                    inverseMatrix[j, i] = (modularInverse * minorDeterminant) % 26;

                    if (inverseMatrix[j, i] < 0)
                    {
                        inverseMatrix[j, i] += 26;
                    }
                }
            }

            return inverseMatrix;
        }

        // ����� ��� ��������� ������ �������
        private int[,] GetMinor(int[,] matrix, int row, int col)
        {
            int dimension = matrix.GetLength(0);
            int[,] minorMatrix = new int[dimension - 1, dimension - 1];
            int minorRow = 0;
            int minorCol = 0;

            for (int i = 0; i < dimension; i++)
            {
                if (i == row)
                {
                    continue;
                }

                minorCol = 0;
                for (int j = 0; j < dimension; j++)
                {
                    if (j == col)
                    {
                        continue;
                    }

                    minorMatrix[minorRow, minorCol] = matrix[i, j];
                    minorCol++;
                }

                minorRow++;
            }

            return minorMatrix;
        }

        // ����� ��� ���������� ������������ �������
        // ����� ��� ���������� ������������ �������
        private int CalculateDeterminant(int[,] matrix, int dimension)
        {
            if (dimension == 1)
            {
                return matrix[0, 0];
            }
            else if (dimension == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            else
            {
                int determinant = 0;
                for (int i = 0; i < dimension; i++)
                {
                    int[,] minor = new int[dimension - 1, dimension - 1];
                    for (int j = 1; j < dimension; j++)
                    {
                        for (int k = 0; k < dimension; k++)
                        {
                            if (k < i)
                            {
                                minor[j - 1, k] = matrix[j, k];
                            }
                            else if (k > i)
                            {
                                minor[j - 1, k - 1] = matrix[j, k];
                            }
                        }
                    }
                    determinant += (int)Math.Pow(-1, i) * matrix[0, i] * CalculateDeterminant(minor, dimension - 1);
                }
                return determinant;
            }
        }

        // ����� ��� ���������� ��������� �������� � ������ �� ������ 26
        private int CalculateModularInverse(int num)
        {
            for (int i = 1; i < 26; i++)
            {
                if ((num * i) % 26 == 1)
                {
                    return i;
                }
            }
            return -1; // ���� �������� ������� �� ������
        }



    }
}
