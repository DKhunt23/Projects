package Assignment7_000870839;
/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
import java.util.Scanner;

/* Bottle class extends TimsProduct Class */
public class Bottle extends TimsProduct{

    /* double variable for productNo*/
    private int productNo;

    /**
     *
     * @param name
     * @param productNo
     * @param cost
     * @param price
     */
    public Bottle(String name, int productNo, double cost, double price) {
        super(name, cost, price);
        this.productNo = productNo;
    }

    /**
     *
     * @return new Bottle object
     */
    public static Bottle create(){

        Scanner sc = new Scanner(System.in);
        System.out.println("----Available Bottle----\n1.Glass 2.Copper 3.Stainless Steel");
        /* integer variable for choice of Bottle*/
        int choice = sc.nextInt();
        /* double variable for cost and price of bottle*/
        double bottlecost, bottleprice;
        /* Cashier input */
        System.out.println("Enter the cost of Bottle");
        bottlecost = sc.nextDouble();
        System.out.println("Enter the price of Bottle");
        bottleprice = sc.nextDouble();

        /* switch case for different bottle */
        switch (choice){

            case 1:
                return new Bottle("Glass", (int)Math.floor(Math.random()*10),bottlecost,bottleprice);
            case 2:
                return new Bottle("Copper",(int)Math.floor(Math.random()*10),bottlecost,bottleprice);
            case 3:
                return new Bottle("Stainless Steel",(int)Math.floor(Math.random()*10),bottlecost,bottleprice);
            default:
                return new Bottle("Normal",(int)Math.floor(Math.random()*10),bottlecost,bottleprice);
        }
    }


    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "\nBottle :{" + super.toString() + "}" +'\n'+"         {ProductNo: " + this.productNo + "}";
    }
}
