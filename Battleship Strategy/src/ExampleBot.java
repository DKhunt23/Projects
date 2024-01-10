
import battleship.*;
import java.awt.Point;
import java.util.*;

/**
 * Assignment - 6 : Battleship Game - Random shooting from parity points(Hunt)
 *                                    When found a Hit(Sunk) adjacent points are added to a queue
 *                                    after the second hit, checking is the ship hitAdjacentPoint or horizontal and depending on that points are added to the queue
 *                                    As the ship is sunken queue is clear while making all the points as miss.
 *
 * B A T T L E S H I P - Version 2.01 [December 22,2021]
 * ------------------------------------------------------------
 * BattleShip 2 - Results for ExampleBot
 * Author : Dipsa Khunt
 * ------------------------------------------------------------
 * The Average Score over 10000 games    = 99.12
 * Time required to complete 10000 games = 1219 ms
 * ------------------------------------------------------------
 * @author Dipsa Khunt
 */

public class ExampleBot implements BattleShipBot {
    private int gameSize; //game grid value
    private BattleShip2 battleShip; //Api
    private Random random;

//    private  Point[] parityPoints; //parity points
    private ArrayList<Point> parityPoints;

    private int[] ships; // the ship sizes
    
    //directions for adjacent points
    private static final int[][] DIRECTIONS = {
                    {-1, 0},
            {0, -1},           {0, 1},
                    {1, 0}
    };

    private CellState[][] boardStatus; // a status of Point shooted on board

    private ArrayList<Point> shootedPoint; //store the shooted points

    private  ArrayList<Point> hitPoint; //store hits
    private Queue<Point> hitAdjacentPoint; //points around hit
    private int sunkShipsCount; // tracking number of ships sunken

    /**
     * Constructor keeps a copy of the BattleShip instance
     * Create instances of any Data Structures and initialize any variables here
     * @param b previously created battleship instance - should be a new game
     */

    @Override
    public void initialize(BattleShip2 b) {
        //initializing
        battleShip = b;
        gameSize = b.BOARD_SIZE;
        sunkShipsCount = b.numberOfShipsSunk();
        shootedPoint = new ArrayList<>();
        hitPoint = new ArrayList<>();
        hitAdjacentPoint = new LinkedList<>();
        parityPoints = new ArrayList<>();
        random = new Random();
        ships = b.getShipSizes(); // get the available ship sizes
        boardStatus = new CellState[gameSize][gameSize]; // initializing boardStatus array
        int count = 0; //parity indexing


        for(int i=0; i<gameSize; i++)
        {
            for(int j=0; j<gameSize; j++)
            {
                //assigning boardstatus as empty
                boardStatus[i][j] = CellState.Empty;
                //checking for parity points
                if (((i + j) % 2) == 0 && boardStatus[i][j] == CellState.Empty) {

                    parityPoints.add(new Point(i, j));
                    count++;
                }
            }
        }
//        parityPoints= Arrays.copyOf(parityPoints,count); //truncating the array
    }

    /**
     * Creates a random shot from parity points and calls the battleship shoot method
     * Hit then calls sunkShipNow method to sunk the ship 
     * Miss then change the boardstatus to miss
     * The BattleShip API will call code until all ships are sunk
     */
    @Override
    public void fireShot() {
        //shoot if all ships are not sunken
        if(!battleShip.allSunk()) {
            Point point = bestShoot(); //selecting point to shot
            boolean hit = battleShip.shoot(point); //checking hit or not
            shootedPoint.add(point); // adding to shooted points

            if (hit == true) {
                hitPoint.add(point); //add to hitpoint arraylist
                boardStatus[point.x][point.y] = CellState.Hit; //change board status to HIT - 'X'
                sunkShipNow(point);  //call method to sunk the ship
            }
            else {
                boardStatus[point.x][point.y] = CellState.Miss; //change board status to 'MISS' - O
            }
        }

//           System.out.print("\n.  ");
//
//        int y;
//        for (y = 0; y < this.gameSize; ++y) {
//            System.out.printf("%2d ", y);
//        }
//
//        for (y = 0; y < this.gameSize; ++y) {
//            System.out.printf("\n%2d ", y);
//
//            for (int x = 0; x < this.gameSize; ++x) {
//                System.out.printf(" %s ", this.boardStatus[x][y]);
//            }
//        }
//        System.out.println();
    }
    /**
     * Randomly selecting the shooting point from parity points
     * @return random point
     */
    private  Point bestShoot()
    {
        int bestPointParity=0;
        for(int i=0;i<parityPoints.size();i++)
        {
            //randomly selecting
            bestPointParity= random.nextInt(parityPoints.size());

            int a = parityPoints.get(bestPointParity).x;
            int b = parityPoints.get(bestPointParity).y;
            //checking if point's adjacent sides are already not empty/shooted skip that point
            if(!goodPoint(a,b))
            {
                shootedPoint.add(parityPoints.get(bestPointParity));
            }
            //checking if point existed in shooted points
            if(!shootedPoint.contains(parityPoints.get(bestPointParity)))
            {
                break;
            }
        }
        return  parityPoints.get(bestPointParity);
    }

