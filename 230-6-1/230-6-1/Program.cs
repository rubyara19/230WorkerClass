using System;
namespace _230_6_1{

internal class Program
    {


        static void LoadData(string path, List<Employee> employees)
        {

            string[] parts;
            string[] separatorsForSalary = { " ", "\t", "\t", "\t" };
            string[] separatorsForHourlyandPiece = { " ", "\t", "\t", "\t", "\t" };
            string[] separatorsForCommission = { " ", "\t", "\t", "\t", "\t", "\t" };

            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        String line;
                        while (!sr.EndOfStream)
                        {

                            line = sr.ReadLine();
                            Console.WriteLine(line);

                            if (line[0] == 'S')
                            {
                                parts = line.Split(separatorsForSalary, StringSplitOptions.RemoveEmptyEntries);
                                employees.Add(new SalaryWorker(int.Parse(parts[1]), parts[2], parts[3], float.Parse(parts[4])));

                            }

                            else if (line[0] == 'H')
                            {
                                parts = line.Split(separatorsForHourlyandPiece, StringSplitOptions.RemoveEmptyEntries);
                                employees.Add(new HourlyWorker(int.Parse(parts[1]), parts[2], parts[3], float.Parse(parts[4]), float.Parse(parts[5])));
                            }

                            else if (line[0] == 'C')
                            {
                                parts = line.Split(separatorsForCommission, StringSplitOptions.RemoveEmptyEntries);
                                employees.Add(new CommissionWorker(int.Parse(parts[1]), parts[2], parts[3], float.Parse(parts[4]), float.Parse(parts[5]), float.Parse(parts[6])));

                            }

                            else if (line[0] == 'P')
                            {

                                parts = line.Split(separatorsForHourlyandPiece, StringSplitOptions.RemoveEmptyEntries);
                                employees.Add(new HourlyWorker(int.Parse(parts[1]), parts[2], parts[3], float.Parse(parts[4]), float.Parse(parts[5])));
                            }
                        }
                    }
                    Console.WriteLine("\nData Loaded Successfully!\n");
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read.");
            }

        }


        static void PrintReport(String report, List<Employee> employees)
        {
            try
            {
                using (StreamWriter sWriter = new StreamWriter(report))
                {
                    Console.WriteLine("Employee Type       ID   Last        First       Weekly Pay");
                    sWriter.WriteLine("Employee Type       ID   Last        First       Weekly Pay");

                    foreach (Employee e in employees)
                    {

                        Console.WriteLine(e.earnings());
                        sWriter.WriteLine(e.earnings());

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }



        static void Main(string[] args)
        {
            String path = "C:\\Users\\piano\\source\\repos\\230WorkerClass\\230-6-1\\230-6-1\\workers.txt";
            List<Employee> employees = new List<Employee>();

            LoadData(path, employees);

            String report = "C:\\Users\\piano\\source\\repos\\230WorkerClass\\230-6-1\\230-6-1\\output.txt";
            PrintReport(report, employees);


        }




    }
}