using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab2.Entities
{
    /// <summary>
    /// Represents an Employee
    /// </summary>
    /// <remarks>Author: Nick Hamnett</remarks>
    /// <remarks>Date: Jan 27, 2023</remarks>
    internal class Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for general employee.
        protected string id;
        protected string name;

        public string Id
        {
            get { return id; }
        }

        public string Name
        {
            get => name;
        }

        /// <summary>
        /// No-arg constructor
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Employee(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
