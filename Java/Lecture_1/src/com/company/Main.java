package com.company;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        try{
            Scanner input = new Scanner(System.in);
            System.out.println("Task One");
            TaskOne taskOne = new TaskOne(input);
            System.out.println("\nTask Two");
            TaskTwo taskTaskTwo = new TaskTwo(input);
            input.close();
        }
        catch(Exception ex)
        {
            System.out.println("\n" + ex.getMessage());
        }

    }
}

