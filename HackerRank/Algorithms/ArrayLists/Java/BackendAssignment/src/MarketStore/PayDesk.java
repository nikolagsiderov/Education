package MarketStore;
import Contracts.ICard;

public class PayDesk {
    private Double totalPurchaseValue;
    private Double discountRate;

    public PayDesk(Double totalPurchaseValue, ICard card) {
        this.totalPurchaseValue = totalPurchaseValue;
        this.discountRate = card.initialDiscountRate();
    }

    public Double discountRate() {
        return this.discountRate;
    }

    public Double discount() {
        return totalPurchaseValue * discountRate / 100;
    }

    public Double totalPurchaseValue() {
        return this.totalPurchaseValue;
    }

    public Double totalPrice() {
        return totalPurchaseValue - discount();
    }
}
