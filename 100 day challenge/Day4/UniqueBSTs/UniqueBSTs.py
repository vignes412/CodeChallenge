from typing import List
def main():
    a=Solution();
    print(a.numTrees(4))

class Solution:
    def numTrees(self, n: int) -> int:
        if n == 0:
            return 1
        res = 0
        for i in range(1, n+1):
            res += self.numTrees(i-1)*self.numTrees(n-i)
        return res
        
    def numTrees2(self,n:int)->int:
        arr = [0]*(n+1)
        arr[0] = 1
        for i in range(1, n+1):
            for j in range(1, i+1):
                arr[i] += arr[j-1] * arr[i-j]
        return arr[-1]

if __name__ == '__main__':
    main()
