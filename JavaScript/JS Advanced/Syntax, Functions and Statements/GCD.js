function getGCD(num1, num2) {
    if (num1 === num2) {
        return num1;
    }

    if (num1 > num2) {
        return getGCD(num1-num2, num2);
    } else {
        return getGCD(num1, num2-num1);
    }
}

getGCD(2154, 458);