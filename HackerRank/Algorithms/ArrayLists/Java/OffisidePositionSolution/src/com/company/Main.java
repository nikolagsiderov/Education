package com.company;
import java.util.List;
import java.util.Scanner;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {
        List<Integer> firstTeamCoordinates = GetTeamCoordinates();
        List<Integer> secondTeamCoordinates = GetTeamCoordinates();

        Boolean offside  = CheckForOffsidePosition(firstTeamCoordinates, secondTeamCoordinates);

        System.out.println(offside);
    }

    public static List<Integer> GetTeamCoordinates() {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        List<Integer> team = ParseInputToIntegerArray(input);

        return team;
    }

    public static List<Integer> ParseInputToIntegerArray(String input) {
        List<Integer> result = new ArrayList<>();
        String[] inputToArray = input.split("\\s");

        for (int i = 0; i < inputToArray.length; i++) {
            result.add(Integer.parseInt(inputToArray[i]));
        }

        return result;
    }

    public static Boolean CheckForOffsidePosition(List<Integer> firstTeam, List<Integer> secondTeam) {
        int maxValueFirstTeam = FindMaxValueCoordinatesFirstTeam(firstTeam);
        int maxValueSecondTeam = FindMaxValueCoordinatesSecondTeam(secondTeam);
        int minValueFirstTeam = FindMinValueCoordinatesFirstTeam(firstTeam);
        int minValueSecondTeam = FindMinValueCoordinatesSecondTeam(secondTeam);

        Boolean firstCase = TestFirstCaseForOffside(maxValueFirstTeam, maxValueSecondTeam);
        Boolean secondCase = TestSecondCaseForOffside(minValueSecondTeam, minValueFirstTeam);

        if (firstCase) {
            return true;
        }
        else if (secondCase) {
            return true;
        }

        return false;
    }

    public static int FindMaxValueCoordinatesFirstTeam(List<Integer> firstTeam) {
        int maxValue = Integer.MIN_VALUE;

        for (int i = 0; i < firstTeam.size(); i++) {
            if (firstTeam.get(i) >= maxValue) {
                maxValue = firstTeam.get(i);
            }
        }

        return maxValue;
    }

    public static int FindMaxValueCoordinatesSecondTeam(List<Integer> secondTeam) {
        int maxValue = Integer.MIN_VALUE;
        int index = -1;

        for (int i = 0; i < secondTeam.size(); i++) {
            if (secondTeam.get(i) >= maxValue) {
                maxValue = secondTeam.get(i);
                index = i;
            }
        }

        secondTeam.remove(index);
        maxValue = Integer.MIN_VALUE;

        for (int i = 0; i < secondTeam.size(); i++) {
            if (secondTeam.get(i) >= maxValue) {
                maxValue = secondTeam.get(i);
            }
        }

        return maxValue;
    }

    public static int FindMinValueCoordinatesFirstTeam(List<Integer> firstTeam) {
        int minValue = Integer.MAX_VALUE;
        int index = -1;

        for (int i = 0; i < firstTeam.size(); i++) {
            if (firstTeam.get(i) <= minValue) {
                minValue = firstTeam.get(i);
                index = i;
            }
        }

        firstTeam.remove(index);
        minValue = Integer.MAX_VALUE;

        for (int i = 0; i < firstTeam.size(); i++) {
            if (firstTeam.get(i) <= minValue) {
                minValue = firstTeam.get(i);
            }
        }

        return minValue;
    }

    public static int FindMinValueCoordinatesSecondTeam(List<Integer> secondTeam) {
        int minValue = Integer.MAX_VALUE;

        for (int i = 0; i < secondTeam.size(); i++) {
            if (secondTeam.get(i) <= minValue) {
                minValue = secondTeam.get(i);
            }
        }

        return minValue;
    }

    public static Boolean TestFirstCaseForOffside(int maxValueFirstTeam, int maxValueSecondTeam) {
        if (maxValueFirstTeam > maxValueSecondTeam) {
            return true;
        }

        return false;
    }

    public static Boolean TestSecondCaseForOffside(int minValueSecondTeam, int minValueFirstTeam) {
        if (minValueSecondTeam < minValueFirstTeam) {
            return true;
        }

        return false;
    }
}
