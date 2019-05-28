using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SingletonPattern
{
   public class DBTool
    {
        private DBTool() { }

        public static MyDBContext _dbInstance;

        private static object _lockSync = new object();

        public static MyDBContext DBInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    lock (_lockSync)
                    {
                        if (_dbInstance == null)
                        {
                            _dbInstance = new MyDBContext();
                        }
                    }

                }

                return _dbInstance;

            }
        }
    }
}
