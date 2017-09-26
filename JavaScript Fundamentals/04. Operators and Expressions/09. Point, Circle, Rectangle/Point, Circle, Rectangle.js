function solve(args){
    let x = +args[0];
    let y = +args[1];
    let radius = 1.5;
    let cx = 1;
    let cy = 1;
    let isInCircle = (x - cx) * (x - cx) + (y - cy) * (y - cy) <= (radius * radius);
    let isInRectangle = x >= -1 && x <= 5 && y >= -1 && y <= 1;
    return (isInCircle ? "inside circle " : "outside circle ")
            + (isInRectangle ? "inside rectangle" : "outside rectangle");
}
solve(['2.5', '2']);
solve(['0', '1']);
solve(['2.5', '1']);
solve(['1', '2']);  
