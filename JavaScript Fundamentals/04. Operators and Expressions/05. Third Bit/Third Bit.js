function solve(args){
    return (parseInt(args[0]) >> 3) & 1;
}
solve(['15']);
solve(['1024']);
