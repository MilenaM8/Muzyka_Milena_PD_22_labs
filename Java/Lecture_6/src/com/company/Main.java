package com.company;
import java.util.Scanner;
public class Main {
    static String Word = "";
    static boolean notExit = true;
    public static void main(String[] args){
        //Task 1
        // made with correct priority
        System.out.println(eval("1+5+8-7*5/4"));

        //Task 2
        var arr = fillArrayFromCenter();
        for (int i = 0; i < arr.length; i++)
            System.out.print(arr[i] + " ");

        //Task 3
        while (notExit)
            askUser();
    }

    private static double eval(final String str) {
        return new Object() {
            int pos = -1, ch;

            void nextChar() {
                ch = (++pos < str.length()) ? str.charAt(pos) : -1;
            }

            boolean eat(int charToEat) {
                while (ch == ' ') nextChar();
                if (ch == charToEat) {
                    nextChar();
                    return true;
                }
                return false;
            }

            double parse() {
                nextChar();
                double x = parseExpression();
                if (pos < str.length()) throw new RuntimeException("Unexpected: " + (char)ch);
                return x;
            }

            double parseExpression() {
                double x = parseTerm();
                for (;;) {
                    if      (eat('+')) x += parseTerm(); // addition
                    else if (eat('-')) x -= parseTerm(); // subtraction
                    else return x;
                }
            }

            double parseTerm() {
                double x = parseFactor();
                for (;;) {
                    if      (eat('*')) x *= parseFactor(); // multiplication
                    else if (eat('/')) x /= parseFactor(); // division
                    else return x;
                }
            }

            double parseFactor() {
                if (eat('+')) return parseFactor(); // unary plus
                if (eat('-')) return -parseFactor(); // unary minus

                double x;
                int startPos = this.pos;
                if (eat('(')) { // parentheses
                    x = parseExpression();
                    eat(')');
                } else if ((ch >= '0' && ch <= '9') || ch == '.') { // numbers
                    while ((ch >= '0' && ch <= '9') || ch == '.') nextChar();
                    x = Double.parseDouble(str.substring(startPos, this.pos));
                } else if (ch >= 'a' && ch <= 'z') { // functions
                    while (ch >= 'a' && ch <= 'z') nextChar();
                    String func = str.substring(startPos, this.pos);
                    x = parseFactor();
                    if (func.equals("sqrt")) x = Math.sqrt(x);
                    else if (func.equals("sin")) x = Math.sin(Math.toRadians(x));
                    else if (func.equals("cos")) x = Math.cos(Math.toRadians(x));
                    else if (func.equals("tan")) x = Math.tan(Math.toRadians(x));
                    else throw new RuntimeException("Unknown function: " + func);
                } else {
                    throw new RuntimeException("Unexpected: " + (char)ch);
                }

                if (eat('^')) x = Math.pow(x, parseFactor()); // exponentiation

                return x;
            }
        }.parse();
    }

    private static int[] fillArrayFromCenter(){
        var length = 0 + (int) (Math.random() * 100);

        while (length % 2 == 0 || length < 2)
            length = 0 + (int) (Math.random() * 100);

        var arr = new int[length];
        var center = ((length - 1) / 2) + 1;
        var counter = 0;

        for (int i = center-1; i >= 0; i--)
            arr[i] = counter++;

        counter = 0;
        for (int i = center-1; i < length; i++)
            arr[i] = counter++;
        return arr;
    }

    private static void wordAct(){
        System.out.print("Enter word (+ before word if you want to add it/ - if you want to remove it): ");
        Scanner input = new Scanner(System.in);
        var word = input.nextLine();
        checkAndConcatWords(word);
    }

    private static void checkAndConcatWords(String str){
        if (str.toCharArray()[0] == '+')
            if(Word == "")
                Word += str.substring(1);
            else
                Word += ", " + str.substring(1);
        else if(str.toCharArray()[0] == '-' && str.contains(str.substring(1))){
            String target = Word.copyValueOf(str.substring(1).toCharArray());
            Word = Word.replace(target + ", ", "");
        }
        else
            System.out.println("Input error");
    }

    public static void askUser(){
        System.out.println("1 – add new word, 2 – output words, 3 – exit");
        System.out.print("Enter: ");
        Scanner input = new Scanner(System.in);
        if (input.hasNextInt())
            switch (input.nextInt()){
                case 1:
                    wordAct();
                    break;
                case 2:
                    System.out.println("Words: " + Word);
                    break;
                case 3:
                    notExit = false;
                    break;
            }
    }
}
