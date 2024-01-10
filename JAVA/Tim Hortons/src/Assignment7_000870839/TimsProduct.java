package Assignment7_000870839;

/**
 * Author: Dipsa Khunt, 000870839, Submission Date:10/8/22
 *
 * */
public class TimsProduct implements Commodity{

    /* String variable for customer name*/
    private String name;
    /* double variable for cost of product*/
    private double cost;
    /* double variable for price of product*/
    private double price;

    /**
     *
     * @param name
     * @param cost
     * @param price
     */
    public TimsProduct(String name, double cost, double price) {
        this.name = name;
        this.cost = cost;
        this.price = price;
    }

    /**
     *
     * @return name
     */
    public String getName() {
        return name;
    }

    /**
     *
     * @return this.cost
     */
    @Override
    public double getProductionCost() {
        return this.cost;
    }

    /**
     *
     * @return this.price
     */
    @Override
    public double getRetailPrice() {
        return this.price;
    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return getName() + ", Cost: " + this.cost + "$, Price: " + this.price + "$ ";
    }
}
