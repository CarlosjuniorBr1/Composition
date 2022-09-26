namespace Course.Entities
{
    internal class WorkerBase
    {

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue;
                }

            }
        }
    }
}