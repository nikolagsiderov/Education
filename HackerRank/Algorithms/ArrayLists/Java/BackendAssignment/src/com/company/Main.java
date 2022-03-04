package com.company;

import Contracts.ICard;
import MarketStore.PayDesk;
import CardClasses.BronzeCard;
import CardClasses.SilverCard;
import CardClasses.GoldCard;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        // input is specific:
        // {cardType} {cardOwner} {turnover} {purchaseValue}
        // each value separated by space
        String[] input = getInput();

        outputPayDeskValues(input);
    }

    public static String[] getInput() {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("\\s");

        scanner.close();

        return input;
    }

    public static void outputPayDeskValues(String[] input) {
        ICard card = determineCardType(input);

        if (card != null) {
            Double purchaseValue = Double.parseDouble(input[3]);

            PayDesk payDesk = new PayDesk(purchaseValue, card);

            System.out.printf("Purchase value: %.2f" + System.lineSeparator(), payDesk.totalPurchaseValue());
            System.out.printf("Discount rate: %.2f" + System.lineSeparator(), payDesk.discountRate());
            System.out.printf("Discount: %.2f" + System.lineSeparator(), payDesk.discount());
            System.out.printf("Total: %.2f" + System.lineSeparator(), payDesk.totalPrice());
        }
    }

    public static ICard determineCardType(String[] input) {
        ICard card;
        String cardType = input[0];
        String cardOwner = input[1];
        Double turnover = Double.parseDouble(input[2]);


        switch (cardType) {
            case "Bronze" : card = new BronzeCard(cardOwner ,turnover);
                break;
            case "Silver": card = new SilverCard(cardOwner ,turnover);
                break;
            case "Gold" : card = new GoldCard(cardOwner ,turnover);
                break;
            default: return null;
        }

        return card;
    }
}
