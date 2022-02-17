using Laba_1;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите кол-во касс обслуживания: ");
            int cashbox = Convert.ToInt32(Console.ReadLine());

            int[] a = { 5, 3, 4 };
            Console.WriteLine("Очередь: {0}, {1}, {2}", a[0], a[1], a[2]);

            try
            {
                Console.WriteLine(
                    $"Время затраченное на всех покупателей:  {HW1.QueueTime_2(a, cashbox)}"
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
