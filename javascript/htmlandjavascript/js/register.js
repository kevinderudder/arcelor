
let saveButton, errorList, isFormValid = false, bobTheErrorMessageBuilder = "";

function init(){
    saveButton = document.getElementById("saveButton");
    saveButton.addEventListener("click", function(){
        if(validateForm()){
            // save
        }
        else{
            showErrors();
        }
    });

    errorList = document.getElementById("errormessages");

}

function showErrors(){
    errorList.innerHTML = bobTheErrorMessageBuilder;
}

function validateForm(){
    const fields = document.querySelectorAll(".input");
    if(fields){
        for(let i = 0, l = fields.length ; i < l ; i++){
            let field = fields[i];
            validateRequiredField(field);
        }
    }

    return isFormValid = errorList.length === 0;
}

function validateRequiredField(fld){
    if(fld.value === ""){
        //let li = document.createElement("li");
        //li.innerHTML = `Het veld <strong>${fld.attributes["info"].value}</strong> is niet ingevuld`
        //errorList.appendChild(li);

        bobTheErrorMessageBuilder += `<li>Het veld <strong>${fld.attributes["info"].value}</strong> is niet ingevuld</li>`; 

        return false;
    }
    else{
        return true;
    }
}


init();