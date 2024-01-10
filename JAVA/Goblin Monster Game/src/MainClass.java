/**
 * Assignment-6
 * This assignment is about three kind of Monsters: Orcs, Goblins and Manticores. This three inherited the Monsters Class.
 * Goblins have exact one goblin enemy. Orc class is inherited by Warlord and Infantry. Warlord has exact 5 Infantry. Every
 * Monsters have ferocity,defense and magic values between 0 and 20 in which ferocity increases for the monsters who loose,
 * defense value decrease, health value decrease and their whole treasure is taken by the winning monsters.
 *
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 * */

/** Main Method with objects */
public class MainClass {
    public static void main(String[] args) {

        System.out.println("------------Manticore-----------");
        System.out.println();
         /* manticore object*/
        Manticore m1=new Manticore("Manticore 1");
        m1.setFerocity(5);
        m1.setDefense(5);
        m1.setMagic(5);
        m1.setAlive(true);
        m1.setHealth(6);
        m1.setTreasure(7);
        System.out.println(m1);


        System.out.println("------Manticore-1 values after changing clan affiliation------");
        m1.changeClanAff("Manticore 2");
        System.out.println(m1);

        /* manticore object*/

        Manticore m2=new Manticore("Manticore 3");
        m2.setFerocity(9);
        m2.setDefense(4);
        m2.setMagic(2);
        m2.setAlive(true);
        m2.setHealth(19);
        m2.setTreasure(15);
        System.out.println(m2);
        System.out.println();
        System.out.println();

        /* Goblin object*/
        System.out.println("------------Goblin-----------");
        Goblin g1=new Goblin(9,9,9,15,15,true,"Goblin 1");
        System.out.println(g1);

        /* Goblin object*/
        Goblin g2=new Goblin(3,3,3,3,3,true,"Goblin 2");
        System.out.println(g2);
        System.out.println();
        System.out.println("------Setting Goblin-Goblin Enemy------");
        g1.setEnemy(g2);
        System.out.println(g1);
        System.out.println();
        System.out.println();

        /* Orc object*/
        System.out.println("------------Orc-----------");
        Orc o1=new Orc(5,6,7,8,10,false,"Orc 1");
        System.out.println(o1);
        Orc o2=new Orc(9,7,5,8,4,true,"Orc 2");
        System.out.println(o2);
        System.out.println();

        /* Warlord object*/

        System.out.println("------------Warlord-----------");
        Warlord w1=new Warlord(4,6,9,15,18.5,true,"Warlord 1",4);
        Infantry i1=new Infantry(5,6,7,8,9,true,"Infantry 1");
        w1.addInfantries(i1);
        Infantry i2=new Infantry(8,9,4,6,7,true,"Infantry 2");
        w1.addInfantries(i2);
        Infantry i3=new Infantry(8,9,4,6,7,true,"Infantry 3");
        w1.addInfantries(i3);
        Infantry i4=new Infantry(8,9,4,6,7,true,"Infantry 4");
        w1.addInfantries(i4);
        Infantry i5=new Infantry(8,9,4,6,7,true,"Infantry 5");
        w1.addInfantries(i5);
        System.out.println(w1);

        /* Warlord object*/
        Warlord w2=new Warlord(14,11,19,19,15.5,true,"Warlord 2",3);
        Infantry i6=new Infantry(15,16,17,18,19,true,"Infantry 6");
        w2.addInfantries(i6);
        Infantry i7=new Infantry(18,19,14,16,17,true,"Infantry 7");
        w2.addInfantries(i7);
        Infantry i8=new Infantry(13,10,12,15,7,true,"Infantry 8");
        w2.addInfantries(i8);
        Infantry i9=new Infantry(10,5,11,20,7,true,"Infantry 9");
        w2.addInfantries(i9);
        Infantry i10=new Infantry(12,17,4,19,3,true,"Infantry 10");
        w2.addInfantries(i10);
        System.out.println(w2);
        System.out.println();
        System.out.println("--------------------Output after attack-----------------------");

        /* Orc attack goblin */
        System.out.println("***Orc attack goblin***");
        o1.attack(g1);
        System.out.println(o1);
        System.out.println(g1);
        System.out.println();
        /* Manticore attack Orc */
        System.out.println("***Manticore attack Orc***");
        m1.attack(o2);
        System.out.println(m1);
        System.out.println(o2);
        System.out.println();
        /* Warlord attack goblin */
        System.out.println("****Warlord attack Goblin***");
        w1.attack(g1);
        System.out.println(w1);
        System.out.println(g1);
        System.out.println();

        System.out.println("--------------------Warlord call battle cry-----------------------");
        w1.healing();
        System.out.println(w1);


    }
}
