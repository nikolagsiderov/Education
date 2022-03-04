import java.util.*;

public class SimpleArraySum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] line = scanner.nextLine().split("\\s");
        int sizeOfArray = line.length;

        int[] numbers = new int[sizeOfArray];
        int[] firstHalf = new int[sizeOfArray/4];
        int[] secondHalf = new int[sizeOfArray/4];
        int[] mainBody = new int[sizeOfArray/2];
        int[] otherMainBody = new int[sizeOfArray/2];

        for (int i = 0; i < numbers.length/4; i++) {
            firstHalf[i] = numbers[i];
        }

        for (int i = 0; i < numbers.length/4; i++) {
            secondHalf[i] = numbers[numbers.length-i-1];
        }

        for (int i = numbers.length/4, k = 0; i < numbers.length-numbers.length/4; i++, k++) {
            mainBody[k] = numbers[i];
        }

        int index = 0;

        for (int i = firstHalf.length-1; i >= 0; i--) {
            otherMainBody[index] = firstHalf[i];
        }

        for (int i = secondHalf.length-1; i >= 0; i--) {
            otherMainBody[index] = secondHalf[i];
        }

        int[] resultArray = new int[sizeOfArray/2];

        for (int i = 0; i < sizeOfArray/2; i++) {
            resultArray[i] = mainBody[i] + otherMainBody[i];
        }

        System.out.println(java.util.Arrays.toString(resultArray));
    }
}