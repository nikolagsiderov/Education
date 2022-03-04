package CardClasses;

import Contracts.ICard;

public class BronzeCard implements ICard {
    private String owner;
    private Double turnoverPreviousMonth;

    public BronzeCard(String owner, Double turnoverPreviousMonth) {
        this.owner = owner;
        this.turnoverPreviousMonth = turnoverPreviousMonth;
    }

    public String owner() {
        return this.owner;
    }

    public Double turnoverPreviousMonth() {
        return this.turnoverPreviousMonth;
    }

    public Double initialDiscountRate() {
        if (this.turnoverPreviousMonth < 100) {
            return 0.0;
        }
        else if (this.turnoverPreviousMonth >= 100 && this.turnoverPreviousMonth < 300) {
            return 1.0;
        }
        else {
            return 2.5;
        }
    }
}
