package com.company;
import java.util.Scanner;

public class TaskTwo extends ArrayOut
{
    public TaskTwo(Scanner input)
    {
        int begin = 0, end = 0, step = 0;
        System.out.print("Enter begin: ");
        if (input.hasNextInt())
            begin = input.nextInt();

        System.out.print("Enter end: ");
        if (input.hasNextInt())
            end = input.nextInt();

        System.out.print("Enter step: ");
        if (input.hasNextInt())
            step = input.nextInt();

        OutArray(FillArray(begin, end, step));
    }

    private int[] FillArray(int begin, int end, int step)
    {
        if (begin * step > end)
            return new int[]{begin, end};

        int size = 0;
        for (int i = begin; i < end; i += step)
            ++size;
        int[] arr = new int[size + 1];
        int number = begin;
        arr[0] = begin;
        for (int i = 1; i <= size; i++) {
            number += step;
            arr[i] = number;
        }
        return arr;
    }
}
