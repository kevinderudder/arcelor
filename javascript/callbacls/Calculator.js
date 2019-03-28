

// gewone code
function addgewoon(...values){
    let sum = 0;
    for(let i = 0, l = values.length ; i < l ; i++){
        sum+= values[i];
    }

    return sum;
}

// callback
function addCalback(wanneerKlaar,...values ){
    let sum = 0;
    for(let i = 0, l = values.length ; i < l ; i++){
        sum+= values[i];
    }

    wanneerKlaar(sum);
}


//let result = addgewoon(5,6,7);
let result = addCalback(wanneerKlaar,5,6,7);

function wanneerKlaar(resultaat){}

alert('test');
