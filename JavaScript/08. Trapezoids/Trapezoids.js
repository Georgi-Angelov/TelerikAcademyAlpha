function solve(args){
    let a = +args[0];
    let b = +args[1];
    let h = +args[2];
    let area = h * ((a + b) / 2);
    return area.toFixed(7);
}
solve(['2']);
solve(['23']);
solve(['-3']);
solve(['0']);
solve(['1']);
