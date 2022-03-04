package CardClasses;

import Contracts.ICard;

public class SilverCard implements ICard {
    private String owner;
    private Double turnoverPreviousMonth;

    public SilverCard(String owner, Double turnoverPreviousMonth) {
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
        if (this.turnoverPreviousMonth >= 300) {
            return 3.5;
        }
        else {
            return 2.0;
        }
    }
}