import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
import javafx.scene.text.Font;
import javafx.stage.Stage;

import java.util.Scanner;

//package assignment1_000870839;

/**
 * This is my 1st JAVA Assignment and is about star constellation
 * User can choose number of stars, their position and name constellation
 * User stars will be connected with line forming constellation
 * @author Dipsa Khunt, 23 May 2022
 */
public class StarConstellation extends Application {

    /**
     * Start method (use this instead of main).
     *
     * @param stage The FX stage to draw on
     * @throws Exception
     */
    @Override
    public void start(Stage stage) throws Exception {
        Group root = new Group();
        Scene scene = new Scene(root);
        Canvas canvas = new Canvas(950, 750); // Set canvas Size in Pixels
        stage.setTitle("FXGraphicsTemplate"); // Set window title
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();


        // YOUR CODE HERE
        double backgroundX, backgroundY, width, height, count = 0, userValueX, userValueY, firstX = 0, firstY = 0, constantX = 0, constantY = 0;
        int stars;
        String name;
        gc.setFill(Color.BLACK);
        gc.fillRect(0, 0, 950, 750);


        /** Input - Asking user how many stars he want*/
        System.out.println("Enter the number of stars you want");
        Scanner sc = new Scanner(System.in);
        stars = sc.nextInt();


        /** Processing - for loop - ask for x and y coordinate of the no. of stars user said */
        for (int i = 1; i <= stars; i++) {
            System.out.println("Enter position of star: Xcoordinate any Ycoordinate");
            userValueX = sc.nextDouble();
            userValueY = sc.nextDouble();
            if (userValueX < 950 && userValueY < 750 && userValueX >=0 && userValueY >=0) {
                gc.setFill(Color.WHITE);
                gc.fillOval(userValueX, userValueY, 10, 10);

            }
            /** this block will run when input is negative or exceed canvas size*/
            else {
                System.out.println("position exceeds,please try again");
                i--;
            }
            /** This block stores the x and y coordinates of 1st user input value */
            if (i == 1) {
                firstX = userValueX;
                constantX = userValueX;
                firstY = userValueY;
                constantY = userValueY;
            }
            /** It will connect stars forming constellation */
            else if (i <= stars) {

                gc.setStroke(Color.WHITE);
                gc.strokeLine(firstX + 5, firstY + 5, userValueX + 5, userValueY + 5);
                firstX = userValueX;
                firstY = userValueY;


                /** this is for joining last star with first star */
                if (i == stars) {
                    gc.setStroke(Color.WHITE);
                    gc.strokeLine(constantX + 5, constantY + 5, userValueX + 5, userValueY + 5);
                }

            }

        }
        /** Background for constellation and developer name */
        gc.setFill(Color.GRAY);
        gc.fillRect(345, 680, 260, 60);
        /** Moon on the screen */
        gc.setFill(Color.WHITE);
        gc.fillOval(750,70,70,70);


        /** Ask name of constellation and Display it specific font and font size*/
        System.out.println("Enter the name of your constellation:");
        Scanner name1 = new Scanner(System.in);
        name = name1.nextLine();
        Font font1 = new Font("Verdana",20);
        gc.setFont(font1);
        gc.setStroke(Color.BLACK);
        gc.strokeText("Constellation of  " + name, 365, 700);
        gc.strokeText("Created by Dipsa Khunt", 350, 730);


        /** while loop for generating random stars on the canvas */
        while (count <= 400) {
            backgroundX = Math.random() * 950;
            backgroundY = Math.random() * 750;
            width = Math.random() * 3;
            height = Math.random() * 3;
            gc.setFill(Color.WHITE);
            gc.fillOval(backgroundX, backgroundY, width, height);
            count++;

        }
        /** Show on canvas */
        stage.show();
    }

    /**
     * The actual main method that launches the app.
     *
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);
    }
}
