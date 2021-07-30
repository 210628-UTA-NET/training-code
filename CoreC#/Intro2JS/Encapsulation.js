//Encapsulation with IIFE
let Outer = 
(
    () =>
    {
        let count = 0;
        return function Inner()
        {
            return count += 1;    
        }
    }
)();

let Count =
(
    () =>
    {
        let count = 0;
        return () => 
        {
            return count += 1;
        }
    }
);

let Add = Count();
let Add2 = Count();