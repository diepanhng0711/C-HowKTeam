namespace Bai4_Static
{

    class TienIch
    {
        public static long LuyThua (int coSo, int soMu)
        {
            long KetQua = 1;

            for (int i = 0; i < soMu; i++) {
                KetQua *= coSo;
            }

            return KetQua;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TienIch.LuyThua(5, 3));

            Console.ReadKey();

        }
    }
}