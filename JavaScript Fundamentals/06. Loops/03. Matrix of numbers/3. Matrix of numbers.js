function solve(args) {
  let a = +args[0];
	let result = '';
	for (let i = 0; i < a; i += 1) {
		for (let j = i + 1; j <= a + i; j += 1) {
			result += j + ' ';
		}
		result += '\n';
	}
	return result;
}
