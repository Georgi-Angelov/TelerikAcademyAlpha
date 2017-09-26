function solve(args){
    let a = parseInt(args[0]);
    return (a >> 3) & 1;
}
solve(['15']);
solve(['1024']);
