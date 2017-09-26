function solve(args){
    let a = parseFloat(args[0]);
    let b = parseFloat(args[1]);
    let area = a * b;
    let perimether = 2 * (a + b);
    return area.toFixed(2) + " " + perimether.toFixed(2);
}

solve([ '2.5', '3' ]);
solve([ '5', '5' ]);
solve([ '3', '4' ]);
