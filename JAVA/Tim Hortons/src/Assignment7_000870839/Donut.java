package Assignment7_000870839;
/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
import java.util.Scanner;

/* Donut class extends TimsProduct Class implements Consumable interface */
public class Donut extends TimsProduct implements Consumable{

    /* description of product*/
    private String description;
    /* calorieCount of product*/
    private int calorieCount;


    /**
     *
     * @param name
     * @param description
     * @param cost
     * @param price
     * @param calories
     */
    private Donut(String name, String description, double cost, double price, int calories) {
        super(name, cost, price);
        this.description = description;
        this.calorieCount = calories;
    }


    /**
     *
     * @return new Donut object
     */
    public static Donut create(){

        Scanner sc = new Scanner(System.in);
        /* double variable for cost and price of donut*/
        double donutcost, donutprice;
        System.out.println("----Available Donut----\n1.Chocolate 2.Sugar Loop Donut 3. Double Chocolate");
        int choice = sc.nextInt();
        /* cashier input*/
        System.out.println("Enter the cost of Donut");
        donutcost = sc.nextDouble();
        System.out.println("Enter the price of Donut");
        donutprice = sc.nextDouble();

        /* switch case for different donut*/
        switch (choice) {
            case 1:
                return new Donut("Chocolate", "Good Sugar Intake", donutcost, donutprice, 350);
            case 2:
                return new Donut("Sugar Loop Donut", "Make Combo with Coffee", donutcost, donutprice, 350);
            case 3:
                return new Donut("Double Chocolate", "Most Favorite", donutcost, donutprice, 499);
            default:
                return new Donut("Chocolate", "Good Sugar Intake", donutcost, donutprice, 350);
        }
    }

    /**
     *
     * @return description
     */
    public String getDescription() {
        return description;
    }

    /**
     *
     * @return this.calorieCount
     */
    @Override
    public int getCalorieCount() {
        return this.calorieCount;
    }


    /**
     *
     * @return "Eat it!!!"
     */
    @Override
    public String getConsumptionMethod() {
        return "Eat it!!!";
    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "\nDonut: {" + super.toString() + ", "+getConsumptionMethod() + "}"+'\n'+"          {" + "description: " + getDescription()+ ", Calories = " + getCalorieCount() + "}";
    }
}
