from typing import List
def main():
    root=TreeNode(6)
    add(root,TreeNode(5))
    add(root,TreeNode(7))
    add(root,TreeNode(1))
    add(root,TreeNode(8))
    add(root,TreeNode(2))
    add(root,TreeNode(9))
    add(root,TreeNode(3))
    add(root,TreeNode(4))
    add(root,TreeNode(10))
    a=Solution();
    print(a.countNodes(root))
# Definition for a binary tree node.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

def add(root, node):
    if root is None:
            root=node
    else:
        if (root.val < node.val):
            if root.right is None:
                root.right=node
            else:
                add(root.right,node)
        else:
            if root.left is None:
                root.left = node
            else:
                add(root.left,node)

class Solution:
    def countNodes(self, root: TreeNode) -> int:
        count = 1
        if root is None:
            return -1
        if root is not None:
            if root.left is not None:
                count += self.countNodes(root.left)
            if root.right is not None:
                count +=  self.countNodes(root.right)
        return count
            
if __name__ == '__main__':
    main()
