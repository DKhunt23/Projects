/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 * */
/*Infantry class extend Orc*/
public class Infantry extends Orc{

    /*String variable to set infantry clan*/
    private String clanInfantry;

    /**
     *
     * @param ferocity
     * @param defense
     * @param magic
     * @param health
     * @param treasure
     * @param alive
     * @param clan
     */
    public Infantry(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan) {
        super(ferocity, defense, magic, health, treasure, alive, clan);
    }

    /**
     * default constructor
     */
    public Infantry(){
    }

    /**
     * Constructor with one parameter
     * @param clan
     */

    public Infantry(String clan){
        this.clanInfantry=clan;
    }

    /**
     * set method for clan affiliation
     * @param clan
     */

    public void setClan(String clan) {
        this.clanInfantry=clan;
    }

    /**
     *
     * @return toString
     */


    @Override
    public String toString() {
        return "\n"+"              Infantry: "+
                "ferocity=" + getFerocity()+
                ", defence=" + getDefense()+
                ", magic=" + getMagic()+
                ", health=" + getHealth()+
                ", treasure=" + getTreasure()+
                ", alive=" + isAlive()+
                ", clan='" + clanInfantry + '\'' +

                ' ';
    }



}
