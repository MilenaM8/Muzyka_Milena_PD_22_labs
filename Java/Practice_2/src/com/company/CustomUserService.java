package com.company;

import java.util.ArrayList;
import java.util.List;

public class CustomUserService {
    public List<String> selectEmails(ArrayList<CustomUser> customUsers){
        return customUsers.stream().map(x -> x.Email).toList();
    }

    public List<CustomUserDto> mapCustomUserDto(ArrayList<CustomUser> customUsers){
        return customUsers.stream().map(x -> new CustomUserDto(x.Name, x.Email, x.Age)).toList();
    }

    public List<CustomUser> selectUsersWithAge(ArrayList<CustomUser> customUsers, int n){
        return customUsers.stream().filter(x -> x.Age == n).toList();
    }
}
