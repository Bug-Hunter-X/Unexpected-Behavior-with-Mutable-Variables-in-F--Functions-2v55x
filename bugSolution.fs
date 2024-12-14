let x = 10
let y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

//Instead of changing x and y directly, pass the new values
let z2 = add 15 25
printf "%d\n" z2