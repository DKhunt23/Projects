package Assignment7_000870839;
/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
import java.awt.Color;
import java.util.Scanner;

/* Mug class extends TimsProduct Class */

public class Mug extends TimsProduct{

    /* Color variable for color of mug*/
    private Color color;

    /**
     *
     * @param name
     * @param color
     * @param cost
     * @param price
     */
    private Mug(String name,Color color, double cost, double price) {
        super(name, cost, price);
        this.color = color;
    }

    /**
     *
     * @return new Mug object
     */
    public static Mug create(){
        Scanner sc = new Scanner(System.in);
        /* double variable for cost and price of mug*/
        double mugcost, mugprice;
        /* Color variable with initialization */
        Color color = Color.RED;
        System.out.println("----Available Mug----\nCeramic Coffee Mug");

        /* for cashier input */
        System.out.println("Enter the cost of Mug");
        mugcost = sc.nextDouble();
        System.out.println("Enter the price of Mug");
        mugprice = sc.nextDouble();
        System.out.println("Enter the Color of Mug");
        System.out.println("1. Black 2. Blue 3. White 4. Red");
        int choiceColor = sc.nextInt();

        /* switch case for color selection of mug*/
        switch (choiceColor) {
            case 1:
                color = Color.BLACK;
                break;
            case 2:
                color = Color.BLUE;
                break;
            case 3:
                color = Color.WHITE;
                break;
            case 4:
                color = Color.RED;
                break;
            default:
                color = Color.RED;
                break;
        }

        return new Mug("Ceramic Coffee Mug", color, mugcost, mugprice);
    }

    /**
     *
     * @return color
     */
    public Color getColor(){
        return color;
    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "\nMug : {" + super.toString() + "}"+'\n'+"          {Color: " + getColor() + "}";
    }
}