    /**
     *
     * @param x - x coordinate of point
     * @param y - y coordinate of point
     * @return false- all adjacent points are hit/miss  /true - even when one adjacent is empty
     */
    private boolean goodPoint(int x,  int y)
    {
        //looping through directions
        for (int[] dir : DIRECTIONS) {
            int newX = x + dir[0];
            int newY = y + dir[1];

            if (isValidPoint(newX, newY)) {
                if(!(boardStatus[newX][newY] != CellState.Empty)){
                    return true;
                }
            }
        }
        return false;
    }


    /**
     * This method finds the adjacent points to Hit and sunk the ship
     * After 2nd Hit adds the adjacent in vertical/horizontal directions
     * @param point Hit point 
     */
    private void sunkShipNow(Point point)
    {
        int x = point.x;
        int y = point.y;

        // Add adjacent points (up, down, left, right) to the hitAdjacentPoints is valid 
        addToHitAdjacentQueue(x - 1, y);
        addToHitAdjacentQueue(x + 1, y);
        addToHitAdjacentQueue(x, y - 1);
        addToHitAdjacentQueue(x, y + 1);
        //queue is not empty
        while(!hitAdjacentPoint.isEmpty())
        {
            point = hitAdjacentPoint.poll();
            if(!shootedPoint.contains(point))  //point is not in shootedpoint
            {
                //if not in shootedPoint then shoot
                 if (battleShip.shoot(point)) {
                    hitPoint.add(point); //add to hitPoint
                    shootedPoint.add(point);
                    x = point.x;
                    y = point.y;
                    boardStatus[x][y] = CellState.Hit;

                    //2 hits are horizontal then (fire in that direction only so)
                    if (hitPoint.get(0).x == x) {
                        //add horizontal adjacent point
                        addToHitAdjacentQueue(x, y - 1);
                        addToHitAdjacentQueue(x, y + 1);
                        //check for valid vertical point and change status to MISS - 'O'
                        if (isValidPoint(x - 1, y) && boardStatus[x - 1][y] == CellState.Empty) {
                            boardStatus[x - 1][y] = CellState.Miss;
                            shootedPoint.add(new Point(x - 1, y));
                        }//check for valid vertical point and change status to miss
                        if (isValidPoint(x + 1, y) && boardStatus[x + 1][y] == CellState.Empty) {
                            boardStatus[x + 1][y] = CellState.Miss;
                            shootedPoint.add(new Point(x + 1, y));
                        }
                    } //2 hits are vertical then (fire in that direction only so)
                    else if (hitPoint.get(0).y == y) {
                        //add vertical adjacent points
                        addToHitAdjacentQueue(x + 1, y);
                        addToHitAdjacentQueue(x - 1, y);
                        //check for valid horizontal points and change status to MISS - 'O'
                        if (isValidPoint(x, y + 1) && boardStatus[x][y + 1] == CellState.Empty) {
                            boardStatus[x][y + 1] = CellState.Miss;
                            shootedPoint.add(new Point(x, y + 1));
                        }//check for valid horizontal points and change status to MISS - 'O'
                        if (isValidPoint(x, y - 1) && boardStatus[x][y - 1] == CellState.Empty) {
                            boardStatus[x][y - 1] = CellState.Miss;
                            shootedPoint.add(new Point(x, y - 1));
                        }
                    }
                    //sunken ship  increases so it means we sunk the ship
                    if (battleShip.numberOfShipsSunk() > sunkShipsCount) {
                        //add all the points in queue to shootedPoint and chnage the boardStatus to MISS - 'O'
                        for (Point p : hitAdjacentPoint) {
                            boardStatus[p.x][p.y] = CellState.Miss;
                            shootedPoint.add(p);
                        }
                        sunkShipsCount = battleShip.numberOfShipsSunk();//increase the sunken ship count
                        hitAdjacentPoint.clear();  //clear the queue of adjacent point
                        hitPoint.clear(); //clear the arraylist of number of hit point
                        break;
                    }
                 } else {
                     boardStatus[point.x][point.y] = CellState.Miss;
                 }
            }
        }
    }
    /***
     * Checks for valid adjacent point that can be added to hitAdjacentPoint Queue
     * @param x - x coordinate of point
     * @param y - y coordinate of point
     */
    private void addToHitAdjacentQueue(int x, int y) {
        if (!shootedPoint.contains(new Point(x,y))&&isValidPoint(x, y)  ) {
            hitAdjacentPoint.add(new Point(x, y));
        }
    }

    /**
     * Checks if point is within the bound
     * @param x - x coordinate of point
     * @param y - y coordinate of point
     * @return true- point is in board /false - point outside board
     */
    private boolean isValidPoint(int x, int y) {
        if(!shootedPoint.contains(new Point(x,y))){
            return x >=0 && x < gameSize && y >= 0 && y < gameSize;
        }
        return false;
    }

    /**
     * Authorship of the solution - must return names of all students that contributed to
     * the solution
     * @return names of the authors of the solution
     */

    @Override
    public String getAuthors() {
        return " Dipsa Khunt ";
    }



}
