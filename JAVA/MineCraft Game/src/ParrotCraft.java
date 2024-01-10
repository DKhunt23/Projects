import java.util.Scanner;
/**
 * This is the Main Class - ParrotCraft.
 * This call methods from Parrot class
 * switch case in do while loop is used to ask user for what they want to do with parrot.
 * 3 objects of Parrot class are created with private parrotName and amount of seeds
 * based on the user choice different objects will be called
 *
 * @ Dipsa Khunt 000870839
 * */
public class ParrotCraft {
    public static void main(String[] args) {

        /** 3 objects of Parrot Class */
        Parrot p1 = new Parrot("Julius",0.1);
        Parrot p2 = new Parrot("Nancy",0.6);
        Parrot p3 = new Parrot("Johnette",1.0);

        /** choice variable is for user choice and which_parrot is for which parrot they want to do with */
        int choice,which_parrot;


        do {
            /** Display the toString */
            System.out.println("1. "+p1);
            System.out.println("2. "+p2);
            System.out.println("3. "+p3);
            System.out.println();
            System.out.println("1.Feed 2.Command 3.Play 4.Hit 5.Quit");
            Scanner sc = new Scanner(System.in);
            choice = sc.nextInt();

            /** if choice is 5 then loop will be terminated .This condition is here because do while loop is used which is exit control loop */
            if(choice == 5)
            {
                System.out.println("Thanks for playing!");
                break;
            }
            System.out.println("Which Parrot");
            which_parrot = sc.nextInt();


            switch (choice) {
                case 1:
                    /** if statement will work according to user input for which_parrot*/
                    if (which_parrot == 1) {
                        p1.feed();
                    } else if (which_parrot == 2) {
                        p2.feed();
                    } else if (which_parrot == 3) {
                        p3.feed();
                    } else {
                        System.out.println("Wrong input");

                    }

                    break;

                case 2:
                    if (which_parrot == 1) {
                        p1.command();
                    } else if (which_parrot == 2) {
                        p2.command();
                    } else if (which_parrot == 3) {
                        p3.command();
                    } else {
                        System.out.println("Wrong input");

                    }
                    break;

                case 3:
                    /** Asking user for another parrot as two parrot will play */
                    System.out.println("Which another parrot you want to play");
                    Scanner gc = new Scanner(System.in);
                    int playwith =gc.nextInt();
                    if (which_parrot == 1) {
                        if(playwith==2){
                            System.out.println( p1.play(p2));
                        }
                        if(playwith==3){
                            System.out.println(p1.play(p3));
                        }

                    } else if (which_parrot == 2){
                            if(playwith==1){
                                System.out.println(p2.play(p1));
                            }
                            if(playwith==3){
                                System.out.println(p2.play(p3));
                            }


                    } else if (which_parrot == 3) {
                        if(playwith==1){
                            System.out.println(p3.play(p1));
                        }
                        if(playwith==2){
                            System.out.println(p3.play(p2));
                        }

                    } else {
                        System.out.println("Wrong input");
                    }

                    break;

                case 4:
                    if (which_parrot == 1) {
                        p1.hit();
                    } else if (which_parrot == 2) {
                        p2.hit();
                    } else if (which_parrot == 3) {
                        p3.hit();
                    } else {
                        System.out.println("Wrong input");

                    }
                    break;

            }

        }while(choice != 5); /** loop will run untill choice will not be 5 */
    }
}
