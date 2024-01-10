import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

/* Dipsa Khunt 000870839 */

/* House class with all private variables*/

public class House {
    private double x,y,size;
    private int occupants;
    private Color color;
    /* private object of door and window */
    private Door gate;
    private Window window;


    /*House constructor with parameter
    * @param x,y are coordinate and color that is passed */
    public House(double x, double y, double size, Color color){
        this.x=x;
        this.y=y;
        this.size=size;
        this.color=color;

        /* using created object of door and window - door is half height of house*/
        gate= new Door(x+20,y+(size/2),size/2);
        window=new Window(x+6,y+6,10);
    }

    /* overloaded house constructor for king castle
    * @param x,y coordinate of king's castle
    *    * */
    public House(double x, double y){
        this.x=x;
        this.y=y;
        this.size=100;
        this.color=Color.ORANGE;
        /* gate and window for king */
        gate= new Door(x+30,y+(size/2),(size/2));
        window=new Window(x+6,y+6,size/4);

    }

    /* get method of Occupants */
    public int getOccupants(){
        return occupants;
    }
    /* set method for Occupants*/
    public void setOccupants(int n){
        this.occupants=occupants;
    }
    /* set method for Size*/
    public double getSize() {
        return size;
    }


    public void draw(GraphicsContext gc){
        gc.setFill(color);
        gc.fillRect(x, y, size, size );
        /*text for king's Castle*/
        gc.strokeText("King's Castle", 765,315);
        gate.draw(gc);
        window.draw(gc);
    }
}