console.log("=========== Variables ===========");

let s1 = "Hello";

let s2 = " World";

console.log(s1 + s2);

//Any datatype
let any:any = "test";
any = 12;
any = true;

//Number
let n1 : number = 5;

//Multiple data
let mul: number | string;
mul = 67;
mul = "67";

//Do not use void or never as datatypes for variables
//Void is used for funtion return type
//Never is used for error handling

//Null or undefined
let nul1: null; //Undefined
let nul2 = null; //Null

//Arrays
let arry1: any[];
arry1 = ["one", 2, true];

let arry2: (number | string)[];
arry2 = ["one", 2];

let arry3: (number | string)[] | boolean;
arry3 = ["one" , 2];
arry3 = false;

//Tuple - It is an array but it has a fixed length
let tul1: [number, string];
tul1 = [5, "6"];

//Enum
enum Engine
{
    Off,
    On,
    Accel
}

let engineState = Engine.Off;

console.log("=========== Functions ===========");

function myFunc(param1:number, param2:string) 
{
    console.log(param1 + param2);    
}
myFunc(5,"Function");

function myFunc2(params:string) : string
{
    return params + "myFunc2";
}

console.log(myFunc2("Test "));

console.log("=========== Classes And Objects ===========");

class SuperVillian {
    name:string;
    superpower:string;
    bounty:number;

    constructor(name:string, superpower:string, bounty?:number) {
        this.name = name;
        this.superpower = superpower;
        this.bounty = bounty;
    }

    useAbility(param2?: boolean, param?:string | number) //? means that this parameter is optional
    {
        console.log(this.superpower + " has been unleashed " +param);
    }

}



let vil1:SuperVillian;

vil1 = new SuperVillian("Julian", "Bad Coding");
console.log(vil1);
vil1.useAbility();
vil1.useAbility(false, "And Fly Underwater");
vil1.useAbility(true, 5);

//Inheritance example
class VillianOrganization extends SuperVillian{
    title: string;

    constructor(name:string, superpower:string,title:string, bounty?:number) {
        super(name, superpower, bounty);

        this.title = title;
    }
}

class Pet {

    /*
        private name:string;
        protect age: number;

        You can just state the fields that this class will need on the constructor parameters and it will
        implicitly assign it
    */
    constructor(private name:string, protected age?:number, public breed?:string) 
    {
        /*
        it will also automatically assigned value if you stated it on the constructor
        this.name = name;
        this.age = age;
        */
    }

    public get Name()
    {
        return this.name;
    }

    public set Name(variable:string)
    {
        this.name = variable;
    }

    
    public set Age(v : number) {
        this.age = v;
    }

    
    public get Age() : number {
        return this.age;
    }
    
    
}

let pet1: Pet = new Pet("Minnie");
pet1.Name = "Sophie";
pet1.Age = 10;
console.log(pet1.Name);


