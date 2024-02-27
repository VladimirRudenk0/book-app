using BookApp.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Services
{
    public class BaseService
    {
        /// <summary>
        /// Точка входа ADO. Используйте ее для взаимодействия с БД.
        /// </summary>
        protected readonly AdoEntities db = new AdoEntities();
    }
}
