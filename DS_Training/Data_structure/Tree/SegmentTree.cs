using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Training.Data_structure
{
    public class SegmentTree
    {
        public int[] elements;
        private int _leftMostTree;
        private int _rightMostTree;
        private readonly SegmentTree _leftSubTree;
        private readonly SegmentTree _rightSubTree;
        private bool IsLeafNode => _leftMostTree == _rightMostTree;

        public int RangeSum { get; private set; }
        public int MinimumValue { get; private set; }
        public int MaxmumValue { get; private set; }
        public SegmentTree(int[] arr, int leftIndex,int rightIndex)
        {
            this.elements = arr;
            this._leftMostTree = leftIndex;
            this._rightMostTree = rightIndex;
            if (!IsLeafNode)
            {
                int mid = leftIndex + (rightIndex - leftIndex) / 2;
                _leftSubTree = new SegmentTree(arr, leftIndex, mid);
                _rightSubTree = new SegmentTree(arr, mid+1,rightIndex);
            }
            CalculateRangeSum();
        }
        public void CalculateRangeSum()
        {
            if (!elements.Any()) return;
            if (IsLeafNode)
            {
                RangeSum = elements[_leftMostTree];
                MinimumValue = elements[_leftMostTree];
                MaxmumValue = elements[_leftMostTree];
            }
            else
            {
                RangeSum = _leftSubTree.RangeSum + _rightSubTree.RangeSum;
                MinimumValue = Math.Min(_leftSubTree.RangeSum, _rightSubTree.RangeSum);
                MaxmumValue = Math.Max(_leftSubTree.RangeSum, _rightSubTree.RangeSum);
            }
        }
        public int FindRangeSum(int left,int right) 
        {
            if (left == right)
                return elements[left];
            if (_leftMostTree > right || _rightMostTree < left)
                return 0;
            if (left <= _leftMostTree && right >= _rightMostTree)
                return RangeSum;

            return _leftSubTree.FindRangeSum(left, right) + _rightSubTree.FindRangeSum(left, right);
            

        }
        public int FindMinimum(int left, int right)
        {
            if (left == right)
                return elements[left];
            if (_leftMostTree > right || _rightMostTree < left)
                return 0;
            if (left <= _leftMostTree && right >= _rightMostTree)
                return MinimumValue;

            return Math.Min(_leftSubTree.FindMinimum(left, right) , _rightSubTree.FindMinimum(left, right));


        }
    }
}
