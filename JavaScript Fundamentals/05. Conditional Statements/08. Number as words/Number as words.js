function solve(args) {
    let ones = [' Zero', ' One', ' Two', ' Three', ' Four', ' Five', ' Six', ' Seven', ' Eight', ' Nine', ' Ten', ' Eleven', ' Twelve', ' Thirteen', ' Fourteen', ' Fifteen', ' Sixteen', ' Seventeen', ' Eighteen', ' Nineteen'];
    let tens = ['', '', ' Twenty', ' Thirty', ' Forty', ' Fifty', ' Sixty', ' Seventy', ' Eighty', ' Ninety'];
    let result = '';

    for (let i = 0; i < args.length; i += 1) {
        if (+args[i] < 20) {
            result = ones[+args[i]].trim();
        } else if (+args[i] % 10 === 0 && +args[i] > 19 && +args[i] < 100) {
            result = tens[+args[i] / 10].trim();
        } else if (+args[i] % 10 !== 0 && +args[i] > 19 && +args[i] < 100) {
            result = tens[Math.floor(args[i] / 10)].trim() + ones[+args[i] % 10].toLowerCase();
        } else if ((args[i] % 100) === 0 && args[i] > 99 && args[i] < 1000) {
            result = ones[args[i] / 100] + ' hundred';
        } else if ((args[i] % 100) !== 0 && args[i] > 99 && args[i] < 1000 && +args[i] % 10 !== 0) {
            result = ones[Math.floor(args[i] / 100)] + ' hundred and';
            if (args[i] % 100 < 20) {
                result += ones[Math.floor(args[i] % 100)].toLowerCase();
            } else {
                result += tens[Math.floor(args[i] / 10) % 10].toLowerCase() +
                    ones[Math.floor((args[i] % 100) % 10)].toLowerCase();
            }
        } else if (+args[i] % 10 === 0 && +args[i] > 100 && +args[i] < 1000) {
            result = ones[Math.floor(args[i] / 100)] + ' hundred and' + tens[Math.floor(args[i] / 10) % 10].toLowerCase();
        }
    }
    console.log(result);
}
