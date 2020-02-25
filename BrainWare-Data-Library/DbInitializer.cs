using System;

namespace BrainWare.Data.Library
{
    /// <summary>
    /// DB Initializer
    /// </summary>
    public static class DbInitializer
    {
        private static DBContext _dbContext;
        /// <summary>Initializes the specified service provider.</summary>
        /// <param name="serviceProvider">The service provider.</param>
        public static void Initialize(IServiceProvider serviceProvider)
        {
            _dbContext = (DBContext)serviceProvider.GetService(typeof(DBContext));
        }
    }
}
