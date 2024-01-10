/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 */

/* Goblin class extend Monsters Class*/
public class Goblin extends Monsters{
    /* Declaring the object of Goblin*/
    private  Goblin enemy;

    /**
     * Constructor with parameter
     * @param ferocity
     * @param defense
     * @param magic
     * @param health
     * @param treasure
     * @param alive
     * @param clan
     */
    public Goblin(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan) {
        super(ferocity, defense, magic, health, treasure, alive, clan);
    }

    /**
     *
     * @param clan
     */
     public Goblin(String clan)
     {
         Monsters.clan=clan;
     }
    /**
     * void method to set enemy
     * @param enemies
     */
    public  void setEnemy(Goblin enemies) {
        enemy = enemies;

    }

    /**
     * get method of enemy
     * @return enemy
     */
    public  Goblin getEnemy() {
        return enemy;
    }

    /**
     *
     * @return toString
     */

    /* override toString*/
    @Override
    public String toString() {
        return "Goblin:- " + super.toString()+
                "\n" + "    enemy=" + enemy +
                ' ';
    }
}
