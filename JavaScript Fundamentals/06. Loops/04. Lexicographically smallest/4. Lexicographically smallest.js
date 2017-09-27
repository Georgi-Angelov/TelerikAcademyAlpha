function solve(args) {
    let first = args[0];
    let second= args[1];

    if (first>second) {
        return '>';
    }
    else if (first<second) {
        return '<';
    }
    else {
        return '=';
    }
}
