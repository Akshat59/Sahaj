using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared
{
    class testPR
    {
       // int a = 1;
        //int b = 2;
        int c = 4;

        

        public void findSum(int a,int b, ref int c, params int[] qq)
        {
            int d = c;
        }

        public void test()
        {
            findSum(1,2,ref c,new int[] { 1,2,3});
        }

    }
}
