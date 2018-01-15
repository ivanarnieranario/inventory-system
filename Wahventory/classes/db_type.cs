using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Wahventory.classes
{
    class db_type
    {
        public String TypeName { set; private get; }

        public DataTable getType()
        {
            Database.set("SELECT * FROM tbltype;");
            return Database.executeResultSet();
        }

        public Boolean addType()
        {
            Database.set("INSERT INTO tbltype (type_name) VALUES (@typeName);", new String[] { TypeName });
            return Database.executeNonQuery();
        }

        public String getLastinserted()
        {
            Database.set("SELECT MAX(type_id) FROM tbltype;");
            return Database.executeString();
        }


        public Boolean insertItemType(String typeId, String itemId)
        {
            Database.set("INSERT tblitemtype (type_id,item_id) VALUES (@typeId,@itemId);",new String[]{typeId,itemId});
            return Database.executeNonQuery();
        }

    }
}
