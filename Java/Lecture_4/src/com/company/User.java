package com.company;
public class User{
    String name;
    String group;
    String password;
    String email;
    float height;
    int age;

    User(String name, String email, int age){
        this.name = name;
        this.email = email;
        this.age = age;
    }
}