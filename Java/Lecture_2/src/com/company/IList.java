package com.company;

public interface IList<T> {
    public void add(T data) throws Exception;
    public void remove(int index) throws Exception;
    public boolean contains(T data) throws Exception;
    public int size();
    public void showList() throws Exception;
}
