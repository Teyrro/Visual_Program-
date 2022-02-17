namespace Laba_1
{

    class HW1
    {
        public static long QueueTime(int[] customers, int n = 2)
        {
            if (n < 1) throw new Exception("Введите корректное количество касс обслуживания");

            int[] cashbox = new int[n];
            int maxTime = 0;

            if (n == 1)
            {
                for (int i = 0; i < customers.Length; i++)
                    maxTime += customers[i];
                return maxTime;
            }

            for (int i = 0; i < n; i++)
            {
                cashbox[i] = 0;
            }

            for (int i = 0; i < customers.Length; i++)
            {
                int min = 0;
                for (int j = 1; j < cashbox.Length; j++)
                {
                    if (cashbox[j] < cashbox[min])
                    {
                        min = j;
                    }

                }
                cashbox[min] += customers[i];
            }

            maxTime = cashbox[0];

            for (int i = 1; i < cashbox.Length; i++)
            {
                if (cashbox[i] > maxTime) maxTime = cashbox[i];
            }

            return maxTime;
        }
    }
}