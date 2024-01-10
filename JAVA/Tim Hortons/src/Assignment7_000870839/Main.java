package Assignment7_000870839;

/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * This the main class of Assignment-7. Based on the UML provided there are 6 class other than main class and 2 interface.
 * */


public class Main {

    /**
     *
     * @param args
     */
    public static void main(String[] args) {

        TimsOrder timsOrder = TimsOrder.create();
        System.out.println(timsOrder);
        System.out.printf("Total Price: %.2f $\n", timsOrder.getAmountDue());
    }
}
