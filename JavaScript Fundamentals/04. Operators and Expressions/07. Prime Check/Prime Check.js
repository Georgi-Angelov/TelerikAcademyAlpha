function solve(args){
    let a = +args[0];
    //if between 2 and 100
    if (a < 2 || a >= 100){
        return false;
    }

    let q = Math.floor(Math.sqrt(a));
    for (let i = 2; i <= q; i++){
        if (a % i == 0){
            return false;
        }
    }
    return true;
}
