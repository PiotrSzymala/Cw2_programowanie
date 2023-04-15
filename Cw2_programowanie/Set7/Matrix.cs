namespace Cw2_programowanie.Set7;

public class Matrix
{
    private double[,] _squareMatrix;

    public double[,] SquareMatrix
    {
        get
        {
            return _squareMatrix;
        }

        set
        {
            _squareMatrix = value;
        }
    }
    
    public Matrix(int i)
    {
        if (i <= 0)
            throw new FormatException();
        else
            this._squareMatrix = new double[i, i];
    }
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1._squareMatrix.Length != m2._squareMatrix.Length)
        {
            throw new ArgumentException("Matrices lengths are not the same.");
        }

      
        for (int i = 0; i < m1._squareMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < m1._squareMatrix.GetLength(1); j++)
            {
                m1._squareMatrix[i,j] += m2._squareMatrix[i,j];
            }
        }

        return m1;
    }
    
    public  static  void DisplayMatrix(Matrix matrix)
    {
        for (int i = 0; i < matrix.SquareMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.SquareMatrix.GetLength(1); j++)
            {
                Console.Write(matrix.SquareMatrix[i,j] + " ");
            }

            Console.WriteLine();
        }
    }
}