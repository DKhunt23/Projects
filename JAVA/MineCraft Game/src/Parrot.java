
import java.util.Scanner;

/**
 * This is Parrot Class.
 * all the methods as implemented here
 *
 * @ Dipsa Khunt 000870839
 */
public class Parrot {
    private String parrotName, state, character, life, food;
    private int heart;
    private double seeds;
    String state2;
    public double amount;

    Scanner pc = new Scanner(System.in);

    /** Construtor is used for setting default values */
    public Parrot(String parrotName,double seeds ) {
        this.parrotName = parrotName;
        this.seeds=seeds;
        this.state = "fly";
        this.character = "Untamed";
        this.life = "alive";
        this.heart=3;
    }

    /** feed method will allow user to feed a parrot with seed only if cookie is feed it will be dead */
    void feed() {

        /** this condtion is in every method because if parrot is dead user cannot do anything with that parrot */
        if (life.equals("Dead")) {
            System.out.println("Parrot is Dead");
        } else {
            System.out.println("Seed or Cookie");
            Scanner sc1 = new Scanner(System.in);
            food = sc1.nextLine();
            if (food.equals("seed")) {
                System.out.println("How much");
                amount = pc.nextDouble();

                /** if amount of seed will be zero or less than that error msg will display */
                if (amount <= 0) {
                    System.out.println("Error! you entered negative value. Please, Try again");
                } else {

                    /** This condition will display if parrot is tamed or untamed */
                    if (((0.2 * amount >= Math.random()))) {
                        character = "Tamed";
                        seeds = seeds + amount;
                        System.out.println("You tamed "+parrotName);
                        if (heart == 2 || heart == 1) {
                            heart += 1;

                        }
                    }
                }
            }
            else if (food.equals("cookie")) {
                System.out.println("Oh You made Parrot Dead");
                heart = 0;
                life = "Dead";

            }
            /** user enter anything other than seed or cookie error msg will pop */
            else{
                System.out.println("You entered wrong food. Please feed with seed or cookie.");
            }
        }
    }

    /** command method is for user to command parrot to fly or stay */
    void command() {

        if (life.equals("Dead")) {
            System.out.println("Parrot is Dead");
        } else {
            /** user can only command a tamed parrot so 1st condtion will check its character */
            if (character.equals("Tamed")) {
                System.out.println("Stay or Fly: ");
                Scanner d = new Scanner(System.in);
                state2 = d.nextLine();

                if ((state.equals("stay") || (state.equals("fly")))){
                    state=state2;
                }
                else {
                    System.out.println("You entered wrong state.Please, try again with stay or fly");
                }

            }
            /** parrot is untamed so user cannot command it */
            else {
                state = "fly";
                System.out.println("Parrot is untamed so You cannot command parrot");
            }
        }

    }

    /** play method is string with parameter as whole class */
    public String play(Parrot parrot) {

        /** if both parrot are tamed then they will become untamed */
        if (parrot.character.equals("Tamed") && character.equals("Tamed")) {
            parrot.character = "Untamed";
            parrot.state = "fly";
            character = "Untamed";
            state = "fly";
            return (parrot.parrotName + " and " + parrotName + " is Untamed");
        }
        /** if both are untamed this will be displayed */
        else if (parrot.character.equals("Untamed") && character.equals("Untamed")) {
            return ("Both are Untamed");
        }
        /** if one of the parrot is untamed*/
        else {

            return "one of them are untamed";
        }
    }


    /**toString  for displaying whole thing in string*/
    @Override
    public String toString() {
        return "["
                + parrotName +
                " : "  + character  +
                ", "   + state  +
                ", "   + life    +
                ", "   + heart  +
                " hearts, " + seeds +
                " kg seeds]";
    }

    /** hit method will be called when user want to hit a parrot */
    void hit() {
        if (life.equals("Dead")) {
            System.out.println("Parrot is Dead.");
        }
        /** when heart value is 1 ,2 or 3  it will display msg decresing heat value and making it untamed if it is tamed*/
        else {
            if ((heart > 0) && (heart <= 3)) {
                heart -= 1;
                System.out.println("Ouch! You hit me.");
                character = "Untamed";
                state = "fly";
            }
            /** user cannot hit dead parrot */
            if (heart == 0) {
                life = "Dead";
            }

        }
    }
}

