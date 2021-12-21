package com.company;
import java.util.Random;
import java.util.Scanner;

public class TaskOne extends ArrayOut
{
    public TaskOne(Scanner input) throws Exception {
        int n = 0, m = 0;
        System.out.print("Enter N: ");
        if (input.hasNextInt())
            n = input.nextInt();

        System.out.print("Enter M: ");
        if (input.hasNextInt())
            m = input.nextInt();

        int[][] arr = FillArray(n, m);
        System.out.println("\nMatrix");
        OutDoubleArray(arr);
        System.out.println("\nSecondary Diagonal");
        OutArray(FindSecondaryDiagonal(n, m, arr));
    }

    private static void OutDoubleArray(int[][] arr)
    {
        for (int[] arrayItem : arr) {
            for (int innerItem : arrayItem) {
                System.out.print(innerItem + " ");
            }
            System.out.println();
        }
    }

    private static int[][] FillArray(int n, int m) throws Exception {
        if (n <= 0 || m <= 0)
            throw new Exception("N and M cannot be less than 0");
        Random random = new Random();
        int[][] arr = new int[n][m];
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                arr[i][j] = random.nextInt(10);
            }
        }
        return arr;
    }

    private static int[] FindSecondaryDiagonal(int n, int m, int[][] arr) throws Exception {
        if(n != m)
            throw new Exception("For search secondary diagonal matrix N must be equal matrix M");
        int[] outArr = new int[arr.length];
        int size = arr.length - 1;
        for (int i = 0; i < arr.length; i++) {
            outArr[i] = arr[i][size-i];
        }
        return outArr;
    }
}
