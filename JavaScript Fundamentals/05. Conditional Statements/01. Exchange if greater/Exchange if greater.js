function solve(args){
    let a = +args[0];
    let b = +args[1];

    if( a > b ){
        let c = a;
            a = b;
            b = c;
    }
    let result = a.toString() + " " + b.toString();

    return result;
}
