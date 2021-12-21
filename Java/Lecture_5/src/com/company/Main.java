package com.company;
public class Main {

    public static void main(String[] args) {
        System.out.println(Kata.findUniq(new double[]{1, 1, 1, 2, 1, 1}));
        System.out.println(Kata.findUniq(new double[]{0, 0, 0.55, 0, 0}));
        for (var number: Sort.sortOddsOnly(new int[] { 5, 3, 2, 8, 1, 4})) {
            System.out.print(number + " ");
        }
    }
}
