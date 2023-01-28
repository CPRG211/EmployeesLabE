using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG211E_Lab2.Entities;

namespace CPRG211E_Lab2
{
    /// <summary>
    /// CPRG211 Lab 2: Inheritance
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Relative path to employees.txt file
            string path = "employees.txt";

            // Get lines/rows in file as string array
            string[] lines = File.ReadAllLines(path);

            // Create list that holds any type of Employee
            List<Employee> employees = new List<Employee>();

            // Loop through each line/row
            foreach (string line in lines)
            {
                // Extract each part/cell from line/row
                string[] parts= line.Split(':');

                // First part is ID
                string id = parts[0];

                // Second part is name
                string name = parts[1];

                // TODO: Get remaining employee info from parts

                // Get first digit of ID
                string firstDigit;

                firstDigit = id.Substring(0, 1);

                /*if (firstDigit == "0" || firstDigit == "1" || firstDigit == "2" || firstDigit == "3" || firstDigit == "4")
                {

                }*/

                // Convert first digit from string to int.
                int firstDigitNum = int.Parse(firstDigit);

                // Test what range first digit falls into
                if (firstDigitNum >= 0 && firstDigitNum <= 4)
                {
                    // Salaried
                    double salary = double.Parse(parts[7]);

                    // Create instance of Salaried
                    Salaried salaried;

                    salaried = new Salaried(id, name, salary);

                    // Add to employees
                    employees.Add(salaried);
                }
                else if (firstDigitNum >= 5 && firstDigitNum <= 7)
                {
                    // Part time

                    // TODO: Create PartTime instance and add it to employee list.
                }
                else if (firstDigitNum >= 8 && firstDigitNum <= 9)
                {
                    // Waged

                    // TODO: Create Waged instance and add it to employee list.
                }

                /**
                 * TODO:
                 *  - Determine average weekly pay of all employees.
                 *  - Determine highest paid waged employee.
                 *  - Determine lowest paid salaried employee.
                 *  - Determine percentage of employees that are salaried, waged, and part-time.
                 */

                // It's okay to use loop through employees multiple times.
                foreach (Employee employee in employees)
                {
                }
            }

        }
    }
}
