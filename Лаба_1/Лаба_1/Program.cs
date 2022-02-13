using Laba_1;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            HW1 test = new HW1();

            Console.Write("Введите кол-во касс: ");
            int cashbox = Convert.ToInt32(Console.ReadLine());

            int[] a = { 5, 3, 4 };
            Console.WriteLine("Очередь: {0}, {1}, {2}", a[0], a[1], a[2]);

            try
            {
                int WasteTime = ((int)test.QueueTime(a, cashbox));
                Console.WriteLine(
                    $"Время затраченное на всех покупателей:  {WasteTime}"
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
