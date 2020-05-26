abstract class Melon {
    weight: number
    melonSort: string

    constructor(weight: number, melonSort: string) {
        this.weight = weight
        this.melonSort = melonSort
    }
}

class Watermelon extends Melon {
    elementIndex: number = this.weight * this.melonSort.length

    toString() {
        let result = `Element: Water \n Sort: ${this.melonSort} \n Element Index: ${this.elementIndex}`
        return result
    }
}

class Firemelon extends Melon {
    elementIndex: number = this.weight * this.melonSort.length

    toString() {
        let result = `Element: Water \n Sort: ${this.melonSort} \n Element Index: ${this.elementIndex}`
        return result
    }
}

class Earthmelon extends Melon {
    elementIndex: number = this.weight * this.melonSort.length

    toString() {
        let result = `Element: Water \n Sort: ${this.melonSort} \n Element Index: ${this.elementIndex}`
        return result
    }
}

class Airmelon extends Melon {
    elementIndex: number = this.weight * this.melonSort.length

    toString() {
        let result = `Element: Water \n Sort: ${this.melonSort} \n Element Index: ${this.elementIndex}`
        return result
    }
}