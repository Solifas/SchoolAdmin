namespace SchoolAdminSystem.Utilities
{
    public static class SqlHelper
    {
        private static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=School System;Trusted_Connection=True;MultipleActiveResultSets=true";
        public static string ConnectionString
        {
            get => connectionString;
        }
    }
}
