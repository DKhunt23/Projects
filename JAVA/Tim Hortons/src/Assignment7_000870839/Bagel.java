package Assignment7_000870839;
/**
 *
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
import java.util.Scanner;

/* Bagel class extends TimsProduct Class implements Consumable interface */
public class Bagel extends TimsProduct implements Consumable{
    /* description  variable of String type for detail*/
    private String description;
    /* integer variable for calorie of bagel*/
    private int calorieCount;


    /**
     * private constructor
     * @param name
     * @param description
     * @param cost
     * @param price
     * @param calorieCount
     */
    private Bagel(String name, String description, double cost, double price, int calorieCount) {
        super(name, cost, price);
        this.description = description;
        this.calorieCount = calorieCount;
    }


    /**
     *
     * @return new Bagel object
     */
    public static Bagel create(){

        Scanner sc = new Scanner(System.in);
        System.out.println("----Available Bagel----\n1.Simple Butter 2. Herbal Cream Bagel 3.Everything Bagel");
        int choice = sc.nextInt();
        /* double variable for cost and price of bagel*/
        double bagelcost, bagelprice;
        System.out.println("Enter the cost of Bagel");
        bagelcost = sc.nextDouble();
        System.out.println("Enter the price of Bagel");
        bagelprice = sc.nextDouble();

        /* switch case for options of bagel*/
        switch (choice){
            case 1:
                return new Bagel("Simple Bagel","Toasted with Butter",bagelcost,bagelprice,523);
            case 2:
                return new Bagel("Herbal Cream Bagel ","Toasted with Herbal Garlic Cream",bagelcost,bagelprice,450);
            case 3:
                return new Bagel("Everything Bagel","Toasted with Butter & Herbal Garlic Cream ",bagelcost,bagelprice,580);
            default:
                return new Bagel("Bagel","Bagel which Customer Like",bagelcost,bagelprice,523);
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
     * @return calorieCount
     */
    @Override
    public int getCalorieCount() {
        return calorieCount;
    }

    /**
     *
     * @return "Eat It!!!"
     */
    @Override
    public String getConsumptionMethod() {
        return " Eat it!!!";
    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "\nBagel: {" + super.toString() + "," + getConsumptionMethod() + "}"+'\n'+ "         {" + description + getDescription()+ ", Calories = " + getCalorieCount() + "}";
    }
}
