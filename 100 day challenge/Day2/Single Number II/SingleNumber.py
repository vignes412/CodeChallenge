from typing import List
def main():
    v = [0,1,0,1,0,1,99]
    a=Solution();
    print(a.singleNumber(v))

class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        d={x:nums.count(x) for x in nums}
        return list(d.keys())[list(d.values()).index(1)]

if __name__ == '__main__':
    main()
