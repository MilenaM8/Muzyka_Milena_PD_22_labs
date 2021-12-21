package com.company;
import java.util.Arrays;
import java.util.stream.IntStream;

public class Main {

    public static void main(String[] args) {
        //TaskOne
        String[] inputArr = {"Don't", "worry", ",", "be", "happy", "!"};
        var taskOne = reverse(inputArr);
        System.out.println(Arrays.toString(taskOne));
        //TaskTwo
        System.out.println(Arrays.toString(findMultiples(3,4)));
        //TaskThree
        System.out.println(hasNoneLetters("l", "Don't worry be happy!"));
        //TaskFour
        System.out.println(longestWord("Don't worry be happy!"));

    }

    static String[] reverse(String[] Q) {
        String R = new StringBuffer(String.join("",Q)).reverse().toString();
        int[] S = {0};
        return Arrays.stream(Q).map(V -> R.substring(S[0],S[0] += V.length())).toArray(String[]::new);
    }

    public static int[] findMultiples(int m, int n) {
        return IntStream.rangeClosed(1, m).map(x -> x * n).toArray();
    }

    static boolean hasNoneLetters(String blacklist, String phrase) {
        blacklist = blacklist.toLowerCase();
        phrase = phrase.toLowerCase();
        char[] c1 = blacklist.toCharArray();
        char[] c2 = phrase.toCharArray();
        for (int i = 0; i < c1.length; i++) {
            for (int j = 0; j < c2.length; j++) {
                if (c1[i] == c2[j]) {
                    return false;
                }
            }
        }
        return true;
    }

    static String longestWord(String text) {
        var wordArray = text.split(" ");
        var maxLength = 0;
        var result = "";

        for (var i = 0; i < wordArray.length; i++) {
            if (wordArray[i].length() > maxLength) {
                maxLength = wordArray[i].length();
                result = wordArray[i];
            }
        }

        return result;
    }
}
