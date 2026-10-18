namespace Lesson4_homework;


internal class Temperature
{
    public int Amount { get; set; }
    public string Measure { get; set; }
    public override string? ToString()
    {
        return $"{Amount} {Measure}";
    }
    public static Temperature operator +(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return new Temperature { Amount = t1.Amount + t2.Amount, Measure = t1.Measure };
        }
        else
        {
            throw new InvalidOperationException(" Error");
        }
    }

    public static Temperature operator -(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return new Temperature { Amount = t1.Amount - t2.Amount, Measure = t1.Measure };
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static Temperature operator *(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return new Temperature { Amount = t1.Amount * t2.Amount, Measure = t1.Measure };
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static Temperature operator /(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure && t2.Amount != 0)
        {
            return new Temperature { Amount = t1.Amount / t2.Amount, Measure = t1.Measure };
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static bool operator >(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount > t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }
    public static bool operator <(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount < t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static bool operator ==(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount == t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static bool operator !=(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount != t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static bool operator >=(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount >= t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static bool operator <=(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return t1.Amount <= t2.Amount;
        }
        else
        {
            throw new InvalidOperationException("Error");
        }
    }

    public static Temperature operator %(Temperature t1, Temperature t2)
    {
        if (t1.Measure == t2.Measure)
        {
            return new Temperature { Amount = t1.Amount % t2.Amount, Measure = t1.Measure };
        }
        else
        {
            throw new InvalidOperationException(" Error");
        }
    }

    public static Temperature operator ++(Temperature t1)
    {
        t1.Amount++;
        return t1;
    }

    public static Temperature operator --(Temperature t1)
    {
        t1.Amount--;
        return t1;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        throw new NotImplementedException();
    }

   
}
