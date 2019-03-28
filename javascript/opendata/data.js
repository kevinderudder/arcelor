



function getData(onReady, onError){
    let xmlHttp = new XMLHttpRequest();
    const url = 'https://datatank.stad.gent/4/mobiliteit/bezettingparkingsrealtime.json';
    xmlHttp.open('GET', url, true);
    xmlHttp.onreadystatechange = () => {
        if(xmlHttp.readyState === 4 && xmlHttp.status === 200){
            onReady(xmlHttp.responseText);
        }
        else if(xmlHttp.readyState === 4 && xmlHttp.status > 400){
            onError(xmlHttp.statusText);
        }
    };
    xmlHttp.send();
}

function getDataPromisse(){
    let p = new Promise(function(onSucceed, onError){
        let xmlHttp = new XMLHttpRequest();
        const url = 'https://datatank.stad.gent/4/mobiliteit/bezettingparkingsrealtime.json';
        xmlHttp.open('GET', url, true);
        xmlHttp.onreadystatechange = () => {
            if(xmlHttp.readyState === 4 && xmlHttp.status === 200){
                onSucceed(xmlHttp.responseText);
            }
            else if(xmlHttp.readyState === 4 && xmlHttp.status > 400){
                onError(xmlHttp.statusText);
            }
        };
        xmlHttp.send();
    });

    return p;
   
}

function getDataFetch(){
    const url = 'https://datatank.stad.gent/4/mobiliteit/bezettingparkingsrealtime.json';
    return fetch(url);
}