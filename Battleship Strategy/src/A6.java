import battleship.BattleShip2;

/**
 * @author Dipsa Khunt
 */

public class A6 {
    public static void main(String[] args) {
        final int NUMBEROFGAMES = 10000;
        System.out.println(BattleShip2.getVersion());
        BattleShip2 battleShip = new BattleShip2(NUMBEROFGAMES, new ExampleBot());
        int [] gameResults = battleShip.run();
        battleShip.reportResults();

    }
}
