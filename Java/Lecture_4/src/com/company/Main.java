package com.company;
import java.util.*;
import java.util.stream.Collectors;
public class Main {

    public static void main(String[] args) {
        //Const
        var random = new Random();

        //Task 1
        List<String> myList = Arrays.asList("a1", "a2", "b1", "c2", "c1");
        myList = myList.stream().filter(item -> item.contains("c")).map(item -> item.toUpperCase(Locale.ROOT)).collect(Collectors.toList());
        myList.sort(String::compareTo);
        for (var item: myList)
            System.out.println(item);

        //Task 2
        System.out.print("Enter collection size: ");
        Scanner input = new Scanner(System.in);
        if (!input.hasNextInt())
            return;

        ArrayList<Integer> randomNumbers = new ArrayList<>();
        var size = input.nextInt();
        System.out.println("Numbers");
        for (int i = 0; i < size; i++) {
            var number = random.nextInt(10);
            randomNumbers.add(number);
            System.out.print(number + "; ");
        }

        var sumOfPairNumbers= randomNumbers.stream().filter(number -> number % 2 == 0).reduce(0, (a, b) -> a + b);
        var count = randomNumbers.stream().filter(number -> number % 2 == 0).count();
        System.out.println("Arithmetic mean: " + (count != 0 ?  sumOfPairNumbers / count : 0));

        //Task 3
        var str = "sjdhgfsjkavchjwagehf".toCharArray();
        for (int i = 0; i < str.length; i++)
            if ((int)str[i] >= 104 && (int)str[i] <= 116)
                str[i] = Character.toUpperCase(str[i]);
        System.out.println(str);

        //Task 4
        //Already generic

        //Task 5
        ArrayList<User> users = new ArrayList<>();
        users.add(new User("Ivan", "ivan@pupkin.com", 14));
        users.add(new User("Jone", "jone@pupkin.com", 18));
        users.add(new User("Mike", "mike@example.com", 24));
        users.add(new User("Greg", "greg@pupkin.com", 11));
        users.add(new User("Jane", "jane@pupkin.com", 17));

        var adults = (
            users
            .stream()
            .filter(user -> user.age >= 18))
            .map(user -> UserMapper.mapToUserDto(user))
            .collect(Collectors.toList());

        System.out.println("Adults");
        for (var adult: adults) {
            System.out.println("\tName: " + adult.name + "\n\tEmail: " + adult.email + "\n\tAge:" + adult.age + "\n");
        }
    }
}

