using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2811
{
    public class Singleton
    {
        // 1
        private static Singleton INSTANCE;

        List<DbConnections> dbConnections;

        // 2 private
        private Singleton()
        {

        }

        // 3 - get instance
        public static Singleton GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Singleton();
            }
            return INSTANCE;
        }

        public DbConnections GetConnection()
        {
            // check if there are free connections ...
            DbConnections conn = dbConnections[0];
            dbConnections.RemoveAt(0);
            return conn;

        }
        public void RetutnConnection(DbConnections db)
        {
            dbConnections.Add(db);
        }
    }
}
