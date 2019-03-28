export class Parking {

    constructor(public id: number,
                public name: string,
                public description: string,
                public totalCapacity: number,
                public availableCapacity: number,
                public isOpen:boolean,
                public address: string
                ){}

    toString(){
        return `${this.name} - (${this.availableCapacity} / ${this.totalCapacity})`;
    }

}
