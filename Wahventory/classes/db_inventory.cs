using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Wahventory.classes
{
    class db_inventory
    {

        public DataTable getStatus()
        {
            Database.set("SELECT * FROM tblstatus ORDER BY status_id ASC;");
            return Database.executeResultSet();
        }

        public DataTable getHolders(Boolean isEmployee)
        {
            String sql = null;
            if (isEmployee == true)
                sql = "SELECT * FROM tblholders WHERE isemployee = 1;";
            else
                sql = "SELECT * FROM tblholders WHERE isemployee = 0;";

            Database.set(sql);
            return Database.executeResultSet();
        }

        public Boolean addHolders(String holderName,String isEmployee)
        {
            Database.set("INSERT INTO tblholders (holder_name,isemployee) VALUES (@holderName,@isEmployee);",new String[]{holderName,isEmployee});
            return Database.executeNonQuery();
        }

        public String getLastHolderId()
        {
            Database.set("SELECT MAX(holder_id) FROM tblholders;");
            return Database.executeString();
        }

        public Boolean insertInventory(String propertyNo, String statusId, String holderId, String dateReceived, String remarks, String itemId,String isReturn)
        {
            Database.set("INSERT INTO tblinventory (property_no,status_id,holder_id,date_received,remarks,item_id,isreturn) VALUES (@a,@b,@c,@d,@e,@f,@g);", new String[]{propertyNo,statusId,holderId,dateReceived,remarks,itemId,isReturn});
            if (Database.executeNonQuery())
            {
                Database.set("UPDATE tblitem SET available = @available WHERE item_id = @itemId;", new String[] { isReturn,itemId });
                return Database.executeNonQuery();
            }

            return false;
        }

        public String getDesLoc(String holderId)
        {
            Database.set("SELECT des_loc FROM tblholders WHERE holder_id = @holderId;",new String[]{holderId});
            return Database.executeString();
        }

        public DataTable getInventory(String isReturn)
        {
            Database.set("SELECT tblinventory.inventory_id,tblinventory.item_id,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS AssignedTo," +
                "DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id)) INNER JOIN tblitem ON tblitem.item_id = tblinventory.item_id) WHERE tblinventory.isreturn = @isReturn ORDER BY tblinventory.inventory_id DESC;", new String[] { isReturn });
            return Database.executeResultSet();
        }


        public DataTable searchInventory(String value,String isReturn)
        {
            Database.set("SELECT tblinventory.inventory_id,tblinventory.item_id,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS AssignedTo," +
                "DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id)) INNER JOIN tblitem ON tblitem.item_id = tblinventory.item_id) WHERE tblinventory.isreturn = @isReturn AND (tblinventory.property_no LIKE '%"+value+"%' OR tblholders.holder_name LIKE '%"+value+"%' OR tblitem.details LIKE '%"+value+"%' OR tbltype.type_name LIKE '%"+value+"%' OR tblinventory.remarks LIKE '%"+value+"%') ORDER BY tblinventory.inventory_id DESC;",new String[]{isReturn});
            return Database.executeResultSet();
        }

        public Boolean insertDispose(String option, String itemId, String holderName,String date, String reason, String remarks,String propertyNo)
        {
            Database.set("INSERT INTO tbldispose (item_id,holder_name,property_no,dispose_option,date_dispose,reason,remarks) VALUES (@itemId,@holderName,@propertyNo,@option,@date,@reason,@remarks);",new String[]{itemId,holderName,propertyNo,option,date,reason,remarks});
            return Database.executeNonQuery();
        }

        public DataTable getDisposedItems()
        {
            Database.set("SELECT tbldispose.dispose_id,tbldispose.item_id,tbldispose.dispose_option,tbldispose.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tbldispose.holder_name AS LastUsedBy,DATE_FORMAT(tbldispose.date_dispose,'%Y-%m-%d') AS DisposedDate,tbldispose.reason AS Reason,tbldispose.remarks AS Remarks FROM ((tbldispose INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tbldispose.item_id)) INNER JOIN tblitem ON tbldispose.item_id = tblitem.item_id) ORDER BY tbldispose.dispose_id DESC;");

            return Database.executeResultSet();
        }

        public DataTable searchDisposeItems(String text)
        {
            Database.set("SELECT tbldispose.dispose_id,tbldispose.item_id,tbldispose.dispose_option,tbldispose.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tbldispose.holder_name AS LastUsedBy,DATE_FORMAT(tbldispose.date_dispose,'%Y-%m-%d') AS DisposedDate,tbldispose.reason AS Reason,tbldispose.remarks AS Remarks FROM ((tbldispose INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tbldispose.item_id)) INNER JOIN tblitem ON tbldispose.item_id = tblitem.item_id) WHERE (tbldispose.property_no LIKE '%"+text+"%' OR tbltype.type_name LIKE '%"+text+"%' OR tblitem.details LIKE '%"+text+"%' OR tbldispose.reason LIKE '%"+text+"%' OR tbldispose.remarks LIKE '%"+text+"%' OR tbldispose.holder_name LIKE '%"+text+"%') ORDER BY tbldispose.dispose_id DESC;");

            return Database.executeResultSet();
        }




    }
}
