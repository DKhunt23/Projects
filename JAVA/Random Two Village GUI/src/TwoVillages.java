import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.stage.Stage;
import javafx.scene.paint.Color;

//package assignment3_000870839;

/**
 * This is my 3rd JAVA Assignment I have created 2 villages and a King's Castle
 * with object concept using constructor for initializing the values and methods for displaying on canvas graphics
 * @author Dipsa Khunt, 13 June 2022
 */
public class TwoVillages extends Application {

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
        Canvas canvas = new Canvas(900, 600); // Set canvas Size in Pixels
        stage.setTitle("FXGraphicsTemplate"); // Set window title
        root.getChildren().add(canvas);
        stage.setScene(scene);
        GraphicsContext gc = canvas.getGraphicsContext2D();

        /* set the background color to lightblue */
        gc.setFill(Color.LIGHTBLUE);
        gc.fillRect(0,0,900,600);

        /* 2 village objects are created and a object of house for king's castle is created*/
        Village v1 = new Village("Hamilton",100, 100,Color.BLUE);
        Village v2 = new Village("Brampton", 400, 400,Color.RED);
        House king = new House(750,200);
        /* draw method for all 3 object*/
        v1.draw(gc);
        v2.draw(gc);
        king.draw(gc);
        stage.show();
    }

    /**
     * The actual main method that launches the app.
     *
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);}
}