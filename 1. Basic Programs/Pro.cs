﻿public class Pro
{
    public int sum(int num)
    {
        if (num != 0)
        {
            return (num % 10 + sum(num / 10));
        }
        else
        {
            return 0;
        }
    }
}