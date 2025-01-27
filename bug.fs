let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //Output: 20 10

//However, if you try to swap values in a function like this:

let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable a = ref 10
let mutable b = ref 20
swap2 a b
printf "%d %d" (!a) (!b) //Output: 20 10

//The difference is that in the first example, the values are copied, while in the second example, the references to the values are copied. Thus, changing the values within the swap2 function changes the original values outside the function.