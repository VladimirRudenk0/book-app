using BookApp.ADO;

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
