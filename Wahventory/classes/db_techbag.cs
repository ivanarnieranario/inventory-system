using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Wahventory.classes
{
    class db_techbag
    {
        public DataTable getBags()
        {
            Database.set("SELECT * FROM tblbags;");
            return Database.executeResultSet();
        }



        public Boolean insertTechBag(String bagName)
        {
            Database.set("INSERT INTO tblbags (bag_name) VALUES (@bagName);",new String[]{bagName});
            return Database.executeNonQuery();
        }

        public String getLastInserted()
        {
            Database.set("SELECT MAX(bag_id) FROM tblbags;");
            return Database.executeString();
        }

        public Boolean insertBagItem(String itemId, String bagId, String quantity,String propertyNo)
        {
            Database.set("SELECT bagitem_id FROM tblbagitem WHERE item_id = @itemId AND bag_id = @bagId;",new String[]{itemId,bagId});
            String bagItemId = Database.executeString();

            if (bagItemId != "")
            {
                Database.set("UPDATE tblbagitem SET quantity = quantity + @quantity WHERE bagitem_id = @bagItemId;", new String[] { quantity,bagItemId });
                return Database.executeNonQuery();
            }
            else
            {
                Database.set("INSERT INTO tblbagitem (item_id,bag_id,quantity,property_no,status,item_condition) VALUES (@itemId,@bagId,@quantity,@propertyNo,@status,@itemCondition);", new String[] { itemId, bagId, quantity, propertyNo ,"IN","OK"});
                if (Database.executeNonQuery())
                {
                    Database.set("UPDATE tblitem SET tblitem.available = 0 WHERE item_id = @itemId;", new String[] { itemId });
                    return Database.executeNonQuery();
                }
            }
            return false;
        }


        public DataTable getTechBagItems(String bagId)
        {
            Database.set("SELECT tblbagitem.bagitem_id,tblitem.item_id,tblbagitem.property_no,tblbagitem.quantity AS QTY,tbltype.type_name AS Type,tblitem.details AS Details,tblitem.date_procured AS DateProcured,tblfrom.from_name,tblbagitem.status,tblbagitem.item_condition FROM ((((tblbagitem INNER JOIN tblitem ON tblbagitem.item_id = tblitem.item_id) INNER JOIN tblfrom ON tblfrom.from_id = tblitem.from_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) LEFT JOIN tbldepreciation ON tbldepreciation.depreciation_id = tblitem.depreciation_id) WHERE tblbagitem.bag_id = @bagId ORDER BY tblbagitem.bagitem_id DESC;",new String[]{bagId});
            return Database.executeResultSet();
        }



        public Boolean insertTechBagInfo(String holderId, String bagId, String travelLocation, String fromDate, String toDate)
        {
            Database.set("INSERT INTO tbltravelinfo (holder_id,bag_id,travel_location,from_date,to_date) VALUES (@holderId,@bagId,@travelLocation,@fromDate,@toDate);",new String[]{holderId,bagId,travelLocation,fromDate,toDate});
            return Database.executeNonQuery();
        }


        public String getLastInfoId()
        {
            Database.set("SELECT MAX(travelinfo_id) FROM tbltravelinfo;");
            return Database.executeString();
        }

        public Boolean insertTechBagLogs(String bagItemId,String action, String infoId, String itemId, String propertyNo, String condition, String quantity,String bagName)
        {
            Database.set("INSERT tbltechbag (action_bag,travelinfo_id,item_id,property_no,item_condition,quantity) VALUES (@a,@b,@c,@d,@e,@f);",new String[]{action,infoId,itemId,propertyNo,condition,quantity});
            if (Database.executeNonQuery())
            {
                String sql = null;
                if (action == "Release")
                    sql = "UPDATE tblbagitem SET status = 'OUT' WHERE bagitem_id = @bagItemId;";
                else
                    sql = "UPDATE tblbagitem SET status = 'IN' WHERE bagItem_id = @bagItemId;";

                Database.set(sql,new String[]{bagItemId});
                if (Database.executeNonQuery())
                {
                    if (action == "Return")
                    {
                        if (condition == "LOST")
                        {
                            Database.set("DELETE FROM tblbagitem WHERE bagitem_id = @bagItemId;",new String[]{bagItemId});
                            if (Database.executeNonQuery())
                            {
                                Database.set("INSERT INTO tbldispose (item_id,holder_name,property_no,dispose_option,date_dispose,remarks) VALUES (@a,@b,@c,@d,@e,@f);",new String[]{itemId,bagName,propertyNo,"3",DateTime.Now.ToString("yyyy-MM-dd"),"Techbag"});
                                Database.executeNonQuery();
                            }
                        }

                        Database.set("UPDATE tbltravelinfo SET isdone = 1 WHERE travelinfo_id = @infoId;", new String[] { infoId });
                        if (Database.executeNonQuery())
                        {
                            Database.set("UPDATE tblbagitem SET quantity = @quantity WHERE bagitem_id = @bagItemId;",new String[]{quantity,bagItemId});
                            return Database.executeNonQuery();
                        }
                    }
                    return true;
                }
            }
            return false;
        }


        public DataTable getTravelInfo()
        {
            Database.set("SELECT tbltravelinfo.travelinfo_id,tblholders.holder_name AS Employee,tblbags.bag_name AS Bag,tbltravelinfo.travel_location AS Destination,tbltravelinfo.from_date AS DateReleased,tbltravelinfo.to_date AS DateReturned,tblbagitem.status AS STATUS FROM (((tbltravelinfo INNER JOIN tblholders ON tbltravelinfo.holder_id = tblholders.holder_id) INNER JOIN tblbags ON tbltravelinfo.bag_id = tblbags.bag_id) INNER JOIN tblbagitem ON tblbagitem.bagitem_id = (SELECT tblbagitem.bagitem_id FROM tblbagitem WHERE tblbagitem.bag_id = tbltravelinfo.bag_id ORDER BY tblbagitem.bagitem_id DESC LIMIT 1)) WHERE tblbagitem.status = 'OUT' AND tbltravelinfo.isdone = 0 ORDER BY tbltravelinfo.travelinfo_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable getItemsByTravelInfo(String travelInfoId)
        {
            Database.set("SELECT tblbagitem.item_id,tblbagitem.bagitem_id,tblbagitem.property_no,tblbagitem.quantity AS QTY,tbltype.type_name AS Type,tblitem.details AS Details FROM ((tblbagitem INNER JOIN tblitem ON tblbagitem.item_id = tblitem.item_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) WHERE tblbagitem.bag_id = (SELECT tbltravelinfo.bag_id FROM tbltravelinfo WHERE tbltravelinfo.travelinfo_id = @travelInfoId);", new String[] { travelInfoId });
            return Database.executeResultSet();
        }



        public DataTable getTravelRecords()
        {
            Database.set("SELECT tbltravelinfo.travelinfo_id,tblholders.holder_name AS Employee,tblbags.bag_name AS Bag,tbltravelinfo.travel_location AS Destination,tbltravelinfo.from_date AS DateReleased,tbltravelinfo.to_date AS DateReturned,tbltravelinfo.isdone FROM ((tbltravelinfo INNER JOIN tblholders ON tbltravelinfo.holder_id = tblholders.holder_id) INNER JOIN tblbags ON tbltravelinfo.bag_id = tblbags.bag_id) ORDER BY tbltravelinfo.travelinfo_id DESC;");
            return Database.executeResultSet();
        }


        public DataTable getTravelRecordsItem(String action,String infoId)
        {
            Database.set("SELECT tbltechbag.property_no,tbltype.type_name AS Type,tblitem.details AS Details,tbltechbag.quantity AS QTY,tbltechbag.item_condition FROM ((tbltechbag INNER JOIN tblitem ON tbltechbag.item_id = tblitem.item_id) INNER JOIN tbltype ON tbltype.type_id = (SELECT tblitemtype.type_id FROM tblitemtype WHERE tblitemtype.item_id = tblitem.item_id)) WHERE tbltechbag.travelinfo_id = @infoId AND tbltechbag.action_bag = '"+action+"' ORDER BY tbltechbag.item_id;",new String[]{infoId});
            return Database.executeResultSet();
        }

        public DataTable searchTravelRecords(String value)
        {
            Database.set("SELECT tbltravelinfo.travelinfo_id,tblholders.holder_name AS Employee,tblbags.bag_name AS Bag,tbltravelinfo.travel_location AS Destination,tbltravelinfo.from_date AS DateReleased,tbltravelinfo.to_date AS DateReturned,tbltravelinfo.isdone FROM ((tbltravelinfo INNER JOIN tblholders ON tbltravelinfo.holder_id = tblholders.holder_id) INNER JOIN tblbags ON tbltravelinfo.bag_id = tblbags.bag_id) WHERE (tblholders.holder_name LIKE '%"+value+"%' OR tblbags.bag_name LIKE '%"+value+"%' OR tbltravelinfo.travel_location LIKE '%"+value+"%') ORDER BY tbltravelinfo.travelinfo_id DESC;");
            return Database.executeResultSet();
        }

        public DataTable filterTravelRecords(String from, String to,Boolean isReleased)
        {
            using (MySql.Data.MySqlClient.MySqlConnection con = Database.getConnection())
            {
                try
                {
                    DataTable table = new DataTable();
                    String sql = null;

                    if(isReleased)
                        sql = "SELECT tbltravelinfo.travelinfo_id,tblholders.holder_name AS Employee,tblbags.bag_name AS Bag,tbltravelinfo.travel_location AS Destination,tbltravelinfo.from_date AS DateReleased,tbltravelinfo.to_date AS DateReturned,tbltravelinfo.isdone FROM ((tbltravelinfo INNER JOIN tblholders ON tbltravelinfo.holder_id = tblholders.holder_id) INNER JOIN tblbags ON tbltravelinfo.bag_id = tblbags.bag_id) WHERE (tbltravelinfo.from_date >= @from AND tbltravelinfo.from_date <= @to) ORDER BY tbltravelinfo.travelinfo_id DESC;";
                    else
                        sql = "SELECT tbltravelinfo.travelinfo_id,tblholders.holder_name AS Employee,tblbags.bag_name AS Bag,tbltravelinfo.travel_location AS Destination,tbltravelinfo.from_date AS DateReleased,tbltravelinfo.to_date AS DateReturned,tbltravelinfo.isdone FROM ((tbltravelinfo INNER JOIN tblholders ON tbltravelinfo.holder_id = tblholders.holder_id) INNER JOIN tblbags ON tbltravelinfo.bag_id = tblbags.bag_id) WHERE (tbltravelinfo.to_date >= @from AND tbltravelinfo.to_date <= @to) ORDER BY tbltravelinfo.travelinfo_id DESC;";

                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, con);
                    command.Parameters.AddWithValue("@from", from);
                    command.Parameters.AddWithValue("@to", to);
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
    }
}
