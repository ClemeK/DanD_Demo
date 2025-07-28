public static class IntegerExtensions
{
    public static bool IsEven(this int input)
    {
        return input % 2 == 0;
    }

    // ************************
    public static string Hex(this int input)
    {
        string z = "0123456789ABCDEF";
        string output = "";
        int nbr = input;

        if (input > 16)
        {
            do
            {
                int remainder = nbr % 16;
                output = z.Substring(remainder, 1) + output;
                nbr /= 16;
            } while (nbr > 16);
        }

        output = z.Substring(nbr, 1) + output;

        return output;
    }

    // ************************
    public static string HexLC(this int input)
    {
        string output = "";

        output = Convert.ToString(input, 16);

        int size = output.Length;
        if (size % 4 != 0)
        {
            size = (size / 4) + 1;
            output = output.PadLeft(size * 4, '0');
        }

        return output;
    }

    // ************************
    public static string Binary(this int input)
    {
        string output = "";
        int nbr = input;

        if (input > 1)
        {
            do
            {
                int remainder = nbr % 2;
                if (remainder == 0)
                {
                    output = "0" + output;
                }
                else
                {
                    output = "1" + output;
                }
                nbr /= 2;
            } while (nbr > 1);

            output = nbr.ToString() + output;
        }

        if (output.Length % 4 != 0)
        {
            do
            {
                output = "0" + output;
            } while (output.Length % 4 != 0);
        }

        return output;
    }
    // ************************
    public static string Binary2(this int input)
    {
        string output = "";

        output = Convert.ToString(input, 2);

        int size = output.Length;
        if (size % 4 != 0)
        {
            size = (size / 4) + 1;
            output = output.PadLeft(size * 4, '0');
        }

        return output;
    }
    // ************************
    public static bool Between(this int nbr, int low, int high)
    {
        if (nbr < low)
        {
            return false;
        }

        if (nbr > high)
        {
            return false;
        }

        return true;
    }
}