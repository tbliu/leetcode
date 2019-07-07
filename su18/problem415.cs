public class Solution {
    public string AddStrings(string num1, string num2) {
        StringBuilder sum = new StringBuilder();
        string longer;
        string shorter;
        if (num1.Length >= num2.Length) {
            longer = num1;
            shorter = num2;
        } else {
            longer = num2;
            shorter = num1;
        }

        int longIndex = longer.Length - 1;
        int shortIndex = shorter.Length - 1;
        int carry = 0;
        while (longIndex >= 0 && shortIndex >= 0) {
            int added = (int) Char.GetNumericValue(longer[longIndex]) 
                + (int) Char.GetNumericValue(shorter[shortIndex]) + carry;
            carry = added / 10;
            int newDigit = added % 10;
            sum.Append(newDigit.ToString());
            longIndex--;
            shortIndex--;
        }

        while (longIndex >= 0) {
            int added = (int) Char.GetNumericValue(longer[longIndex]) + carry;
            carry = added / 10;
            int newDigit = added % 10;
            sum.Append(newDigit.ToString());
            longIndex--;
        }

        if (carry > 0) {
            sum.Append(carry.ToString());
        }

        string reversedSum = sum.ToString();
        return Reverse(reversedSum);
    }

    private string Reverse(string str) {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}