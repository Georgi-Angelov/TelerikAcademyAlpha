function solve(args){
    let input = parseInt(args [0]);
    if (input % 5 === 0 && input % 7 === 0){
        return "true"+ " " + input;
    }
    else{
        return "false"+ " " + input;
    }
}
solve(['0']);
solve(['3']);
solve(['5']);
solve(['7']);
solve(['35']);
solve(['140']);
