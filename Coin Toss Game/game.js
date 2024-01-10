//Auhor: Dipsa Khun, 000870839, Professor: Steve Adams, 01/07/2022
//JavsScript Code for validation logic and displaying result
/**
 *@param load
 *@param function()
 *on load
*/


window.addEventListener("load", function () {
    
    //creating access of start button using html element using ID 
    let startbutton1 = document.getElementById("startButton");
    //access of div class with id startGame
    let container = document.getElementById("startGame");
    //access of div class with id mainGame
    let game=document.getElementById("mainGame");
    //access of image of user with id userimage
    let userimage1=document.getElementById("userimage");
    //access of image of user with id computerimage
    let computerimage1=document.getElementById("computerimage");
    //access of toss button
    let toss1=document.getElementById("toss");
    //access of reset button
    let reset1 = document.getElementById("reset");
    //access of help button
    let help1= document.getElementById("help");
    //this is the help button in main game
    let help2=document.getElementById("ongoinghelp");
    
    //counter used for how many time loop run -- type-integer
    let counter=0;
    // declare and initializing no of userhead and tail, computer head and tail --type-integer
    let userhead=0;
    let usertail=0;
    let computerhead=0;
    let computertail=0;

    //on click function call to validateUsername
    startbutton1.addEventListener("click", validateUsername);
    //disabling the game part while validation is not complete
    game.style.display="none";
    //disabling the 2nd help part while validation is not complete
    help2.style.display="none";
    //onclick function call for help
    help1.addEventListener("click",gamehelp);

    //displaying no of head and tail of user and computer respectively
    document.getElementById("userresult").innerHTML = "User:  Head - " + userhead + "  Tail - " + usertail;
    document.getElementById("userresult").innerHTML = "User:  Head - " + userhead + "  Tail - " + usertail;
    document.getElementById("computerresult").innerHTML = "Computer:  Head - " + computerhead + "  Tail - " + computertail;
    document.getElementById("computerresult").innerHTML = "Computer:  Head - " + computerhead + "  Tail - " + computertail;
            
    //onclick function call for toss button
    toss1.addEventListener("click",tosscoin);
    //onclick function call for reset button
    reset1.addEventListener("click",resetcoin);
    //onclick function call for help button
    help2.addEventListener("click",gamehelp2);
    //for storing no of toss of user
    var noofusertoss2;


/*
 *this function validates the username and no of toss user entered
 *return true
 */
function validateUsername() {

    //getting the value user entered
    var vun = document.getElementById("userName").value;
    //getting the value opf no of toss user entered
    var noofusertoss = document.getElementById("noofToss").value;
    //username should have characters ref:https://www.w3resource.com/javascript/form/all-letters-field.php
    var usernamechecker=/^[a-zA-Z]+$/;
    //condition for empty username textfeild 
    if (vun == "") {
        document.getElementById("errormessage").innerHTML = "<p style='color: red;'>Error:Please Enter Username</p>";
        return false;
    }
    if(vun != usernamechecker)
    {
        document.getElementById("errormessage").innerHTML = "<p style='color: red;'>Error:Username must have characters only</p>";
        return false;
    }
     //condition for empty no of toss textfeild - display error
    if(noofusertoss=="" || noofusertoss <=0)
    {
        document.getElementById("errormessage2").innerHTML = "<p style='color: red;'>Error:Please Enter No. of toss</p>";
        return false;
    }

    //condition for username length less than 4 or  more than 8 -display error 
    if (vun.length > 8 || vun.length < 4) {
        document.getElementById("errormessage").innerHTML = "<p style='color: red;'>Error:Username must be between 4-8 characters</p>";
        return false;
    }
    //username is between 4-8 characters then check its order
    if (vun.length >= 4 && vun.length <=8) 
    {
        //stroing username after converting touppercase
        let uppervun = vun.toUpperCase();

        let count = 1;
        //for loop will run till the length-1 of username 
        for (let i = 0; i < vun.length; i++) 
        {
            //stroing the converted single letter ascill code
            let vun1 = uppervun.charCodeAt(i);
            let vun2 = uppervun.charCodeAt(i + 1);
            //condition for checking the ascending order of username
            if (vun1 < vun2) 
            {
                count++; //if current letter is less than next then count value increase
            }
        }
        //when count value and username length is same enter this block
        if (count == vun.length) 
        {
            //display username is valid
            document.getElementById("errormessage").innerHTML = "<p>Username correct</p>";
            //will disable the validation part
            container.style.display="none";
            //this will display the main part of game with coins
            game.style.display="block";
            //enable the 2nd help button 
            help2.style.display="block";
            
            //assigning the value of no of user toss
            noofusertoss2 = noofusertoss;
        }
        else {
            //if above condition is not fullfilled then this error will be displayed
            document.getElementById("errormessage").innerHTML = "<p style='color: red;'>Error:Username must have 4-8 ascending letters</p>";
        }
        return true;
    }   
}

//help function will display help points for first help
function gamehelp()
{
     document.getElementById("help").innerHTML = "<ul> <li>Enter the number of toss you want.</li> <li>Player with more number of heads will win </li> <ul>"
 }   
 //help function will display help points of main game
 function gamehelp2(){
     document.getElementById("ongoinghelppara").innerHTML = "You can toss only the number of times you entered <br>If you want to start again please click Reset Button"
 }

//function toss will generate random number and check for finalresult
function tosscoin(){

    //storing the random values for user and computer
    let usertoss = Math.floor(Math.random()*2)+1;
    let computertoss = Math.floor(Math.random()*2)+1;
    

    counter++;
    //for disappering the help points when user click toss button
    document.getElementById("ongoinghelppara").innerHTML = " "
    
    //toss button will make change till counter value is less or eqaul to username length
    if(counter <= noofusertoss2){
        document.getElementById("finalresult").innerHTML = "Lets See who wins!";
        //random value will be 1 than this block will run
        if(usertoss == 1)
        {
            //no of userhead will be increased
            userhead++;
            //image will be head
            userimage1.src="images/head.png";
            //displaying count of head and tail
            document.getElementById("userresult").innerHTML = "User:  Head - " + userhead + "  Tail - " + usertail;   

        }
        else{
            usertail++;
             //image will be tail
            userimage1.src="images/tail.png";
            //displaying count of head and tail
            document.getElementById("userresult").innerHTML = "User:  Head - " + userhead + "  Tail - " + usertail;
            
        }
    
        if(computertoss == 1)
        {
            computerhead++;
             //image will be head
            computerimage1.src="images/head.png";
            //displaying count of head and tail
            document.getElementById("computerresult").innerHTML = "Computer:  Head - " + computerhead + "  Tail - " + computertail;
            
        }
        else
        {
            computertail++;
             //image will be tail
            computerimage1.src="images/tail.png";
            //displaying count of head and tail
            document.getElementById("computerresult").innerHTML = "Computer:  Head - " + computerhead + "  Tail - " + computertail;
            
        }
    }
    
    //when counter value is same as no of toss user entered then this block will run
    if(counter==noofusertoss2)
    {
        //no. of userhead are more 
        if(userhead>computerhead)
        {
            //displaying user won
            document.getElementById("finalresult").innerHTML = "Final Result: User Won!";
        }
        //no of head of user and computer are same
        else if(userhead == computerhead)
        {
            //displaying there is a tie
            document.getElementById("finalresult").innerHTML = "There is a Tie!";
        }
        //if above bothe condition fails than this block will run
        else
        {
            //displaying computer won
            document.getElementById("finalresult").innerHTML = "Final Result: computer won!";
        }   
    }
}
//reset function for making head tail value to zero
function resetcoin(){
    //reseting image to head image
    userimage1.src="images/head.png";
    computerimage1.src="images/head.png";
    //reseting count of all head and tail to zero
    userhead=0;
    usertail=0;
    computerhead=0;
    computertail=0;
    //reseting values to zero
    document.getElementById("userresult").innerHTML = "User:  Head - " + userhead + "  Tail - " + usertail;
    document.getElementById("computerresult").innerHTML = "Computer:  Head - " + computerhead + "  Tail - " + computertail;
    document.getElementById("finalresult").innerHTML = "Lets Start Again!";
    
    counter=0;
    //clearing game help  points
    document.getElementById("ongoinghelppara").innerHTML = " "
    //calling toss function
    toss1.addEventListener("click",tosscoin);
}

});