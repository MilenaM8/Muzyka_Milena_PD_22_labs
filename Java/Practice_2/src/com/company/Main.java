package com.company;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        var userService = new CustomUserService();
        var users = new ArrayList<CustomUser>();
        var user1 = new CustomUser(1, "Valerii", "example@example.com", 20, "p@ssw0rd1");
        var user2 = new CustomUser(2, "Max", "max@example.com", 19, "p@ssw0rd2");
        var user3 = new CustomUser(3, "Ivan", "ivan@pupkin.com", 20, "p@ssw0rd3");
        var user4 = new CustomUser(4, "Edik", "edik@example.com", 21, "p@ssw0rd4");
        var user5 = new CustomUser(5, "Sergei", "sergei@example.com", 25, "p@ssw0rd5");

        users.add(user1);
        users.add(user2);
        users.add(user3);
        users.add(user4);
        users.add(user5);

        var emails = userService.selectEmails(users);
        System.out.println("Emails");
        for (var email: emails) {
            System.out.println("Email: " + email);
        }
        System.out.println("\nUsers with age 20");
        var usersWithAge = userService.selectUsersWithAge(users, 20);
        for (var user: usersWithAge) {
            System.out.println("\tId: " + user.Id + "\n\tName: " + user.Name + "\n\tEmail: " + user.Email + "\n\tAge: " + user.Age + "\n" );
        }
        System.out.println("\nUsers DTO");
        var usersDto = userService.mapCustomUserDto(users);
        for (var user: usersDto) {
            System.out.println("\tName: " + user.Name + "\n\tEmail: " + user.Email + "\n\tAge: " + user.Age + "\n" );
        }
    }
}
