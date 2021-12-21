package com.company;
public class UserMapper{
        static User mapToUser(UserDto user){
                return new User(user.name, user.email, user.age);
        }

        static UserDto mapToUserDto(User user){
                return new UserDto(user.name, user.email, user.age);
        }
}