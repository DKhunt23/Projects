package Assignment7_000870839;
/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
import java.util.Scanner;

public class TimsOrder {

    /* integer variable for order size*/
    private int size;
    /* name of customer*/
    private String name;

    /* TimsProduct array*/
    private static TimsProduct[] product;

    /**
     *
     * @param size
     * @param name
     */
    private TimsOrder(int size, String name) {
        this.size = size;
        this.name = name;
        product = new TimsProduct[size];
    }


    /**
     *
     * @return timsOrder
     */
    public static TimsOrder create(){

        Scanner sc = new Scanner(System.in);
        System.out.println("Enter Customer Name: ");
        String name = sc.nextLine();
        System.out.println("How many product customer want to order?");
        /* integer variable for total no of product*/
        int totalproduct = sc.nextInt();
        /*  object of TimsOrder*/
        TimsOrder timsOrder = new TimsOrder(totalproduct, name);

        /* for loop for how many product customer want to order */
        for (int i = 0; i< product.length;i++){
            System.out.println("\n----Select Customer's Product----\n1-Donut 2-Mug 3-Bagel 4-Bottle ");

            /* choice for product*/
            int customerchoice = sc.nextInt();

            /* switch case calling create method of Donut,Mug,Bagel and Bottle*/
            switch (customerchoice){
                case 1:
                    product[i] = Donut.create();
                    break;
                case 2:
                    product[i] = Mug.create();
                    break;
                case 3:
                    product[i] = Bagel.create();
                    break;
                case 4:
                    product[i] = Bottle.create();
                    break;
            }

        }

        return timsOrder;
    }


    /**
     *
     * @return sum
     */
    public double getAmountDue(){

        int i = 0;
        double sum = 0;
        /* while loop for calculating total amount*/
        while (i< size){
            sum = sum + product[i].getRetailPrice();
            i++;
        }
        return sum;
    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        String summary = "\n\nOrder Detail\n**********************\nCustomer Name: " + name + "\n";

        int j = 0;

        /* while loop for summary of order*/
        while (j< size){
            summary += product[j].toString() +"\n";
            j++;
        }
        return summary;
    }
}
