using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            AllTasks.GetSelfAndChildrenRecursive(this).OfType<Button>().ToList().ForEach((b) => { b.Click += new EventHandler(this.printArray); });
        }

        List<int> array = new List<int>();
        List<int> array_back = new List<int>();
        private void printArray(object sender = null, EventArgs e = null)
        {
            listView.Clear();
            //this.lblList.Text = String.Join("\n", array.Select((x, ind) => ind + ": " + x)); // for label
            string temp = "";
            listView.Items.AddRange(array.Select((x, ind) => {
                temp = ind + ":   ";
                if (ind / 10 == 0) temp += "  ";
                temp += x;
                return new ListViewItem(temp);
            }).ToArray());
            if (array?.Count > 1)
            {
                btnBackToArray.Enabled = true;
                gbSort.Enabled = true;
            }
            else
            {
                btnBackToArray.Enabled = false;
                gbSort.Enabled = false;
            }
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            array = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < inpCreateLength.Value; i++)
            {
                array.Add(rand.Next(-100000, 100000));
            }
            array_back = array;
        }

        private void btnBackToArray_Click(object sender, EventArgs e)
        {
            array = array_back;
        }

        void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        public void InsertionSort(int[] items)
        {
            int sortedRangeEndIndex = 1;

            while (sortedRangeEndIndex < items.Length)
            {
                if (items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }

                sortedRangeEndIndex++;
            }
        }

        private int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for (int index = 0; index < items.Length; index++)
            {
                if (items[index].CompareTo(valueToInsert) > 0)
                {
                    return index;
                }
            }

            throw new InvalidOperationException("The insertion index was not found");
        }

        private void Insert(int[] itemArray, int indexInsertingAt, int indexInsertingFrom)
        {
            // itemArray =       0 1 2 4 5 6 3 7
            // insertingAt =     3
            // insertingFrom =   6
            //
            // Действия:
            //  1: Сохранить текущий индекс в temp
            //  2: Заменить indexInsertingAt на indexInsertingFrom
            //  3: Заменить indexInsertingAt на indexInsertingFrom в позиции +1
            //     Сдвинуть элементы влево на один.
            //  4: Записать temp на позицию в массиве + 1.


            // Шаг 1.
            int temp = itemArray[indexInsertingAt];

            // Шаг 2.

            itemArray[indexInsertingAt] = itemArray[indexInsertingFrom];

            // Шаг 3.
            for (int current = indexInsertingFrom; current > indexInsertingAt; current--)
            {
                itemArray[current] = itemArray[current - 1];
            }

            // Шаг 4.
            itemArray[indexInsertingAt + 1] = temp;
        }

        public void SelectionSort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);

                sortedRangeEnd++;
            }
        }

        private int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }

        public void MergeSort(int[] items)
        {
            if (items.Length <= 1)
            {
                return;
            }

            int leftSize = items.Length / 2;
            int rightSize = items.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];
            Array.Copy(items, 0, left, 0, leftSize);
            Array.Copy(items, leftSize, right, 0, rightSize);
            MergeSort(left);
            MergeSort(right);
            Merge(items, left, right);
        }

        private void Merge(int[] items, int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int targetIndex = 0;
            int remaining = left.Length + right.Length;
            while (remaining > 0)
            {
                if (leftIndex >= left.Length)
                {
                    items[targetIndex] = right[rightIndex++];
                }
                else if (rightIndex >= right.Length)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else if (left[leftIndex].CompareTo(right[rightIndex]) < 0)
                {
                    items[targetIndex] = left[leftIndex++];
                }
                else
                {
                    items[targetIndex] = right[rightIndex++];
                }

                targetIndex++;
                remaining--;
            }
        }

        Random _pivotRng = new Random();

        public void QuickSort(int[] items)
        {
            quick(items, 0, items.Length - 1);
        }

        private void quick(int[] items, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);
                int newPivot = partition(items, left, right, pivotIndex);

                quick(items, left, newPivot - 1);
                quick(items, newPivot + 1, right);
            }
        }

        private int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arr = array.ToArray();
            if (rbInsertion.Checked) InsertionSort(arr);
            else if (rbSelection.Checked) SelectionSort(arr);
            else if (rbMerge.Checked) MergeSort(arr);
            else if (rbQuick.Checked) QuickSort(arr);
            array = arr.ToList();
        }
    }
}
