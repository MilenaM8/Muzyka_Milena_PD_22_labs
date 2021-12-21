package com.company;
import java.sql.SQLException;

public class Main {

    public static void main(String[] args) throws SQLException, ClassNotFoundException {
        var username = "root";
        var password  = "password";
        var url = "jdbc:mysql://localhost:3306/dishes";
        Class.forName("com.mysql.jdbc.Driver");

        try{
            var crud = new CRUD();
            crud.connect(url, username, password);
            crud.createSchema();
            crud.dropTable();
            crud.createTable();
            for (var dish : crud.getInitData())
                crud.insert(dish);

            var dish = crud.getInitData().stream().findFirst().get();
            dish.Title = "was updated";

            crud.update(dish);
            crud.drop(2);

            System.out.println("\nSELECTED ALL: ");
            for (var dishFromDb : crud.selectAll())
                System.out.println(
                    " ID: " + dishFromDb.Id +
                    "; TITLE: " + dishFromDb.Title +
                    "; PRICE: " + dishFromDb.Price +
                    "; WEIGHT: " + dishFromDb.Weight +
                    "; DISCOUNT: " + dishFromDb.Discount);

            var selectedDish = crud.selectById(3);
            if (selectedDish != null)
            {
                System.out.println("\nSELECTED: ");
                System.out.println(
                    " ID: " + selectedDish.Id +
                    "; TITLE: " + selectedDish.Title +
                    "; PRICE: " + selectedDish.Price +
                    "; WEIGHT: " + selectedDish.Weight +
                    "; DISCOUNT: " + selectedDish.Discount);
            }

        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }
    }
}
