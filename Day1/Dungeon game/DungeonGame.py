from typing import List
def main():
    a=[[2],[1]];
    s=Solution();
    print(s.calculateMinimumHP(a));

class Solution:
    def calculateMinimumHP(self, dungeon: List[List[int]]) -> int:
        m=len(dungeon)
        n=len(dungeon[0])
        h=[[1 for _ in range(n)] for _ in range(m)]
        for i in range(m-1,-1,-1):
            for j in range(n-1,-1,-1):
                if(i==m-1 and j==n-1):
                    h[i][j]=max(1,1-dungeon[i][j])
                elif(i==m-1):
                    h[i][j]=max(1,h[i][j+1]-dungeon[i][j])
                elif(j==n-1):
                    h[i][j]=max(1,h[i+1][j]-dungeon[i][j])
                else:
                    h[i][j]=max(1,min(h[i+1][j],h[i][j+1])-dungeon[i][j])
        return h[0][0]
                    
                    
        

if __name__ == '__main__':
    main()
    
    