﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMDAPPER
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
        void CreateDepartment(string Name);
    }
}
