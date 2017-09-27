function solve(args) {
	let average = 0;
	let sum = 0;
	let min = +args[0];
	let max = +args[0];
	let result;
	for (i = 0; i < args.length; i++) {
		if (+args[i] >= max) {
			max = +args[i];
		}

		if (+args[i] <= min) {
			min = +args[i];
		}

		sum += +args[i];
	}

	average = sum /  args.length;
	
	result = 'min=' + min.toFixed(2) + '\n' +
					 'max=' + max.toFixed(2) + '\n' +
					 'sum=' + sum.toFixed(2) + '\n' +
					 'avg=' + average.toFixed(2);

	return result;
}
