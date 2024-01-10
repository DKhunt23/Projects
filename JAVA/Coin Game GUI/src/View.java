import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.scene.text.Font;
import javafx.stage.Stage;

/** This assignment is about javafx gui
 *  I had made a coin toss game in which there is textfield in which user will write username and
 *  On pressing start button a label will be displayed with username
 *  There are other three button named-head, tail and reset.
 *  When user click head button a random number will be generated and compared with that. if the generated number is 1 that is head then "your guess is correct"
 *  will be displayed and win count and headcount  will be increased but if the generated number is 2 then "Your guess is incorrect "will be displayed
 *  and tailcount will be increased. Vice versa for tail button.
 *  Reset Button will overwrite all values to zero and display message to it was at the start of game.
 *  */
/**
 *
 * @author Dipsa Khunt, 05/07/22
 */
public class View extends Application {

    /*  Declared all labels: title-label for title of game, hellousername-display hello msg with username, username- label for enter username, headresult-total headcount
    *   tailresult-total tailcount, finalresult-label whether the guess was correct or not, win- no of times user guess was correct*/
    Label title,hellousername,titleback,username,headresult,tailresult,finalresult,computerguess,win;

    /* declared textfeild for username */
    TextField usernameField;

    /* created the object of other class- GameModel */
    private GameModel gm = new GameModel();

    /**
    *  Handler method for displaying hello with username using setText
    * @param e
    *  */
    private void sayHandler(ActionEvent e) {
        String msg = "";

            msg += "  Hello, " + usernameField.getText() + " Start Playing!  ";
            hellousername.setText(msg);
    }


    /**
     * Handler method for  getting values from GameModel - head method
     * @param e
     */
    private void headdisplay(ActionEvent e){
        gm.head();
        /* getting computer value and displaying in computerguess label  */
        computerguess.setText("Computer Value: "+gm.getComputeroutput());

        /* getting user headcount value and displaying in headresult label  */
        headresult.setText(("User HeadCount: "+ gm.getHeadcount()));

        /* getting user tailcount value and displaying in tailresult label  */
        tailresult.setText("User TailCount: "+ gm.getTailcount());

        /* getting guess result and displaying in finalresult label  */
        finalresult.setText(gm.getOutput());

        /* getting no of time guess was correct value and displaying in win label  */
        win.setText(" Win: "+gm.getWinCount()+" ");
    }

    /**
     * Handler method for  getting values from GameModel -tail method
     * @param e
     */
    private void taildisplay(ActionEvent e){
        gm.tail();

        /* getting computer value and displaying in computerguess label  */
        computerguess.setText("Computer Value: "+gm.getComputeroutput());

        /* getting user headcount value and displaying in computerguess label  */
        headresult.setText("User HeadCount: "+gm.getHeadcount());

        /* getting user tailcount value and displaying in tailresult label  */
        tailresult.setText("User TailCount: "+gm.getTailcount());

        /* getting guess result and displaying in finalresult label  */
        finalresult.setText(gm.getOutput());

        /* getting no of time guess was correct value and displaying in win label  */
        win.setText(" Win: "+gm.getWinCount()+" ");
    }

    /**
     * Handler method for  getting values from GameModel -reset method
     * @param e
     */
    private  void resetdisplay(ActionEvent e){
        gm.reset();

        /* getting computer value and displaying in computerguess label  */
        computerguess.setText("Computer Value: "+gm.getComputeroutput());

        /* getting user headcount value and displaying in computerguess label  */
        headresult.setText("User HeadCount: "+gm.getHeadcount());

        /* getting user tailcount value and displaying in tailresult label  */
        tailresult.setText("User TailCount: "+gm.getTailcount());

        /* getting guess result and displaying in finalresult label  */
        finalresult.setText(gm.getOutput());

        /* getting no of time guess was correct value and displaying in win label  */
        win.setText(" Win: "+gm.getWinCount()+" ");
    }


    /**
     *
     *
     * @param stage The main stage
     * @throws Exception
     */
    public void start(Stage stage) throws Exception {

        Pane root = new Pane();
        /* set the width and height of window*/
        Scene scene = new Scene(root, 900, 600);
        /* set the window title*/
        stage.setTitle("Coin Toss");
        stage.setScene(scene);

        /* All label initialized*/
        title = new Label("Coin Toss Guess Game");
        titleback = new Label(" ");
        usernameField = new TextField(" ");
        username = new Label("Enter Username:");
        hellousername = new Label("");
        headresult = new Label("User HeadCount: 0");
        tailresult=new Label("User TailCount: 0");
        finalresult=new Label("  Choose Your Guess...  ");
        computerguess = new Label("Computer Value: ");
        win =new Label(" Win: 0 ");
        /* created and initialized the button*/
        Button startGame = new Button("Start Game");
        Button headbutton = new Button("Head");
        Button tailbutton = new Button("Tail");
        Button resetbutton = new Button("Reset");


        /* Added all components to the root */
        root.getChildren().addAll(titleback,title,username,usernameField,startGame,finalresult,hellousername,headbutton,tailbutton,resetbutton,computerguess,headresult,tailresult,win);

        /* setting the position, font of title label*/
        title.relocate(300,35);
        title.setFont(new Font("System", 40));

        /* setting the position, width, height, background color of titleback label*/
        titleback.relocate(0,35);
        titleback.setPrefWidth(900);
        titleback.setPrefHeight(50);
        titleback.setStyle("-fx-background-color: lightblue;-fx-text-fill:darkblue;");

        /* username label setting position */
        username.relocate(390,120);

        /* username textfield position*/
        usernameField.relocate(390,145);

        /* startGame button positon setting */
        startGame.relocate(430,190);

        /* setting hellousername label position , font,background,text-color */
        hellousername.relocate(360,260);
        hellousername.setFont(new Font("System", 20));
        hellousername.setStyle("-fx-background-color: lightblue;-fx-text-fill:darkblue;");

        /*  setting computerguess label position, font*/
        computerguess.relocate(390,330);
        computerguess.setFont(new Font("System", 15));

        /* setting headresult label position, font*/
        headresult.relocate(310,390);
        headresult.setFont(new Font("System", 15));

        /* setting tailresult label position, font*/
        tailresult.relocate(490,390);
        tailresult.setFont(new Font("System", 15));

        /* setting finalresult label position, font, background-color, text-color*/
        finalresult.relocate(380,450);
        finalresult.setFont(new Font("System", 15));
        finalresult.setStyle("-fx-background-color: lightblue;-fx-text-fill:darkblue;");

        /* setting win label position, font, background-color, text-color*/
        win.relocate(440,500);
        win.setFont(new Font("System", 15));
        win.setStyle("-fx-background-color: yellow;-fx-text-fill:red;");

        /* setting position of buttons - headbutton,tailbutton,resetbutton*/
        headbutton.relocate(400,550);
        tailbutton.relocate(460,550);
        resetbutton.relocate(510,550);

        /* onclick event for all button- startbutton, headbutton, tailbutton, resetbutton*/
        startGame.setOnAction(this::sayHandler);
        headbutton.setOnAction(this::headdisplay);
        tailbutton.setOnAction(this::taildisplay);
        resetbutton.setOnAction(this::resetdisplay);

        /* Show the stage*/
        stage.show();
    }

    /**
     *
     *
     * @param args unused
     */
    public static void main(String[] args) {
        launch(args);
    }
}
