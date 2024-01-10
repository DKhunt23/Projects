//Animation of svg element and name of user and toss count checking 
//Auhor: Dipsa Khunt, 000870839, 17/07/2022

/**
 *@param load
 *@param function()
 *on load
*/


window.addEventListener("load", function () {
    
    //obtaning the element by its Id statGameButton
    let sbutton = document.getElementById("startGameButton");
    //obtaning the element by its Id gameStart
    let mbox = document.getElementById("gameStart");
    //obtaning the element by its Id Game
    let mainGame=document.getElementById("Game");
    //obtaning the element by its Id  user-Image
    let playerImage1=document.getElementById("player-Image");
    //obtaning the element by its Id computer-Iimage
    let systemImage1=document.getElementById("system-Image");
    //obtaning the element by its Id toss-Button
    let tossCoin=document.getElementById("toss-Button");
    //obtaning the element by its Id reset-Button 
    let resetCoin = document.getElementById("reset-Button");
    let footercolor1 = document.getElementById("footercolor");
    
    //sum - is used to keep the track of user clicked toss button
    let sum=0;
    // player and system head and tail count are made 0 first
    let systemh=0;
    let systemt=0;
    let playerh=0;
    let playert=0;
    

    //playerValidation function call by adding eventListener
    sbutton.addEventListener("click", playerValidation);
    
    //the main-Game part will not be shown till playerVladition is not true
    mainGame.style.display="none";
   
    

    //showing the player and system  head-count tail-count
    document.getElementById("player-Result").innerHTML = "Player:  Head - " + playerh + "  Tail - " + playert;
    document.getElementById("player-Result").innerHTML = "Player:  Head - " + playerh + "  Tail - " + playert;
    document.getElementById("system-Result").innerHTML = "System:  Head - " + systemh+ "  Tail - " + systemt;
    document.getElementById("system-Result").innerHTML = "System:  Head - " + systemh + "  Tail - " + systemt;
            
    //cointoss function will be called when player click toss-button
    tossCoin.addEventListener("click",cointoss);
    //coinreset function will be called when player click reset-button
    resetCoin.addEventListener("click",coinreset);
    //change the color of footer using mouseup and mousedown 
    footercolor1.addEventListener("mousedown",mousehold);
   
    
    //variable for tosscount value
    var tosscount2;

    /**
     * mousehold function change color to yellow
     * return nothing
     */
function mousehold(){
    document.getElementById("footercolor").style.color="yellow";
}

/*
 *playerValidation function
 *return true
 */
function playerValidation() 
{
    

    //obtaining the player-name which player gave
    var playervalid = document.getElementById("player-name").value;
    //obtaning the count of toss player want to have
    var tosscount = document.getElementById("toss-count").value;
    //player-name with alphabets only ref:https://www.w3resource.com/javascript/form/all-letters-field.php
    var playercheck=/^[a-zA-Z]+$/;
    //error will be displayed if feilf is empty
    if (playervalid == "") {
        document.getElementById("errorMsg").innerHTML = "<p style='color: red;'>Error:Enter Player name</p>";
        return false;
    }
    //checking if the player-name has all alphabets 
    if(!playervalid.match(playercheck))
    {
        document.getElementById("errorMsg").innerHTML = "<p style='color: red;'>Error:Enter alphabets only </p>";
        return false;
    }
     //checking the toss-count is empty or has value less than zero show error
    if(tosscount=="" || tosscount <=0)
    {
        document.getElementById("errorMsg2").innerHTML = "<p style='color: red;'>Error:Enter the toss-count</p>";
        return false;
    }

    //player-name must be between 5-10 length is not then error 
    if (playervalid.length > 10 || playervalid.length < 5) {
        document.getElementById("errorMsg").innerHTML = "<p style='color: red;'>Error:Playername must have 5-10 alphabets</p>";
        return false;
    }
    //player-name is between 5-10 alphabets then show is correct
    else  
    {
       
            
            document.getElementById("errorMsg").innerHTML = "<p>Correct Player Name</p>";
            //setting the first part of game to none 
            mbox.style.display="none";
            //setting the secong part of game to show
            mainGame.style.display="block";
            
            //giving the toss count to another variable
            tosscount2 = tosscount;
        
    }      
        
    return true;
}   

/**
 * no parameter function resetcoin
 */
function coinreset(){
    //setting the default image that was player head
    playerImage1.src="images/head.png";
    //setting the default image that was system head
    systemImage1.src="images/head.png";
    //setting value to zero for player and system tail head values
    playerh=0;
    playert=0;
    systemh=0;
    systemt=0;
    //setting playercount and systemcount of head and tail to zero
    document.getElementById("player-Result").innerHTML = "Player:  Head - " + playerh + "  Tail - " + playert;
    document.getElementById("system-Result").innerHTML = "System:  Head - " + systemh + "  Tail - " + systemt;
    document.getElementById("final-Result").innerHTML = "Start Playing Again!!!";
    
    sum=0;
   
    //function-calling tosscoin
    tossCoin.addEventListener("click",cointoss);
}



/**
 * no parameter function cointoss
 */
function cointoss(){

    //generating random values for player and system
    let tossplayer = Math.floor(Math.random()*2)+1;
    let tosssystem = Math.floor(Math.random()*2)+1;
    
    sum++;
   
    
    //button will be clicked till the sum value is not  equal to playertoss count
    if(sum <= tosscount2){
        document.getElementById("final-Result").innerHTML = "Who will win??";
        
        if(tossplayer == 1)
        {
            //player headcount is add by 1
            playerh++;
            //player coin-image will be of head-coin
            playerImage1.src="images/head.png";
            //showing the player's headcount and tailcount
            document.getElementById("player-Result").innerHTML = "Player:  Head - " + playerh + "  Tail - " + playert;
           

        }
        else{
            playert++;
             //player coin-image will be of tail-coin
             playerImage1.src="images/tail.png";
            //showing the player's headcount and tailcount
            document.getElementById("player-Result").innerHTML = "System:  Head - " + playerh + "  Tail - " + playert;
            
        }
    
        if(tosssystem == 1)
        {
            systemh++;
             //system coin-image will be of tail-coin
             systemImage1.src="images/head.png";
            //displaying count of head and tail
            document.getElementById("system-Result").innerHTML = "System:  Head - " + systemh + "  Tail - " + systemt;
            
        }
        else
        {
            systemt++;
             //image will be tail
            systemImage1.src="images/tail.png";
            //showing the system's headcount and tailcount
            document.getElementById("system-Result").innerHTML = "System:  Head - " + systemh + "  Tail - " + systemt;
            
        }
    }
    
    //as the sum value will be eqaul t0 tosscount
    if(sum==tosscount2)
    {
        var svgelement = document.getElementById("animatedResult"); 
        var id = null;  
        var position = -500;
        clearInterval(id);
        id = setInterval(svganmiation, 7);
        function svganmiation() 
        {
            if (position == 0) 
            {
                
                clearInterval(id);
        
             } 
             else 
             {
               position+=5;  
               svgelement.style.top = position + 'px'; 
            }
        }
        //player won when headcount is more
        if(playerh>systemh)
        {
            
            document.getElementById("final-Result").innerHTML = "  Result: Player Won!!!  ";
        }
        //tie when headcount are same
        else if(playerh == systemh)
        {
            
            document.getElementById("final-Result").innerHTML = "Tie!!!";
        }
        //system won headcount are more
        else
        {
            
            document.getElementById("final-Result").innerHTML = "  Result: System won!!!  ";
        }   
    }
}

});
