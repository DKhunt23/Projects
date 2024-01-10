/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 * */

/*Orc class extends Monsters class */
public class Orc extends Monsters{
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
    public Orc(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan) {
        super(ferocity, defense, magic, health, treasure, alive, clan);
    }

    /**
     * constructor
     * @param clan
     */
    public Orc(String clan){
        Monsters.clan=clan;
    }

    /**
     * Constructor
     */
    public Orc(){
    }
    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "Orc:- " + super.toString() +"";
    }
}
