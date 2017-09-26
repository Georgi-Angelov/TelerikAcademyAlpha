function solve(args){
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    if (a > b && a > c) {
        return a;
    }
    else if( b > a && b > c) {
        return b;
    }
    else {
        return c;
    }
}
