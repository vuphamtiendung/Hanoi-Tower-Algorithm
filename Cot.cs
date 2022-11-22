using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExerciseOOP_04
{
    internal class Cot
    {
        private int[] _disks; // data structure
        private int _size; // size of Cot
        private int _top = 0; // situation of the disk
        private char _ten; // name of the disk

        public int Disk { get; set; }
        public int Size { get { return _size; } set { _size = value; } }
        public int Top { get { return _top; } set { _top = value; } }
        public char Ten { get { return _ten; } set { _ten = value;} }

        public Cot(int numberDisk, char ten)
        {
            _size = numberDisk;
            _ten = ten;
            _disks = new int[numberDisk];
        }

        public void AddDisk(int diskID)
        {
            _disks[_top] = diskID;
            _top++;
        }

        public void MoveADisk(Cot C)
        {
            this._top--;
            WriteLine($"Chuyen dia {this._disks[_top]} tu {this._ten} den {C._ten}");
            C._disks[C._top] = this._disks[this._top];
            C._top++;
        }

        public void MoveManyDisk(int countDisk, Cot B, Cot C)
        {
            if (countDisk == 1) MoveADisk(C);
            else
            {
                MoveManyDisk(countDisk - 1, C, B);
                MoveADisk(C);
                B.MoveManyDisk(countDisk - 1, this, C);
            }
        }
    }
}
