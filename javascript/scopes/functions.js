


// window.add = function(){}
function add(v1, v2){
    return v1 + v2;
}

// window.add = function(){}
// default parameters
function add(v1,v2,v3 = 0){
    return v1 + v2 + v3;
}

// arguments
function add(){
    let sum = 0;
    for(let i = 0, l = arguments.length ; i < l ; i++){
        sum += arguments[i];
    }

    return sum;
}

// rest parameter
function add(...values){
    let sum = 0;
    for(let i = 0, l = values.length ; i < l ; i++){
        sum += values[i];
    }

    return sum;
}

// rest parameter v2
function makeCocktail(name, ...ingredients){

}

let sum = add(5,6,7,8);
//makeCocktail("whiskey sour", "whiskey", "lemon", "rietsuiker");
//console.log(sum);

const theButton = document.getElementById("theButton");
const theButton2 = document.querySelector("#theButton");



function aboutThis(){
    //console.log(this);
    let test = 42;
    theButton.addEventListener("click", handleClick);

}

function handleClick(){
    console.log(this.innerHTML);
}
//handleClick();
//aboutThis();



function person(firstname, name){}
//let kevin = new person("kevin", "derudder");