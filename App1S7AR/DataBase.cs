using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1S7AR
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}
