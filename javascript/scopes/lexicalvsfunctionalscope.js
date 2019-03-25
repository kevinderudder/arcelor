


function blockDemo(){

    for(let i = 0, l = 10 ; i < l ; i++){
        console.log(i);
    }

    console.log(i);

}

function functionalDemo(){

    for(var i = 0, l = 10 ; i < l ; i++){
        console.log(i);
    }

    console.log(i);

}

function hoistingDemo(){

    console.log(name);
    var name = "kevin";
    console.log(name);

}


//functionalDemo();
//blockDemo();
hoistingDemo();