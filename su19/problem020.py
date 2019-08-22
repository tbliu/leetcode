class Solution(object):
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        stack = []
        for char in s:
            if char == '(' or char == '[' or char == '{':
                stack.append(char)
            else:
                if len(stack) == 0:
                    return False
                top = stack.pop()
                if char == ')' and top != '(':
                    return False
                if char == ']' and top != '[':
                    return False
                if char == '}' and top != '{':
                    return False
        # strings like '(()' are not considered valid
        return len(stack) == 0