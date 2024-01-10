import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;
/* Dipsa Khunt 000870839 */

/* Village class with all private variables*/
public class Village {
    private double x,y,size=0;
    private Color color;
    private String name;

    /* creating private object for 3 house*/
    private House house1,house2,house3;

    /* Village constructor with parameters
    * @param x,y coordinate color of house in village
    * */
    public Village( String name,double x,double y, Color color) {
        this.x = x;
        this.y = y;
        this.color = color;
        this.name = name;
        double sizeVariant = Math.random()*25;
        double sizeVariant1=Math.random()*15;

        /* using created object of house */
        house1=new House(x+20,y,70,color);
        house2=new House(x+100+sizeVariant,y+30,40,color);
        house3=new House(x+165+sizeVariant1,y+20,50,color);
        /* calculating size of village */
        size= house1.getSize()+ house2.getSize()+ house3.getSize()+sizeVariant+sizeVariant1;
    }

    public void draw(GraphicsContext gc){
        /*draw method for house with color passed */
        gc.setFill(color);
        house1.draw(gc);
        house2.draw(gc);
        house3.draw(gc);
        /* displaying the name of village, its size and population(with random function) */
        gc.strokeText(""+name+" (size "+(double)Math.round(size)+"m population " + Math.round(Math.random()*30+10)+")", x+20,y+85);



    }
}
