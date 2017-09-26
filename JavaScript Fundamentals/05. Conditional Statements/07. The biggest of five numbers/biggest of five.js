function solve(numbers){
    let b = Number.MIN_VALUE;
        b = Math.max.apply(null, numbers);
    console.log(b);
}
