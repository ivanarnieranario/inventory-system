using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Wahventory.classes
{
    class db_reports
    {
        public DataTable getAllReports()
        {
            Database.set("SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type ,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) ORDER BY tblinventory.inventory_id DESC;");
            return Database.executeResultSet();
        }

        public DataTable filterByHolder(String holderId)
        {
            Database.set("SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblinventory.holder_id = @holderId ORDER BY tblinventory.inventory_id DESC;", new String[] { holderId });
            return Database.executeResultSet();
        }


        public DataTable filterByDate(String from, String to,Boolean isProcured,String holderId)
        {
            using (MySql.Data.MySqlClient.MySqlConnection con = Database.getConnection())
            {
                try
                {
                    String sql = null;
                    DataTable table = new DataTable();
                    con.Open();
                    String condition = "";
                    if (holderId != "")
                        condition = "WHERE tblinventory.holder_id = " + holderId;

                    if (isProcured)
                        sql = "SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id AND (tblitem.date_procured >= @from AND tblitem.date_procured <= @to)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) " + condition + " ORDER BY tblinventory.inventory_id DESC;";
                    else
                        sql = "SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id AND (tblinventory.date_received >= @from AND tblinventory.date_received <= @to)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) " + condition + " ORDER BY tblinventory.inventory_id DESC;";

                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                    command.Parameters.AddWithValue("@from",from);
                    command.Parameters.AddWithValue("@to",to);
                    MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(command);
                    adapter.Fill(table);
                    return table;
                }
                catch (MySql.Data.MySqlClient.MySqlException exception)
                {
                    System.Windows.Forms.MessageBox.Show(exception.Message);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        }


        public DataTable searchReturnReports(String value,String holderId)
        {
            String condition = "";
            if (holderId != "")
                condition = "AND tblinventory.holder_id = " + holderId;

            Database.set("SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE (tblinventory.property_no LIKE '%" + value + "%' OR tblinventory.remarks LIKE '%" + value + "%' OR tblitem.details LIKE '%" + value + "%' OR tbltype.type_name LIKE '%" + value + "%' OR tblholders.holder_name LIKE '%" + value + "%') " + condition + " ORDER BY tblinventory.inventory_id DESC;");
            return Database.executeResultSet();
        }

        public DataTable getWahOfficeOnly(String holderId)
        {
            String condition = "";
            if (holderId != "")
                condition = "AND tblinventory.holder_id = " + holderId;

            Database.set("SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblinventory.date_received = '0000-00-00' " + condition + " ORDER BY tblinventory.inventory_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable filterByItems(String itemId)
        {
            Database.set("SELECT tblinventory.inventory_id,tbldepreciation.depreciation_id,tblitem.price,tblinventory.isreturn AS Action,tblinventory.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tblholders.holder_name,tblitem.date_procured AS DateProcured,DATE_FORMAT(tblinventory.date_received,'%Y-%m-%d') AS DateReceived,tblstatus.status_name AS Status,tblinventory.remarks AS Remarks,tblinventory.islost FROM ((((tblinventory INNER JOIN tblstatus ON tblinventory.status_id = tblstatus.status_id) INNER JOIN tblholders ON tblinventory.holder_id = tblholders.holder_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblinventory.item_id) INNER JOIN tblitem ON tblinventory.item_id = tblitem.item_id) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE tblinventory.item_id = @itemId ORDER BY tblinventory.inventory_id DESC;", new String[] { itemId });
            return Database.executeResultSet();
        }


        public DataTable getAllItems()
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation,tbldepreciation.lifespan AS Lifespan,tbldepreciation.book_value AS CurrentBookValue,current_percent AS CurrentPercent FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) ORDER BY tblitem.item_id DESC;");
            return Database.executeResultSet();
        }

        public DataTable searchAllItems(String value)
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation,tbldepreciation.lifespan AS Lifespan,tbldepreciation.book_value AS CurrentBookValue,current_percent AS CurrentPercent FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE (tbltype.type_name LIKE '%" + value + "%' OR tblitem.details LIKE '%" + value + "%' OR tblitem.date_procured LIKE '%" + value + "%' OR tblfrom.from_name LIKE '%" + value + "%' OR tblitem.property_no LIKE '%"+value+"%') ORDER BY tblitem.item_id DESC;");
            return Database.executeResultSet();
        }

        public DataTable filterItemPercent(String percent)
        {
            Database.set("SELECT tblitem.item_id AS ID,tblitem.depreciation_id,tblitem.available AS _,tblitem.property_no,tbltype.type_name AS Type,tblitem.details AS Details,DATE_FORMAT(tblitem.date_procured,'%Y-%m-%d') AS DateProcured,tblitem.isdonated AS Method,tblfrom.from_name,tblitem.price AS COST,tbldepreciation.depreciation AS Depreciation,tbldepreciation.lifespan AS Lifespan,tbldepreciation.book_value AS CurrentBookValue,current_percent AS CurrentPercent FROM (((tblitem INNER JOIN tblfrom ON tblitem.from_id = tblfrom.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tblitem.depreciation_id = tbldepreciation.depreciation_id) WHERE current_percent <= @percentage OR current_percent IS NULL ORDER BY tblitem.item_id DESC;", new String[] { percent });
            return Database.executeResultSet();
        }


        public DataTable filterDisposeByDate(String from, String to)
        {
            Database.set("SELECT tbldispose.dispose_id,tbldispose.item_id,tbldispose.dispose_option,tbldispose.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tbldispose.holder_name AS LastUsedBy,DATE_FORMAT(tbldispose.date_dispose,'%Y-%m-%d') AS DisposedDate,tbldispose.reason AS Reason,tbldispose.remarks AS Remarks FROM ((tbldispose INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tbldispose.item_id)) INNER JOIN tblitem ON tbldispose.item_id = tblitem.item_id) WHERE (tbldispose.date_dispose >= @from AND tbldispose.date_dispose <= @to ) ORDER BY tbldispose.dispose_id DESC;",new String[]{from,to});
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
    }
}
