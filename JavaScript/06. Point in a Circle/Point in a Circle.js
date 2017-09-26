function solve(args){
    let x = +args[0];
    let y = +args[1];
    let radius = 2;
    let isInCircle = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= (radius * radius);
    let distance = Math.sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));
    if (isInCircle == true){
        return "yes " + distance.toFixed(2);
    }
    else {
        return "no " + distance.toFixed(2);
    }
}
solve(['-2', '0']);
solve(['-1', '2']);
solve(['1.5', '-1']);
solve(['-1.5', '-1.5']);
solve(['100', '-30']);
solve(['0', '0']);
solve(['0.2', '-0.8']);
solve(['0.9', '-1.93']);
solve(['1', '1.655']);
solve(['0', '1']);
