public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length - 1]++;
        int carry = 0;
        if (digits[digits.Length - 1] >= 10) {
            carry = digits[digits.Length - 1] / 10;
            digits[digits.Length - 1] %= 10;
        }
        int i = digits.Length - 2;
        while (carry > 0 && i >= 0) {
            int newVal = digits[i] + 1;
            carry = newVal / 10;
            digits[i] = newVal % 10;
            i--;
        }

        if (carry > 0) {
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = carry;
            for (int j = 1; j < newDigits.Length; j++) {
                newDigits[j] = digits[j - 1];
            }
            return newDigits;
        }
        return digits;
    }
}