package Contracts;

public interface ICard {
    String owner();

    Double turnoverPreviousMonth();

    Double initialDiscountRate();
}
