function solve(args){
    if (parseInt(args[0]) % 2 === 0) {
      return 'even ' + args[0];
    }
    else {
      return 'odd ' + args[0];
    }
}
solve(['-2']);
solve(['-1']);
solve(['0']);
solve(['2']);
solve(['3']);
