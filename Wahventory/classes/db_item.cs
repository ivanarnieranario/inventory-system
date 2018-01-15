using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Wahventory.classes
{
    class db_item
    {

        public Boolean addItem(String isDonated, String price, String details, String depreciationId, String dateProcured, String fromId,String propertyNo)
        {
            Database.set("INSERT INTO tblitem (isdonated,price,details,depreciation_id,date_procured,available,from_id,property_no) VALUES (@a,@b,@c,@d,@e,@f,@g,@h);",new String[]{isDonated,price,details,depreciationId,dateProcured,"1",fromId,propertyNo});
            return Database.executeNonQuery();
        }

        public DataTable getItems(Boolean isShowAll)
        {
            String sql = null;

            if (isShowAll)
                sql = "SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) ORDER BY tblitem.item_id DESC;";
            else
                sql = "SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND available = 1 ORDER BY tblitem.item_id DESC;";

            Database.set(sql);
            return Database.executeResultSet();
        }

        public DataTable filterItemsByFrom(String fromId,Boolean showAll)
        {
            String condition = "";
            if (!showAll)
                condition = "AND tblitem.available = 1";

            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.from_id = @fromId " + condition + " ORDER BY tblitem.item_id DESC;", new String[] { fromId });
            return Database.executeResultSet();
        }

        public DataTable searchByFrom(String fromId,String text)
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id) AND (tbltype.type_name LIKE '%" + text + "%' OR tblitem.details LIKE '%" + text + "%' OR tblitem.date_procured LIKE '%" + text + "%'))  LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.from_id = @fromId ORDER BY tblitem.item_id DESC;", new String[] { fromId });
            return Database.executeResultSet();
        }



        public DataTable filterByTechbags(String fromId)
        {
            String condition = "";
            if (fromId != "")
                condition = "AND tblitem.from_id = " + fromId;

            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) " + condition + " ORDER BY tblitem.item_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable searchByTechBags(String fromId,String text)
        {
            String condition = "";
            if (fromId != "")
                condition = "AND tblitem.from_id = " + fromId;

            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id) AND (tbltype.type_name LIKE '%" + text + "%' OR tblitem.details LIKE '%" + text + "%' OR tblitem.date_procured LIKE '%" + text + "%'))  LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) "+condition+" ORDER BY tblitem.item_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable searchItem(Boolean isShowAll,String text)
        {
            String sql = null;

            if (isShowAll)
                sql = "SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id) AND (tbltype.type_name LIKE '%" + text + "%' OR tblitem.details LIKE '%" + text + "%' OR tblitem.date_procured LIKE '%" + text + "%' OR tblitem.property_no LIKE '%"+text+"%'))  LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) ORDER BY tblitem.item_id DESC;";

            else
                sql = "SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id) AND (tbltype.type_name LIKE '%" + text + "%' OR tblitem.details LIKE '%" + text + "%' OR tblitem.date_procured LIKE '%" + text + "%' OR tblitem.property_no LIKE '%"+text+"%'))  LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblitem.available = 1 AND tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) ORDER BY tblitem.item_id DESC;";

            Database.set(sql);
            return Database.executeResultSet();
        }


        public String getLastInserted()
        {
            Database.set("SELECT MAX(item_id) FROM tblitem;");
            return Database.executeString();
        }


        public DataTable getNotReturned()
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblitem.date_procured AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE available = 0 ORDER BY tblitem.item_id DESC;");
           return Database.executeResultSet();
        }



        public DataTable getReturnItems()
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblholders.holder_id,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS ReceivedBy,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM tblholders,tblinventory,(((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE available = 0 AND (tblinventory.inventory_id = (SELECT tblinventory.inventory_id FROM tblinventory WHERE tblinventory.item_id = tblitem.item_id AND tblinventory.isreturn = 0 ORDER BY tblinventory.inventory_id DESC LIMIT 1) AND tblholders.holder_id = tblinventory.holder_id) AND tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.item_id NOT IN (SELECT tblbagitem.item_id FROM tblbagitem) ORDER BY tblitem.item_id DESC;");

            return Database.executeResultSet();
        }

        public DataTable searchReturnItems(String value)
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblholders.holder_id,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS ReceivedBy,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM tblholders,tblinventory,(((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id AND (tbltype.type_name LIKE '%" + value + "%' OR tblitem.details LIKE '%" + value + "%' OR tblholders.holder_name LIKE '%" + value + "%' OR tblitem.property_no LIKE '%" + value + "%'))) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE available = 0 AND (tblinventory.inventory_id = (SELECT tblinventory.inventory_id FROM tblinventory WHERE tblinventory.item_id = tblitem.item_id AND tblinventory.isreturn = 0 ORDER BY tblinventory.inventory_id DESC LIMIT 1) AND tblholders.holder_id = tblinventory.holder_id) AND tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.item_id NOT IN (SELECT tblbagitem.item_id FROM tblbagitem) ORDER BY tblitem.item_id DESC;");

            return Database.executeResultSet();
        }


        //Lost and Dispose items

        public DataTable getItems()
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblinventory.isreturn,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS LastUsedBy,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) INNER JOIN tblholders ON tblholders.holder_id = (SELECT tblinventory.holder_id FROM tblinventory WHERE tblinventory.item_id = tblitem.item_id ORDER BY tblinventory.inventory_id DESC LIMIT 1)) INNER JOIN tblinventory ON tblinventory.inventory_id = (SELECT tblinventory.inventory_id FROM tblinventory WHERE tblinventory.holder_id = tblholders.holder_id AND tblinventory.item_id = tblitem.item_id ORDER BY tblinventory.inventory_id DESC LIMIT 1))  WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.item_id NOT IN (SELECT tblbagitem.item_id FROM tblbagitem) ORDER BY tblitem.item_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable searchDisposeItems(String text)
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblinventory.isreturn,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name AS LastUsedBy,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation FROM (((((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) INNER JOIN tblholders ON tblholders.holder_id = (SELECT tblinventory.holder_id FROM tblinventory WHERE tblinventory.item_id = tblitem.item_id ORDER BY tblinventory.inventory_id DESC LIMIT 1)) INNER JOIN tblinventory ON tblinventory.inventory_id = (SELECT tblinventory.inventory_id FROM tblinventory WHERE tblinventory.holder_id = tblholders.holder_id AND tblinventory.item_id = tblitem.item_id ORDER BY tblinventory.inventory_id DESC LIMIT 1))  WHERE tblitem.item_id NOT IN (SELECT tbldispose.item_id FROM tbldispose) AND tblitem.item_id NOT IN (SELECT tblbagitem.item_id FROM tblbagitem) AND (tblinventory.property_no LIKE '%" + text + "%' OR tbltype.type_name LIKE '%" + text + "%' OR tblitem.details LIKE '%" + text + "%' OR tblfrom.from_name LIKE '%" + text + "%') ORDER BY tblitem.item_id DESC;");

            return Database.executeResultSet();
        }








    }
}
