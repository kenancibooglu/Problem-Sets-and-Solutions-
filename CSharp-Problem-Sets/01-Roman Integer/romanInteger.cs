public class Solution {
    public int RomanToInt(string s) {
        // Bir sözlük nesnesi oluşturduk.
        Dictionary<char, int> romanMap = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        int result = 0;
        int previousValue = 0;
        for (int i = s.Length - 1; i >= 0; i--) {
            int currentValue = romanMap[s[i]]; 
            if (currentValue >= previousValue) {
                result += currentValue;
            } else {
                result -= currentValue;
            }
            previousValue = currentValue;
        }
        
        return result; 
    }
}