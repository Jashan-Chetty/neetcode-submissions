public class Solution {
    public bool IsValid(string s) {
        // Optimization 1: Odd-length strings can NEVER be valid
        if (s.Length % 2 != 0) return false;

        // Optimization 2: Use a raw char array instead of a Stack object
        char[] stackBuffer = new char[s.Length];
        int topIdx = -1; // Manual pointer to track the top of the stack

        // Optimization 3: A standard for-loop with indexers is faster than foreach
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];

            if (c == '(') {
                stackBuffer[++topIdx] = ')';
            } else if (c == '{') {
                stackBuffer[++topIdx] = '}';
            } else if (c == '[') {
                stackBuffer[++topIdx] = ']';
            } else {
                // Optimization 4: Faster primitive pointer boundaries check
                if (topIdx == -1 || stackBuffer[topIdx--] != c) {
                    return false;
                }
            }
        }

        // If our pointer reset back past 0, all brackets were closed
        return topIdx == -1;
    }
}
