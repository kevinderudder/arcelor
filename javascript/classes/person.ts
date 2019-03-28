class Person{

    /*firstname:string;
    name:string;
    age:number;*/

    constructor(public firstname:string, public name:string, public age:number){

       /* this.firstname = firstname;
        this.name = name;
        this.age = age;*/

    }

    toString():string{
        return `${this.firstname} ${this.name}`;
    }

}

let kevin = new Person("kevin", "derudder", 42);
console.log(kevin.firstname);
console.log(kevin.age);


class Money{

    static convertEurToDollar(value:number):number{
        return value * 1.1;
    }

}


