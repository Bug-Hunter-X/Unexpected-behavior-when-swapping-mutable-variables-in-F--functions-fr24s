let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Output: 20 10

//The correct way to swap values using references:

let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable a = ref 10
let mutable b = ref 20
swap2 a b
printf "%d %d" (!a) (!b) //Output: 20 10

//Explanation:
//The key difference lies in how variables are passed to functions. Using `ref` creates a reference to the variable, which allows the function to modify the original value. Without `ref`, the function receives a copy, leaving the original value unchanged.