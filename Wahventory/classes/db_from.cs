using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Wahventory.classes
{
    class db_from
    {
        public String FromName { set; private get; }

        public DataTable getFroms()
        {
            Database.set("SELECT * FROM tblfrom;");
            return Database.executeResultSet();
        }

        public Boolean addFrom()
        {
            Database.set("INSERT INTO tblfrom (from_name) VALUES (@fromName);",new String[]{FromName});
            return Database.executeNonQuery();
        }

        public String getLastInserted()
        {
            Database.set("SELECT MAX(from_id) FROM tblfrom;");
            return Database.executeString();
        }

    }
}
