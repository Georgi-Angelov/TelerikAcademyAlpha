function solve(args) {
    let a = +args[0];
    let b = '';

    for(i = 1; i <= a; i++) {
      b += `${i} `;
    }
    return b;
}
