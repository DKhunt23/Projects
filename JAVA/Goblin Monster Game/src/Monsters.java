/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 */

/*This is the Super Class-Monsters with methods implemented */
public class Monsters {
    /*integer variables and value ranging from 0 - 20 */
    private int ferocity ,defence,magic,health;

    /* double variable for the treasure of every monsters */
    private double treasure;

    /* boolean variable for whether the monster is alive or dead*/
    private boolean alive;

    /* String variable for the clan affiliation of monsters*/
    public static String clan;

    /* Constructor without parameters */
    public Monsters() {

    }

    /**
     * Constructor with parameters
     * @param ferocity
     * @param defense
     * @param magic
     * @param health
     * @param treasure
     * @param alive
     * @param clan
     */
    public Monsters(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan) {
        this.ferocity = ferocity;
        this.defence = defense;
        this.magic = magic;
        this.health = health;
        this.treasure = treasure;
        this.alive = alive;
        this.clan = clan;
    }

    /**
     * method to calculate battleScore
     * @return
     */
    public int getBattleScore(){

        return (int) Math.floor(ferocity+defence+magic/3);
    }

    /* void method to increase ferocity value*/
    public void increaseFerocity(){
        if(ferocity<20){
            ferocity+=1;
        }
        if(ferocity>=20)
        {
            ferocity=20;
        }
    }

    /* void method to decrease ferocity value */
    public void decreaseFerocity(){
        if(ferocity< 20){
            ferocity-=1;
        }
        if(ferocity <=0){
            ferocity = 0;
        }
    }

    /* void method to increase magic value*/
    public void increaseMagic(){
        if(magic<20){
            magic+=1;
        }
    }
    /* void method to decrease magic value */
    public void decreaseMagic(){
        if(magic < 20){
            magic-=1;
        }
    }
    /* void method to increase treasure value*/
    public void increaseTreasure(double value){
            treasure+=value;
    }
    /* void method to decrease treasure value */
    public void decreaseTreasure(double value){
         if(treasure>value){
            treasure-=value;
         }else {
             treasure=0;
         }
    }
    /* void method to increase defense value*/
    public void increaseDefence(){
        if(defence<20){
            defence+=1;
        }
    }
    /* void method to decrease defense value */
    public void decreaseDefence(){
        if(defence< 20){
            defence-=1;
        }
    }
    /* void method to increase health value*/
    public void increaseHealth(int value){
        if(health<20){
            health+=value;
        }if (health>20) {
            health=20;
        }
    }
    /* void method to decrease health value */
    public void decreaseHealth(int value){
        if(health< 20 && (health-value)>0){
            health-=value;
        }else {
            health=0;
            setAlive(false);
        }
    }

    /**
     * get method for ferocity
     * @return ferocity
     */
    public int getFerocity() {
        return ferocity;
    }

    /**
     * set method for ferocity
     * @param ferocity
     */
    public void setFerocity(int ferocity) {
        this.ferocity = ferocity;
    }

    /**
     * get method for defense
     * @return defense
     */
    public int getDefense() {
        return defence;
    }

    /**
     * set method for defense
     * @param defense
     */
    public void setDefense(int defense) {
        this.defence = defense;
    }

    /**
     * get method for magic
     * @return magic
     */
    public int getMagic() {
        return magic;
    }

    /**
     * set method for magic
     * @param magic
     */
    public void setMagic(int magic) {
        this.magic = magic;
    }

    /**
     * get method for health
     * @return health
     */
    public int getHealth() {
        return health;
    }

    /**
     * set method for health
     * @param health
     */
    public void setHealth(int health) {
        this.health = health;
    }

    /**
     * get method for treasure
     * @return treasure
     */
    public double getTreasure() {
        return treasure;
    }

    /**
     * set method for treasure
     * @param treasure
     */
    public void setTreasure(double treasure) {
        this.treasure = treasure;
    }

    /**
     * boolean method for whether the monster is dead or alive
     * @return alive
     */
    public boolean isAlive() {
        return alive;
    }

    /**
     * set method for alive
     * @param alive
     */
    public void setAlive(boolean alive) {
        this.alive = alive;
    }

    /**
     * get method for clan affiliation
     * @return clan
     */
    public static String getClan() {
        return clan;
    }

    /**
     * attack method
     * @param m
     */
    public void attack(Monsters m) {
        /* condition to check if both monsters are alive */
        if (m.isAlive() && this.isAlive())
        {
            /* 1st monster battlescore is greater than the other */
            if(this.getBattleScore()>m.getBattleScore())
            {
                /* decrease health of loosing monsters by the difference of battlescore of winner minus battlescore of loosing monoster*/
                m.decreaseHealth(this.getBattleScore()-m.getBattleScore());
                /* increase the treasure of winning monster by value of treasure of loosing monster*/
                this.increaseTreasure(m.getTreasure());
                /* decrease the treasure of loosing monster making it zero*/
                m.decreaseTreasure(m.getTreasure());
                /* decrease the defense of loosing monster*/
                m.decreaseDefence();
                /* increase the defense of winning monster*/
                this.increaseDefence();
                /* increase the ferocity of loosing monster*/
                m.increaseFerocity();
                /* decrease the ferocity of winning monster*/
                this.decreaseFerocity();
                /* if the difference of the battlescore is greater than 3 than */
                if((this.getBattleScore()-m.getBattleScore())>3) {
                    /*increase magic value of winning monster */
                    this.increaseMagic();
                    /* decrease magic value of loosing monster*/
                    m.decreaseMagic();
                }
            }
            else{

                this.decreaseHealth(m.getBattleScore()-this.getBattleScore());
                m.increaseTreasure(this.getTreasure());
                this.decreaseTreasure(this.getTreasure());
                this.decreaseDefence();
                m.increaseDefence();
                this.increaseFerocity();
                m.decreaseFerocity();
                if((m.getBattleScore()-this.getBattleScore())>3){
                    m.increaseMagic();
                    this.decreaseMagic();
                }
            }
        }
        /* if any one monster is dead then print this  */
        else{
            System.out.println("Monster cannot fight with Dead monster");
        }
    }


    /**
     *
     * @return toString
     */

    /* toString to print output*/
    @Override
    public String toString() {
        return " " +
                "ferocity=" + ferocity +
                ", defence=" + defence +
                ", magic=" + magic +
                ", health=" + health +
                ", treasure=" + treasure +
                ", alive=" + alive +
                ", clan='" + clan + '\'' +

                ' ';
    }
}
