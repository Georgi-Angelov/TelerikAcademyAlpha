function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    if(a >= b && a >= c) {
        if(b > c) {
            return a + ' '+ b + ' ' + c;
        }
        else {
            return a + ' ' + c + ' ' + b;
        }
    }
    else if(b >= a && b >= c) {
        if (a > c) {
            return b + ' ' + a + ' ' + c;
        }
        else {
            return b + ' ' + c + ' ' + a;
        }
    }
    else
        if (a > b) {
            return c + ' ' + a + ' ' + b;
        }
        else {
            return c + " " + b + " " + a;
        }
}
