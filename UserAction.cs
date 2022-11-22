using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExerciseOOP_04
{
    internal class UserAction
    {
        public Cot A, B, C;
        private int numberDisk = 5;
        public UserAction() { }

        public void Display()
        {
            A = new Cot(numberDisk, 'A');
            B = new Cot(numberDisk, 'B');
            C = new Cot(numberDisk, 'C');

            int i = numberDisk;
            while(i > 0)
            {
                A.AddDisk(i);
                i--;
            }
            // chuyển đĩa từ cột A sang cột C lấy cột B làm trung gian
            A.MoveManyDisk(numberDisk, B, C);
        }
    }
}
