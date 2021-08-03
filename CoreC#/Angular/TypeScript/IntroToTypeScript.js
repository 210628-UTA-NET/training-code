console.log("=========== Variables ===========");
let s1 = "Hello";
let s2 = " World";
console.log(s1 + s2);
//Any datatype
let any = "test";
any = 12;
any = true;
//Number
let n1 = 5;
//Multiple data
let mul;
mul = 67;
mul = "67";
//Do not use void or never as datatypes for variables
//Void is used for funtion return type
//Never is used for error handling
//Null or undefined
let nul1; //Undefined
let nul2 = null; //Null
//Arrays
let arry1;
arry1 = ["one", 2, true];
let arry2;
arry2 = ["one", 2];
let arry3;
arry3 = ["one", 2];
arry3 = false;
//Tuple - It is an array but it has a fixed length
let tul1;
tul1 = [5, "6"];
//Enum
var Engine;
(function (Engine) {
    Engine[Engine["Off"] = 0] = "Off";
    Engine[Engine["On"] = 1] = "On";
    Engine[Engine["Accel"] = 2] = "Accel";
})(Engine || (Engine = {}));
let engineState = Engine.Off;
console.log("=========== Functions ===========");
function myFunc(param1, param2) {
    console.log(param1 + param2);
}
myFunc(5, "Function");
function myFunc2(params) {
    return params + "myFunc2";
}
console.log(myFunc2("Test "));
console.log("=========== Classes And Objects ===========");
class SuperVillian {
    constructor(name, superpower, bounty) {
        this.name = name;
        this.superpower = superpower;
        this.bounty = bounty;
    }
    useAbility(param2, param) {
        console.log(this.superpower + " has been unleashed " + param);
    }
}
let vil1;
vil1 = new SuperVillian("Julian", "Bad Coding");
console.log(vil1);
vil1.useAbility();
vil1.useAbility(false, "And Fly Underwater");
vil1.useAbility(true, 5);
//Inheritance example
class VillianOrganization extends SuperVillian {
    constructor(name, superpower, title, bounty) {
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
    constructor(name, age, breed) {
        this.name = name;
        this.age = age;
        this.breed = breed;
        /*
        it will also automatically assigned value if you stated it on the constructor
        this.name = name;
        this.age = age;
        */
    }
    get Name() {
        return this.name;
    }
    set Name(variable) {
        this.name = variable;
    }
    set Age(v) {
        this.age = v;
    }
    get Age() {
        return this.age;
    }
}
let pet1 = new Pet("Minnie");
pet1.Name = "Sophie";
pet1.Age = 10;
console.log(pet1.Name);
