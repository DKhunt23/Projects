/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 */

/* Manticore class extend Monsters*/
public class Manticore extends Monsters{

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
    public Manticore(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan) {
        super(ferocity, defense, magic, health, treasure, alive, clan);
    }

    /**
     * Constructor with one parameter
     * @param clan
     */
    public Manticore(String clan){
        Monsters.clan=clan;
    }


    /**
     * get method to calculate battlescore
     * @return battleScore
     */
    @Override
    public int getBattleScore(){
        return ((int) Math.floor((this.getFerocity()+this.getDefense()+this.getMagic()/3) *1.5));
    }

    /**
     * method to change clan Affiliation
     * @param clan
     */
    public void changeClanAff(String clan){
        Monsters.clan=clan;

    }

    /**
     * Attack method to override the monsters class method as battlescore is different for Manticore
     * @param m
     */
    public void attack(Monsters m) {
        if (m.isAlive()) {
            if(this.getBattleScore()>m.getBattleScore()){
                m.decreaseHealth(this.getBattleScore()-m.getBattleScore());
                this.increaseTreasure(m.getTreasure());
                m.decreaseTreasure(m.getTreasure());
                m.decreaseDefence();
                this.increaseDefence();
                m.increaseFerocity();
                this.decreaseFerocity();
                if((this.getBattleScore()-m.getBattleScore())>3){
                    this.increaseMagic();
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
    }

    /**
     *
     * @return toString
     */

    @Override
    public String toString() {
        return "Manticore :- " + super.toString() +"";
    }
}

