import java.util.Arrays;

/**
 * Date created - July 16 2022
 * @author1 Pal Patel, 000865048
 * @author2 Dipsa Khunt, 000870839
 * */

/* Warload class extends Orc method*/
public class Warlord extends Orc {
    /* int variable for leadership rating, current variable for creating infantries*/
    private int leadership,current=0;
    /* Array of infanrty*/
    public Infantry[] infantries=new Infantry[5];


    /**
     *
     * @param ferocity
     * @param defense
     * @param magic
     * @param health
     * @param treasure
     * @param alive
     * @param clan
     * @param leadership
     */
    public Warlord(int ferocity, int defense, int magic, int health, double treasure, boolean alive, String clan, int leadership) {
        super(ferocity, defense, magic, health, treasure, alive, clan);
        this.leadership = leadership;
        /* for loop to create object of infantry*/
        for (int i =0; i<5;i++){
            infantries[i] = new Infantry();
        }
    }

    /**
     * attack method to override monsters class method as battlescore is different for warlord
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
                    this.increaseLeadership();
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
                this.decreaseLeadership();
                if((m.getBattleScore()-this.getBattleScore())>3){
                    m.increaseMagic();
                    this.decreaseMagic();
                }

            }
        }
    }

    /**
     * void method to infantries to array
     * @param newInfantry
     */
    public void addInfantries(Infantry newInfantry){
        infantries[current].setFerocity(newInfantry.getFerocity());
        infantries[current].setDefense(newInfantry.getDefense());
        infantries[current].setMagic(newInfantry.getMagic());
        infantries[current].setHealth(newInfantry.getHealth());
        infantries[current].setTreasure(newInfantry.getTreasure());
        infantries[current].setAlive(newInfantry.isAlive());
        infantries[current].setClan(newInfantry.getClan());
        current++;

    }

    /**
     * void method to increase leadership value
     */
    public void increaseLeadership(){
        if(leadership>=0 && leadership<=5){
        leadership+=1;
        }if(leadership>5)
        {
            leadership =5;
        }
    }


    /**
     * void method to decrease leadership value
     */
    public void decreaseLeadership(){
        if(leadership>=0 && leadership<=5){
            leadership-=1;
        }
        if(leadership <0)
        {
            leadership=0;
        }
    }

    /**
     * get method to calculate battlescore
     * @return battlescore multipied by 1.5
     */
    @Override
    public int getBattleScore(){
        return ((int) Math.floor((this.getFerocity()+this.getDefense()+this.getMagic()/3) *1.5));
    }

    /**
     * void method to increase treasure value
     * @param value
     */
    @Override
    public void increaseTreasure(double value){
        this.setTreasure(getTreasure()+value);
        if (value>=10){
            this.leadership+=(int)Math.floor(value/10);
        }

    }

    /**
     * healing method to boost the health of all infantry
     */
    public void healing(){
        int healthboost =5*this.leadership;
        for(int i =0;i< infantries.length;i++)
        {
            if(this.infantries[i].isAlive())
            {
                this.infantries[i].increaseHealth(healthboost);
            }
        }

    }

    /**
     *
     * @return toString
     */
    @Override
    public String toString() {
        return "Warlord:- " +
                " "+super.toString()+ " leadership=" + leadership +
                "\n"+"Warlord's infantries=" + Arrays.toString(infantries) +
                ' ';
    }
}
