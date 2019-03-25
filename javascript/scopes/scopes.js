

var global = 'dit is een global variabele';


function eersteFunctie(){
    
    window.local = "dit is een local variabele in functie 1";
    console.log(global);
    console.info(local);
}

function tweedeFunctie(){
    
    //console.log(global);
    //console.info(local);
}

function getData(array){
    //console.log(array);
}

eersteFunctie();
tweedeFunctie();
