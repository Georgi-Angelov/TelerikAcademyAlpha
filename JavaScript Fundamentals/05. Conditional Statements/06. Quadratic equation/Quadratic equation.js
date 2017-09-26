function solve(args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let root1,
    let root2;

    let d = Math.sqrt(b * b - 4 * a * c);

    if(d > 0) {
      root1 = ((b * -1) - d) / (2 * a);
      root2 = ((b * -1) + d) / (2 * a);
      return `x1=${root1.toFixed(2)}; x2=${root2.toFixed(2)}`;
    }
    else if (d === 0) {
      root1 = ((b * -1) / (2 * a));
      return `x1=x2=${root1.toFixed(2)}`;
    }
    else {
      return "no real roots";
    }
}
