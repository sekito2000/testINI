using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testProj2
{
    class BoundArray
    {
        int[] array;
        int lower;  //配列添字の下限

        //ｺﾝｽﾄﾗｸﾀ
        public BoundArray(int lower, int upper)
        {
            this.lower = lower;
            array = new int[upper - lower + 1];
        }
            
        //ｲﾝﾃﾞｸｻ【ﾌﾟﾛﾊﾟﾃｨに似ているがthis[]を使うこと。】
     public int this[int i]
     {
         set { this.array[i - lower] = value; }
         get{return this.array[i-lower];}
     }
    }
}
