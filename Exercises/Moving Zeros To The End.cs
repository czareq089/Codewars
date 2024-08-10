//--------------------------------------------------------------------------------------
                                //Moving Zeros To The End
//--------------------------------------------------------------------------------------

namespace codewars.Exercises;

using System.Collections;
using System.Linq;
public static partial class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        ArrayList nz = new ArrayList();
        int zc = 0;
        int[] ar = new int[arr.Length];
        foreach (var i in arr)
        {
            if(i!=0)
            {
                nz.Add(i);
            }
            else
            {
                zc++;
            }
        }
        for (int i = 0; i < zc; i++)
        {
            nz.Add(0);
        }
    
        ar = nz.OfType<int>().ToArray();
        return ar;
    }
}