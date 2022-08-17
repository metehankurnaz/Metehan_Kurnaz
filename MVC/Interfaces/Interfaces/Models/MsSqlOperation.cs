using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class MsSqlOperation : Test, ISqlOperation, ITestInterface
    {
        public void Connection()
        {
            Console.WriteLine("MsSql için bağlantı sağlandı.");
        }

        public bool Insert(Products products)
        {
            return true;
        }
    }

    public class MySqlOperation : ISqlOperation
    {
        public void Connection()
        {
            Console.WriteLine("MySql bağlantısı sağlandı.");
        }

        public bool Insert(Products products)
        {
            return true;
        }
    }


    public interface ISqlOperation
    {
        void Connection();
        bool Insert(Products products);
    }

    public interface ITestInterface
    {

    }

    public class Test
    {

    }
}
