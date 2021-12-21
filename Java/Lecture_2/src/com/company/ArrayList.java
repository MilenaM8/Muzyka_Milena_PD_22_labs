package com.company;

import java.io.Serializable;
import java.util.Arrays;

class CustomArrayList<T> implements IList<T>, Serializable {
    private static final int initialCapacity = 10;
    private int size = 0;
    private Object elementData[] = {};

    public CustomArrayList() {
        elementData = new Object[initialCapacity];
    }

    //add elements in ArrayList
    public void add(T data) throws Exception {
        if (data == null)
            throw new Exception("You cannot add empty data");
        if (size == elementData.length) {
            ensureCapacity();
        }
        elementData[size++] = data;
    }

    //function to delete an element at the given index
    public void remove(int index) {
        if (index < 0 || index >= size)
            throw new IndexOutOfBoundsException("Index: " + index + ", Size " + index);

        for (int i = index; i < size - 1; i++) {
            elementData[i] = elementData[i + 1];
        }
        size--;
    }

    //function to find data in the list
    public boolean contains(T data) throws Exception {
        if (data == null)
            throw new Exception("We cannot fund empty data");
        for (int i = 0; i < size - 1; i++) {
            if (elementData[i] == data)
                return true;
        }
        return false;
    }

    //function to count list size
    public int size(){ return size; }

    //function to show the list
    public void showList() throws Exception {
        if(size == 0)
            throw new Exception("Linked list is empty");
        for (int i = 0; i < size; i++) {
            System.out.print(elementData[i] + " ");
        }
    }

    //Method increases capacity of list by making it double.
    private void ensureCapacity() {
        int newIncreasedCapacity = elementData.length * 2;
        elementData = Arrays.copyOf(elementData, newIncreasedCapacity);
    }
}