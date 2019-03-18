using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityCyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi1 = new int[3] { 0, 0, 0 };
            int[] dizi2 = new int[4] { 1, 2, 3, 4 };
            int[] dizi3 = new int[5] { 3, 8, 9, 7, 6 };
            int[] dizi4 = null;
            int[] dizi5 = new int[] { };
            int[] dizi6 = new int[1] { 1 };
            int[] dizi7 = new int[7] { 2, 3, 1, 5, 6, 7, 0 };
            var dizi1sonuc = solution(dizi1, 4);
            var dizi2sonuc = solution(dizi2, 4);
            var dizi3sonuc = solution(dizi3, 3);
            var dizi4sonuc = solution(dizi4, 3);
            var dizi5sonuc = solution(dizi5, 3);
            var dizi6sonuc = solution(dizi6, 3);
            var dizi7sonuc = solution(dizi7, 4);

            Console.ReadLine();
        }

        static int[] solution(int[] A, int K)
        {
            if (A == null)
                return A;

            if (A.Length > 100 || K > 100 || A.Length < 0 || K < 0)
                return A;

            bool veriVarmi = A.Any();
            if (veriVarmi)
            {
                if (A.Max() > 1000 || A.Min() < -1000)
                    return A;
            }
            else
                return A;

            if (A.Length == K || A.Length == 0)
                return A;

            //Dizinin elamanlarının hepsi eşit ise.
            var aElamanKontrol = true;
            var length = A.Length;
            for (int i = 1; i < length; i++)
            {
                if (A[0] != A[i])
                {
                    aElamanKontrol = false;
                    break;
                }
            }
            if (aElamanKontrol)
                return A;

            K = K % A.Length;

            Array.Reverse(A);
            Array.Reverse(A, 0, K);
            Array.Reverse(A, K, A.Length - K);
            return A;
        }
    }
}
