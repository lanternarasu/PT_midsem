using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public abstract class allclass
    {
        public string reg_no, name, course, sub_name;
        public int year;
        public abstract int calculate(int a, int b, int c, int d, int e);
    }
    public class ug_internals : allclass
    {
        public int test1, test2, test3, assignment, attendance, total;

        public override int calculate(int a, int b, int c, int d, int e)
        {
            return ((a + b + c) / 3 + d + e);
        }
    }
    public class pg_internals : allclass
    {
        public int test1, test2, assignment, attendance;

        public override int calculate(int a, int b, int c, int d, int e)
        {
            return a + b / 2;
        }
    }
}