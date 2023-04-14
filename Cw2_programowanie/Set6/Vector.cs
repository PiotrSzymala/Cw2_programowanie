namespace Cw2_programowanie.Set6;

public class Vector
{
    public int[] Data { get; set; }

    public Vector(int[] data)
    {
        Data = data;
    }

    public Vector(int n)
    {
        if (n>0)
        {
            Random rnd = new Random();
            Data = new int[n];

            for (int i = 0; i < n; i++)
            {
                Data[i] = rnd.Next(0, 101);
            }
        }
        else
        {
            throw new Exception("n should be greater than 0");
        }
    }

    public static Vector Multiply(Vector vector, int r)
    {
        for (int i = 0; i < vector.Data.Length; i++)
        {
            vector.Data[i] *= r;
        }

        return vector;
    }

    public static Vector operator *(Vector v1, Vector v2)
    {
        if (v1.Data.Length !=  v2.Data.Length)
        {
            throw new ArgumentException("The two vectors must have te same lenght");
        }

        int[] result = new int[v1.Data.Length];
        
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = v1.Data[i] * v2.Data[i];
        }

        return new Vector(result);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        if (ReferenceEquals(v1,v2))
        {
            return true;
        }
        
        if (v1 is null || v2 is null)
        {
            return false;
        }

        if (v1.Data.Length != v2.Data.Length)
        {
            return false;
        }

        for (int i = 0; i < v1.Data.Length; i++)
        {
            if (v1.Data[i] != v2.Data[i])
                return false;
        }
        
        return true;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }
}