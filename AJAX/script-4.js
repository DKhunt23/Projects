//Author: Dipsa Khunt, 000870839, 30/07/22

/**
 * Ajax assignment
 * 
 */
window.addEventListener("load", function() {
	// preventing default
    document.forms.ajaxform.addEventListener("submit", function(event) {
        event.preventDefault();
	});
	// adding event listener to first button
	document.forms.ajaxform.firstButton.addEventListener("click",function(event){
		let url1 = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php";

		fetch(url1, { credentials: 'include' })
            .then(response => response.text())
			.then(firstsuccess)
            
	});

	// adding event listener to second button
	document.forms.ajaxform.secondButton.addEventListener("click", function(event) {
		
	
		let url2 = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php?choice=" + userInputValidation();
		// GET method
		fetch(url2, { credentials: 'include' })
			.then(response => response.json())
			.then(secondsuccess);
	});	
	// adding event listener to third button

	document.forms.ajaxform.thirdButton.addEventListener("click",function(event){
		userinput= document.getElementById("userText").value;
		// POST method
		let parameter = "choice=" + userInputValidation();
        let url3 = "https://csunix.mohawkcollege.ca/~adams/10259/a6_responder.php";
		fetch(url3,{
			credentials:'include',
			method:'POST',
			headers:{"Content-type":"application/x-www-form-urlencoded"},
			body: parameter
		})		

			.then(response => response.json())
			.then(thirdsuccess);
	});
	
	// validating data
	function userInputValidation(){
		let userinput= document.getElementById("userText").value;

		if(userinput == ""){
			document.getElementById("errorMessage").innerHTML = "Please enter value";
			return false;
		}
		else{
			if(userinput === "starwars" || userinput === "mario"){
				document.getElementById("userText").disabled = true;
				document.getElementById("errorMessage").innerHTML = "";
				return userinput;
			}
			else{
				document.getElementById("errorMessage").innerHTML = "Please enter starwars or mario";
				return false;
			}
		}
	}
});




/**
 * 
 * @param {*} text 
 */

 function firstsuccess(text){
	//adding response to header
	document.querySelector("header").innerHTML = "<h1>" + text + " #000870839" + "</h1>";
}

/**
 * 
 * @param {*} a 
 */
function secondsuccess(a) {
	var gamedata = "";	
	let userinput= document.getElementById("userText").value;
	// printing data 
	if(a.length == 3)
	{
		for (let i=0;i<a.length;i++){
			data="<h2>" + a[i].series +"</h2>" +
				 "<img src='"+ a[i].url + "' />" +
				 "<p>" + a[i].name + "</p>";
			gamedata += "<div class = 'col-sm-4'>" + data + "</div>";
		}
	}
	else if(a.length == 2){
		
		for (let i=0;i<a.length;i++){
			data="<h2>" + a[i].series +"</h2>" +
				 "<img src='"+ a[i].url + "' />" +
				 "<p>" + a[i].name + "</p>";
			gamedata += "<div class = 'col-sm-6'>" + data + "</div>";
		}
	}
	else{
		
		for (let i=0;i<a.length;i++){
			data="<h2>" + a[i].series +"</h2>" +
				 "<img src='"+ a[i].url + "' />" +
				 "<p>" + a[i].name + "</p>";
			gamedata += "<div class='col-sm-12'>" + data + "</div>";	
		}
	}

	//caption for second button data
	if(userinput == "mario"){
		document.getElementById("imageData").innerHTML = gamedata + "<p>Game trademarks and copyrights are properties of their respective owners. Nintendo properties are trademarks of Nintendo. © 2019 Nintendo.</p>";
	}
	else if(userinput == "starwars"){
		document.getElementById("imageData").innerHTML = gamedata + "<p>Star Wars © & TM 2022 Lucasfilm Ltd. All rights reserved. Visual material © 2022 Electronic Arts Inc.</p>";
	} 
}



/**
 * 
 * @param {*} a 
 */

function thirdsuccess(a){
	// printing data
	// console.log(JSON.stringify(a));
	table = document.getElementById("target");
	tabledata = "<tr><th>Series</th><th>Name</th><th>Link</th></tr>";

	// forming table
	for (let i = 0; i < a.length; i++) {
		
		row = "";
        row = "<td>" + a[i].series + "</td>" +
            "<td>" + a[i].name + "</td>" +
            "<td><a href +"+ a[i].url +">" + a[i].url + "</a></td>";
        tabledata += "<tr>" + row + "</tr>";

    }
	//caption for third button data
	if(userinput == "mario"){
		table.innerHTML = "<caption class = 'text-center'>Game trademarks and copyrights are properties of their respective owners. Nintendo properties are trademarks of Nintendo. © 2019 Nintendo. </caption>" + tabledata;
	}
	else if(userinput == "starwars"){
		table.innerHTML = "<caption class = 'text-center'>Star Wars © & TM 2022 Lucasfilm Ltd. All rights reserved. Visual material © 2022 Electronic Arts Inc. </caption>" + tabledata;
	}

}






