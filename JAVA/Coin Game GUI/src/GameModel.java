/**
 *
 * @author Dipsa Khunt, 05/07/22
 */

/* GameModel class*/
public class GameModel {

    /* declaring the String varibales : output-guess message, computeroutput- result of computer head or tail */
    private String output,computeroutput;
    /* declaring int variables: computerRandom-random number, winCount-storing no of times user guess was correct, headcount-userclicked head, tailcount-userclicked tail */
    private int computerRandom,winCount=0,headcount=0,tailcount=0;

    /**
     * @return headcount
     * */
    public int getHeadcount() {
        return headcount;
    }

    /**
     *
     * @return tailcount
     */
    public int getTailcount() {
        return tailcount;
    }

    /**
     *
     * @return output
     */
    public String getOutput() { return output; }

    /**
     *
     * @return computeroutput
     */
    public String getComputeroutput(){
        return computeroutput;
    }

    /**
     *
     * @return getWinCount
     */
    public int getWinCount(){
        return winCount;
    }

    /* void head method - comparing computer value with user choose*/
    public void head(){
        computerRandom = (int)(Math.random()*2+1);

        /* increase head count*/
        headcount++;
        if(computerRandom == 1)
        {
            /* user guess is correct then increase win count*/
            winCount++;
            /* display guess is correct*/
            output="  Your guess is correct!  ";
            /* computer value - head*/
            computeroutput="Head";
        }
        else{
            /* guess is incorrect*/
            output="  Opps! Your guess is not correct  ";
            computeroutput="Tail";
        }
    }

    /* void tail method - comparing computer value with user choose*/
    public void tail(){
        computerRandom = (int)(Math.random()*2+1);

        /* increase tail count*/
        tailcount++;
        if(computerRandom == 2)
        {
            /* user guess is correct then increase win count*/
            winCount++;
            /* display guess is correct*/
            output="  Your guess is correct!  ";
            /* computer value - tail*/
            computeroutput="Tail";
        }
        else{
            /* guess is incorrect*/
            output="  Opps! Your guess is not correct  ";
            computeroutput="Head";
        }
    }

    /* void method- reset for setting all value to zero*/
    public void reset(){
        computeroutput="";
        headcount=0;
        tailcount=0;
        /*  setting display msg to choose your guess */
        output="  Choose Your Guess...  ";
        winCount=0;
    }
}
