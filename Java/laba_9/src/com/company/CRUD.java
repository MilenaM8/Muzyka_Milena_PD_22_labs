package com.company;

import com.company.Dish;

import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class CRUD {
    Statement statement;
    public void connect(String url, String username, String password) throws SQLException {
        var connection = DriverManager.getConnection(url, username, password);
        statement = connection.createStatement();
    }

    public void dropTable() throws SQLException {
        var query = "DROP TABLE IF EXISTS dishes CASCADE";
        statement.execute(query);
    }

    public void insert(Dish dish) throws SQLException {
        var query = "INSERT dishes(Id, Title, Price, Weight, Discount) VALUES (" + dish.Id + ", " + "\"" + dish.Title + "\"" + ", " + dish.Price + ", " + dish.Weight + ", " + dish.Discount + ")";
        statement.executeUpdate(query);
    }

    public void createSchema() throws SQLException {
        var query = "CREATE SCHEMA IF NOT EXISTS `dishes`";
        statement.execute(query);
    }

    public void createTable() throws SQLException {
        var query = "CREATE TABLE IF NOT EXISTS `dishes`.`dishes` (\n" +
                "  `Id` INT NOT NULL,\n" +
                "  `Title` VARCHAR(45) NULL,\n" +
                "  `Price` DECIMAL(65) NULL,\n" +
                "  `Weight` DECIMAL(65) NULL,\n" +
                "  `Discount` DECIMAL(65) NULL,\n" +
                "  PRIMARY KEY (`Id`));\n";
        statement.execute(query);
    }

    public void update(Dish dish) throws SQLException {
        var query = "UPDATE Dishes " +
                "SET Title =" + "\"" + dish.Title + "\"" + ", Price=" + dish.Price + ", Weight=" + dish.Weight + ", Discount=" + dish.Discount + " " +
                "WHERE Id = " + dish.Id;
        statement.executeUpdate(query);
    }

    public void drop(int Id) throws SQLException {
        var query = "DELETE FROM Dishes " +
                "WHERE Id = "+ Id;
        statement.executeUpdate(query);
    }

    public ArrayList<Dish> selectAll() throws SQLException {
        var query = "SELECT * " +
                "FROM Dishes";
        var resultSet = statement.executeQuery(query);
        var dishes = new ArrayList<Dish>();
        while(resultSet.next()){
            var dish = new Dish();
            dish.Id = resultSet.getInt(1);
            dish.Title = resultSet.getString(2);
            dish.Price = resultSet.getDouble(3);
            dish.Weight = resultSet.getDouble(4);
            dish.Discount = resultSet.getDouble(5);
            dishes.add(dish);
        }
        return dishes;
    }

    public Dish selectById(int id) throws SQLException {
        var query = "SELECT * " +
                "FROM Dishes " +
                "WHERE Id = " + id;
        var resultSet = statement.executeQuery(query);
        if (resultSet.next()){
            var dish = new Dish();
            dish.Id = resultSet.getInt(1);
            dish.Title = resultSet.getString(2);
            dish.Price = resultSet.getDouble(3);
            dish.Weight = resultSet.getDouble(4);
            dish.Discount = resultSet.getDouble(5);
            return dish;
        }
        return null;
    }

    public ArrayList<Dish> getInitData(){
        var dishes = new ArrayList<Dish>();

        var dish1 = new Dish();
        var dish2 = new Dish();
        var dish3 = new Dish();
        var dish4 = new Dish();

        dish1.Id = 1;
        dish1.Title = "Dish one";
        dish1.Price = 331.1;
        dish1.Weight = 321.1;
        dish1.Discount = 20.0;

        dish2.Id = 2;
        dish2.Title = "Dish two";
        dish2.Price = 331.1;
        dish2.Weight = 321.1;
        dish2.Discount = 15.0;

        dish3.Id = 3;
        dish3.Title = "Dish three";
        dish3.Price = 331.1;
        dish3.Weight = 321.1;
        dish3.Discount = 10.0;

        dish4.Id = 4;
        dish4.Title = "Dish four";
        dish4.Price = 331.1;
        dish4.Weight = 321.1;
        dish4.Discount = 0.0;

        dishes.add(dish1);
        dishes.add(dish2);
        dishes.add(dish3);
        dishes.add(dish4);

        return dishes;
    }
}
