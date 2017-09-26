function solve(args){
    let number = parseInt(args[0]);

    if(parseInt((number / 100) % 10) === 7){
        return "true";
    }
    else{
        return "false"+ " " + parseInt((number / 100) % 10);
    }
}
solve(['5']);
solve(['701']);
solve(['9703']);
solve(['877']);
solve(['777877']);
solve(['9999799']);
