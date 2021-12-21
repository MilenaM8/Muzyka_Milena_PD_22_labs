package com.company;

import java.io.Serializable;

public class CustomLinkedList<T> implements IList<T>, Serializable {
    private Node head;

    //function to add an element to the list
    public void add(T data) throws Exception {
        if (data == null)
            throw new Exception("You cannot add empty data");
        Node newNode = new Node(data);
        if(head == null) {
            head = newNode;
        }else {
            Node n = head;
            while(n.next != null) {
                n = n.next;
            }
            n.next = newNode;
        }
    }

    //function to delete an element at the given index
    public void remove(int index) {
        if (index < 0 || index >= this.size())
            throw new IndexOutOfBoundsException("Index: " + index + ", Size " + index);

        if(index == 0) {
            head = head.next;
        }else{
            Node currentNode = head;
            for(int i = 0; i < index - 1; i++) {
                currentNode = currentNode.next;
            }
            currentNode.next = currentNode.next.next;
        }
    }

    //function to find data in the list
    public boolean contains(T data) throws Exception {
        if (data == null)
            throw new Exception("We cannot fund empty data");
        Node n = head;
        while (n.next != null){
            if (n.data == data)
                return true;
            n = n.next;
        }
        return false;
    }

    //function to count list size
    public int size(){
        int count = 0;
        Node n = head;
        if (n == null)
            return 0;
        while (n.next != null){
            count++;
            n = n.next;
        }
        return count+1;
    }

    //function to show the list
    public void showList() throws Exception {
        Node currentNode = head;
        if(currentNode == null)
            throw new Exception("Linked list is empty");

        else {
            while(currentNode != null) {
                System.out.print(currentNode.data + " ");
                currentNode = currentNode.next;
            }
        }
    }
}