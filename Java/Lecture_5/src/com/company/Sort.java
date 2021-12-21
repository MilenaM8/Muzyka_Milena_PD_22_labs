package com.company;
public class Sort {
    public static int[] sortOddsOnly(int[] array) {
        int temp;
        for (int i = 0; i < array.length; i++)
        {
            if(array[i] % 2 == 0)
                continue;
            for(int j = (i + 1); j < array.length; j++)
            {
                if(array[j] % 2 != 0)
                {
                    if(array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        return array;
    }
}
