function printResult(fruit, grams, pricePerKilo) {
    let neededMoney = ((grams * pricePerKilo) / 1000).toFixed(2);
    let kgAmount = (grams / 1000).toFixed(2);
    
    console.log(`I need $${neededMoney} to buy ${kgAmount} kilograms ${fruit}.`);
}

printResult('orange', 1563, 2.35);