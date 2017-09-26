function solve(args){
    let number = parseInt((args[0] / 100) % 10);

    if(number === 7){
        return "true";
    }
    else{
        return "false " + number;
    }
}
solve(['5']);
solve(['701']);
solve(['9703']);
solve(['877']);
solve(['777877']);
solve(['9999799']);
