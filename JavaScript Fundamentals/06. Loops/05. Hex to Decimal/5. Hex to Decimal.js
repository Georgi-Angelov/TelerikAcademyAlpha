function solve(args) {
    let digitAsString = '';
    let decNum = 0;
    let hexNum = args[0];

    for (let i = 0 ; i < hexNum.length; i += 1) {
        digitAsString = hexNum[i];

        switch (digitAsString) {
            case 'A':
                digitAsString = '10';
                break;
            case 'B':
                digitAsString = '11';
                break;
            case 'C':
                digitAsString = '12';
                break;
            case 'D':
                digitAsString = '13';
                break;
            case 'E':
                digitAsString = '14';
                break;
            case 'F':
                digitAsString = '15';
                break;
        }

    decNum = +digitAsString + decNum * 16;
    }
    return decNum;
}
