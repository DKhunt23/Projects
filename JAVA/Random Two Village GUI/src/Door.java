import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
/* Dipsa Khunt 000870839 */

/* Door class with all private variables*/

public class Door {
    private double x,y,height;

    /* Door Constructor with parameters
     *@param x,y coordinate for window height of door
     */
    public Door(double x, double y, double height){
        this.x=x;
        this.y=y;
        this.height=height;
    }

    /*draws door*/
    public void draw(GraphicsContext gc){
        gc.setFill(Color.WHITE);
        gc.fillRect(x, y, height/2, height );
    }
}