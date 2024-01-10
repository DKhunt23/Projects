import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
/* Dipsa Khunt 000870839 */

/* Window class with all private variables*/

public class Window {
    private double x,y,diameter;

    /* Window Constructor with parameters
    *@param x,y coordinate for window diameter of circle
     */
    public Window(double x, double y, double diameter){
        this.x=x;
        this.y=y;
        this.diameter=diameter;
    }

    /* draws window*/
    public void draw(GraphicsContext gc){
        gc.setFill(Color.WHITE);
        gc.fillOval(x, y, diameter, diameter );
    }
}
