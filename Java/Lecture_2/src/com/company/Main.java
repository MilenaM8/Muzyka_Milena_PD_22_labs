package com.company;

import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;

public class Main {

    public static void main(String[] args){
        IList list;

        System.out.println("Enter 1 if you want use LinkedList or 2 if you want use ArrayList");
        System.out.print("Enter: ");
        Scanner input = new Scanner(System.in);
        if (input.hasNextInt() && input.nextInt() == 1)
            list = new CustomLinkedList<Integer>();
        else
            list = new CustomArrayList<Integer>();

        try(ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("list.txt"))) {
            oos.writeObject(list);
            list.add(1);
            list.add(2);
            list.add(3);
            list.add(4);
            list.remove(2);
            System.out.println("Is list contains 2: " + list.contains(2));
            System.out.println("Is list contains 12: " + list.contains(12));
            System.out.println("Size is " + list.size());
            System.out.println("List:");
            list.showList();
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
