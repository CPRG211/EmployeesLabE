using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab2.Entities
{
    /// <summary>
    /// Represents a Part-Time Employee
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 27, 2023</remarks>
    internal class PartTime : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for part-time employee.
        private double rate;

        public double Rate
        {
            get { return rate; }
        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="rate"></param>
        public PartTime(string id, string name, double rate)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
        }
    }
}
