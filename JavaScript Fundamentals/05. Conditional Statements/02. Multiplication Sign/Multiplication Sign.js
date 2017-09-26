function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];

    if( a === 0 || b === 0 || c === 0) {
        return 0;
    }
    else {
        let isNegative = false;
        if(a < 0)
        {
            isNegative = !isNegative;
        }
        if( b < 0)
        {
            isNegative = !isNegative;
        }
        if( c < 0 )
        {
            isNegative = !isNegative;
        }
        return isNegative ? "-" : "+";
    }
}
