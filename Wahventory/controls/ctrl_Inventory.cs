using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wahventory.classes;

namespace Wahventory
{
    public partial class ctrl_Inventory : UserControl
    {
        private db_type types;
        private db_item items;
        private db_from from;
        private db_inventory inventory;
        private db_techbag techbag;

        private String propertyNo = null;

        private double price = 0.00;
        private String depreciationId = null;

        public void setDepreciationId(String depreciationId)
        {
            this.depreciationId = depreciationId;
        }

        public ctrl_Inventory()
        {
            InitializeComponent();
            types = new db_type();
            items = new db_item();
            from = new db_from();
            inventory = new db_inventory();
            techbag = new db_techbag();
        }

        private void ctrl_Inventory_Load(object sender, EventArgs e)
        {

        }

        public void init()
        {
            if (Database.getConnection() != null)
            {
                loadTypes();
                loadFrom();
                loadItems();
                loadStatus();
                loadHolders();
                loadBags();
                loadTechBags();
                cbFilterFrom.SelectedIndex = -1;
            }
        }

        private void loadBags()
        {
            cbBagName.Items.Clear();
            foreach (DataRow row in techbag.getBags().Rows)
            {
                cbBagName.Items.Add(
                    new ComboBoxItem(row["bag_name"].ToString(),row["bag_id"].ToString())
                    );
            }
        }

        //Loads
        private void loadInventory()
        {
            dgvInventory.DataSource = inventory.getInventory("0");
            loadOthers();
        }
        private void loadOthers()
        {
            dgvInventory.ClearSelection();
            if (dgvInventory.DataSource != null && dgvInventory.RowCount > 0)
            {
                dgvInventory.Columns[0].Visible = false;
                dgvInventory.Columns[1].Visible = false;
                lblInventoryCount.Text = dgvInventory.RowCount.ToString();
            }
        }

        private void loadTypes()
        {
            cbType.Items.Clear();
            foreach (DataRow row in types.getType().Rows)
            {
                cbType.Items.Add(
                    new ComboBoxItem(row["type_name"].ToString(),row["type_id"].ToString())
                    );
            }
        }

        private void loadFrom()
        {
            cbFrom.Items.Clear();
            cbFilterFrom.Items.Clear();
            foreach (DataRow row in from.getFroms().Rows)
            {
                String fromName = row["from_name"].ToString();
                String fromId = row["from_id"].ToString();
                cbFrom.Items.Add(new ComboBoxItem(fromName,fromId));
                cbFilterFrom.Items.Add(new ComboBoxItem(fromName, fromId));
            }
        }

        public void loadItems()
        {
            dgvItems.DataSource = items.getItems(cbShowAll.Checked);
            if (dgvItems.DataSource != null)
            {
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                lblItemCount.Text = dgvItems.RowCount.ToString();
                dgvItems.ClearSelection();
                cbFilterFrom.SelectedIndex = -1;
            }
           
        }

        private void loadStatus()
        {
            cbStatus.Items.Clear();
            foreach (DataRow row in inventory.getStatus().Rows)
            {
                cbStatus.Items.Add(new ComboBoxItem(
                    row["status_name"].ToString(),row["status_id"].ToString()
                    ));
            }
            if (cbStatus.Items.Count > 0)
                cbStatus.SelectedIndex = 0;
        }

        private void loadHolders()
        {
            DataTable table = new DataTable();
            if (rbEmployee.Checked == true)
            {
                table = inventory.getHolders(true);
                lblHolderName.Text = "Employee Name: *";
            }
            else
            {
                table = inventory.getHolders(false);
                lblHolderName.Text = "Name/Group/Facility: *";
            }

            cbHolderName.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                cbHolderName.Items.Add(
                    new ComboBoxItem(row["holder_name"].ToString(),row["holder_id"].ToString())
                    );
            }
            cbHolderName.SelectedIndex = -1;
            cbHolderName.Text = string.Empty;
        }


        public void addDepreciation(String depreciationId)
        {
            btnDepreciation.BackColor = Color.Lime;
            btnDepreciation.Enabled = false;
            this.depreciationId = depreciationId;
            txtCost.Enabled = false;
        }
    
        private void txtSearchAssign_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchAssign.text))
                loadInventory();
            else
            {
                dgvInventory.DataSource = inventory.searchInventory(txtSearchAssign.text, "0");
                loadOthers();
                lblInventoryCount.Text = dgvInventory.RowCount.ToString();
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.DataSource != null && dgvItems.RowCount > 0)
            {
                int rowIndex = dgvItems.CurrentCell.RowIndex;
                String depreciationId = dgvItems.Rows[rowIndex].Cells[1].Value.ToString();
                String dateProcured = dgvItems.Rows[rowIndex].Cells[6].Value.ToString();
                String cost = dgvItems.Rows[rowIndex].Cells[9].Value.ToString();


                if (depreciationId != "")
                {
                    frmDepreciation depreciation = new frmDepreciation();
                    depreciation.isLoad = true;
                    depreciation.Cost = double.Parse(cost);
                    depreciation.DateProcured = dateProcured;
                    depreciation.depreciationId = depreciationId;
                    depreciation.ShowDialog();
                }
                else
                    MessageBox.Show(null, "No depreciation assigned to this item.", "Depreciation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInventory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }
            if (grid.Columns[e.ColumnIndex].Name == "DateReceived")
            {
                String date = (String)e.Value.ToString();
                if (date == "0000-00-00")
                    e.Value = "WAH OFFICE";
            }
            if (grid.Columns[e.ColumnIndex].Name == "AssignedTo" || grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "Remarks")
            {
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }
            
        }

        private void dgvInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventory.ClearSelection();
        }

        private void txtSearchItem_OnTextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchItem.text))
                loadItems();
            else
            {
                if (cbFilterFrom.SelectedIndex == -1)
                    dgvItems.DataSource = items.searchItem(cbShowAll.Checked, txtSearchItem.text);
                else
                {
                    String fromId = ((ComboBoxItem)cbFilterFrom.SelectedItem).HiddenValue;
                    dgvItems.DataSource = items.searchByFrom(fromId, txtSearchItem.text);
                }
            }
                

            dgvItems.Columns[0].Visible = false;
            dgvItems.Columns[1].Visible = false;
            dgvItems.ClearSelection();
            lblItemCount.Text = dgvItems.RowCount.ToString();
            
        }

        private void cbShowAll_OnChange(object sender, EventArgs e)
        {
            loadItems();
            txtSearchItem.text = string.Empty;
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            txtCost.Text = Format.formatToPeso(price);
        }

        private void switchRecieved_OnValueChange(object sender, EventArgs e)
        {
            if (switchRecieved.Value == true)
            {
                dtpDateReceived.Visible = true;
                txtWahOffice.Visible = false;
            }
            else
            {
                dtpDateReceived.Visible = false;
                txtWahOffice.Visible = true;
            }
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            loadHolders();
        }

        private void rbHolder_CheckedChanged(object sender, EventArgs e)
        {
            loadHolders();
        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;
            }

            if (grid.Columns[e.ColumnIndex].Name == "Method")
            {
                try
                {
                    String val = (String)e.Value;
                    if (val == "1")
                        e.Value = "Donation";
                    else
                        e.Value = "Purchased";
                }
                catch (Exception) { }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "COST")
            {
                try
                {
                    double price = double.Parse(e.Value.ToString());
                    e.Value = Format.formatToPeso(price);
                }
                catch (Exception) { }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "Depreciation")
            {
                String deprec = e.Value.ToString();
                if (deprec.Equals(""))
                {
                    e.Value = Format.formatToPeso(0.00);
                }
                else
                {
                    e.Value = Format.formatToPeso(double.Parse(deprec));
                }
            }

            else if (grid.Columns[e.ColumnIndex].Name == "from_name")
                grid.Columns[e.ColumnIndex].HeaderText = "FROM";


            if (grid.Columns[e.ColumnIndex].Name == "_")
            {
                Boolean avail = (Boolean)e.Value;
                try
                {
                    if (avail == true)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    else
                        e.CellStyle.BackColor = Color.Blue;
                    
                }
                catch (Exception) { }   
               
            }


            if (grid.Columns[e.ColumnIndex].Name == "Type" || grid.Columns[e.ColumnIndex].Name == "Details" || grid.Columns[e.ColumnIndex].Name == "DateProcured")
                grid.Columns[e.ColumnIndex].HeaderCell.Style.ForeColor = Color.Lime;

        }

        private void btnDepreciation_Click(object sender, EventArgs e)
        {
            txtCost.Text = Format.formatToPeso(price);

            if (txtCost.Text == "0.00" || txtCost.Text == '\u20B1' + "0.00")
            {
                MessageBox.Show(null, "Enter the cost of the item first.", "Depreciation item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCost.Focus();
                txtCost.Select();
            }
            else
            {
                frmDepreciation depreciation = new frmDepreciation();
                depreciation.DateProcured = dtpProcured.Value.ToString("MM/dd/yyyy");
                depreciation.Cost = Format.formatToDecimal(txtCost.Text);
                depreciation.inventory = this;
                depreciation.ShowDialog();
            }
        }

        private void txtCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Double.TryParse(txtCost.Text, out price) || price < 0)
                txtCost.Text = "0.00";
        }

        private void btnAssignToPerson_Click(object sender, EventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                int rowIndex = -1;
                try
                {
                   rowIndex = dgvItems.CurrentCell.RowIndex;
                }
                catch (Exception) { MessageBox.Show("Please select an item."); return; }
                if (rowIndex < 0)
                    MessageBox.Show(null,"Please select an item.","Assign to person",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    if (dgvItems.Rows[rowIndex].Cells[10].Value.ToString() == "1")
                    {
                        MessageBox.Show(null, "Sorry, but this item is already equipped to TECHBAG." + Environment.NewLine + "You can assign this item again to Techbag.", "Assign to person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dgvItems.Rows[rowIndex].Cells[2].Value.ToString() == "False")
                    {
                        MessageBox.Show(null, "The item is already assigned.", "Assign item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabInventory.SelectedIndex = 0;
                        return;
                    }
                    tabInventory.SelectedIndex = 1;
                    pnlAssign.Visible = true;
                    cbHolderName.Focus();
                    propertyNo = dgvItems.Rows[rowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void tabInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabInventory.SelectedIndex == 1)
            {
                pnlAssign.Visible = false;
                loadInventory();
            }
            else if (tabInventory.SelectedIndex == 2)
            {
                pnlTechInput.Visible = false;

                if (cbBagName.Items.Count > 0)
                    cbBagName.SelectedIndex = cbBagName.Items.Count - 1;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Variables
            String typeId = null, fromId = null;
            String isDonated = null;
            String dateProcured = null;

            if (String.IsNullOrEmpty(cbType.Text))
                cbType.Focus();
            else if (String.IsNullOrEmpty(cbFrom.Text))
                cbFrom.Focus();
            else if (String.IsNullOrEmpty(rtDetails.Text))
                rtDetails.Focus();
            else if (String.IsNullOrEmpty(txtPropertyNo.Text))
                txtPropertyNo.Focus();
            else
            {
                DialogResult result = MessageBox.Show(null, "Are you sure you want to add this item?", "Add item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;

                //Type
                if (cbType.SelectedIndex < 0)
                {
                    types.TypeName = cbType.Text;
                    if (types.addType())
                    {
                        typeId = types.getLastinserted();
                        cbType.Items.Add(new ComboBoxItem(cbType.Text, typeId));
                        cbType.SelectedIndex = cbType.Items.Count - 1;
                    }
                }
                else
                    typeId = ((ComboBoxItem)cbType.SelectedItem).HiddenValue;


                //From
                if (cbFrom.SelectedIndex < 0)
                {
                    from.FromName = cbFrom.Text;
                    if (from.addFrom())
                    {
                        fromId = from.getLastInserted();
                        cbFrom.Items.Add(new ComboBoxItem(cbFrom.Text, fromId));
                        cbFilterFrom.Items.Add(new ComboBoxItem(cbFrom.Text, fromId));
                        cbFrom.SelectedIndex = cbFrom.Items.Count - 1;
                    }
                }
                else
                    fromId = ((ComboBoxItem)cbFrom.SelectedItem).HiddenValue;


                //IsDonated
                if (rbDonated.Checked == true)
                    isDonated = "1";
                else
                    isDonated = "0";


                //format date procured
                dateProcured = dtpProcured.Value.ToString("yyyy-MM-dd");

                //Add item
                if (items.addItem(isDonated, price.ToString(), rtDetails.Text, depreciationId, dateProcured, fromId,txtPropertyNo.Text))
                {
                    if (types.insertItemType(typeId, items.getLastInserted()))
                    {
                        MessageBox.Show(null, "New item was successfully added.", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadItems();
                        txtCost.Enabled = true;
                        btnDepreciation.BackColor = Color.Transparent;
                        btnDepreciation.Enabled = true;
                        depreciationId = null;
                        rtDetails.Text = string.Empty;
                        txtCost.Text = "0.00";
                        txtPropertyNo.Text = String.Empty;
                    }
                }

            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            String dateReceived = null;
            String holderId = null;
            String itemId = null;
            

            if (dgvItems.RowCount < 0)
            {
                MessageBox.Show(null, "Please select an item.", "Select item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvItems.Focus();
                return;
            }
            else
            {
                int index = dgvItems.CurrentCell.RowIndex;
                itemId = dgvItems.Rows[index].Cells[0].Value.ToString();
            }

            if (cbStatus.SelectedIndex < 0)
            {
                cbStatus.Focus();
                cbStatus.SelectAll();
            }
            else if (String.IsNullOrEmpty(cbHolderName.Text))
                cbHolderName.Focus();
            else
            {
                DialogResult result = MessageBox.Show(null,"Are you sure you want to assign the item to " + cbHolderName.Text + "?","Assign to person",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;

                if (switchRecieved.Value == false)
                    dateReceived = "0000-00-00";
                else
                    dateReceived = dtpDateReceived.Value.ToString("yyyy-MM-dd");

                //Holders
                if (cbHolderName.SelectedIndex < 0)
                {
                    String isEmployee = null;
                    if (rbEmployee.Checked == true)
                        isEmployee = "1";
                    else
                        isEmployee = "0";

                    if (inventory.addHolders(cbHolderName.Text, isEmployee))
                    {
                        holderId = inventory.getLastHolderId();
                        cbHolderName.Items.Add(new ComboBoxItem(cbHolderName.Text, holderId));
                        cbHolderName.SelectedIndex = cbHolderName.Items.Count - 1;
                    }
                }
                else
                    holderId = ((ComboBoxItem)cbHolderName.SelectedItem).HiddenValue;


                //Inventory
                String statusId = ((ComboBoxItem)cbStatus.SelectedItem).HiddenValue;
                if (inventory.insertInventory(propertyNo, statusId, holderId, dateReceived, txtRemarks.Text, itemId, "0"))
                {
                    MessageBox.Show(null, "Item was successfully assigned to "+cbHolderName.Text+".", "Assign to person", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInventory();
                    loadItems();
                    txtRemarks.Text = String.Empty;
                    cbHolderName.SelectedIndex = -1;
                    cbHolderName.Text = string.Empty;
                    pnlAssign.Visible = false;
                }
            }
        }

        private void btnAssignToTechbag_Click(object sender, EventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                int rowIndex = -1;

                try
                {
                    rowIndex = dgvItems.CurrentCell.RowIndex;
                }
                catch (Exception) { MessageBox.Show("Please select an item."); return; }

                if (rowIndex > -1)
                {
                    if (dgvItems.Rows[rowIndex].Cells[2].Value.ToString() == "False")
                    {
                        MessageBox.Show(null, "The item is already assigned.", "Assign item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabInventory.SelectedIndex = 0;
                        return;
                    }

                    String type = dgvItems.Rows[rowIndex].Cells[3].Value.ToString();
                    propertyNo = dgvItems.Rows[rowIndex].Cells[3].Value.ToString();

                    tabInventory.SelectedIndex = 2;
                    pnlTechInput.Visible = true;

                }
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (dgvTechBags.RowCount > 0)
            {
                if (dgvTechBags.Rows[0].Cells[8].Value.ToString() == "OUT")
                {
                    MessageBox.Show(null, "Sorry, but the bag is currently out.", "Equip item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            String bagId = null;
            String itemId = null;

            if (dgvItems.RowCount < 1)
                return;
            else
            {
                int rowIndex = dgvItems.CurrentCell.RowIndex;
                itemId = dgvItems.Rows[rowIndex].Cells[0].Value.ToString();
            }

            
            if (nupQuantity.Value < 1)
                nupQuantity.Focus();
            else
            {
                DialogResult result = MessageBox.Show(null, "Are you sure you want to equip the item to " + cbBagName.Text + "?", "Equp item",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;

                if (cbBagName.SelectedIndex == -1)
                {
                    if (String.IsNullOrEmpty(cbBagName.Text))
                        cbBagName.Focus();
                    else
                    {
                        if (techbag.insertTechBag(cbBagName.Text))
                        {
                            String id = techbag.getLastInserted();
                            cbBagName.Items.Add(
                                new ComboBoxItem(cbBagName.Text,id)
                                );
                            bagId = id;
                            cbBagName.SelectedIndex = cbBagName.Items.Count - 1;
                        }   
                    }
                }
                else
                    bagId = ((ComboBoxItem)cbBagName.SelectedItem).HiddenValue;



                if (techbag.insertBagItem(itemId, bagId, nupQuantity.Value.ToString(), propertyNo))
                {
                    MessageBox.Show(null,"Item was successfully equipped to " + cbBagName.Text,"Equip item",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    loadTechBags();
                    loadItems();
                    pnlTechInput.Visible = false;
                    nupQuantity.Value = 1;
                }
            }
        }

        private void loadTechBags()
        {
            if (cbBagName.SelectedIndex > -1)
            {
                String id = ((ComboBoxItem)cbBagName.SelectedItem).HiddenValue;
                dgvTechBags.DataSource = techbag.getTechBagItems(id);
                dgvTechBags.Columns[0].Visible = false;
                dgvTechBags.Columns[1].Visible = false;
                dgvTechBags.ClearSelection();
            }
        }

        private void cbBagName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTechBags();
        }

        private void dgvTechBags_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "property_no")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "WAHProperty#";
            }

            if (grid.Columns[e.ColumnIndex].Name == "from_name")
                grid.Columns[e.ColumnIndex].HeaderText = "FROM";

            if (grid.Columns[e.ColumnIndex].Name == "status")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "STATUS";
                if (e.Value.ToString() == "IN")
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.White;
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "item_condition")
            {
                grid.Columns[e.ColumnIndex].HeaderText = "Condition";
            }
        }

        private void cbBagName_TextChanged(object sender, EventArgs e)
        {
            dgvTechBags.DataSource = null;
        }

        private void cbFilterFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterFrom.SelectedIndex > -1)
            {
                String fromId = ((ComboBoxItem)cbFilterFrom.SelectedItem).HiddenValue;
                dgvItems.DataSource = items.filterItemsByFrom(fromId, cbShowAll.Checked);
                dgvItems.Columns[0].Visible = false;
                dgvItems.Columns[1].Visible = false;
                lblItemCount.Text = dgvItems.RowCount.ToString();
                dgvItems.ClearSelection();
            }
        }

        private void cbTechBagItems_OnChange(object sender, EventArgs e)
        {
            txtSearchItem.text = string.Empty;
            cbShowAll.Checked = true;
            loadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            modifyQuantity(true);
        }

        private void modifyQuantity(Boolean isAdd)
        {
            if (dgvTechBags.RowCount > 0)
            {
                try
                {
                    int rowIndex = dgvTechBags.CurrentCell.RowIndex;
                    int currentQuantity = Convert.ToInt32(dgvTechBags.Rows[rowIndex].Cells[3].Value.ToString());

                    int step = Convert.ToInt32(nupModify.Value.ToString());

                    if (isAdd)
                        currentQuantity += step;
                    else
                        currentQuantity -= step;

                    if (currentQuantity < 1)
                        currentQuantity = 1;

                    dgvTechBags.Rows[rowIndex].Cells[3].Value = currentQuantity.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show(null, "Please select an item.", "Add quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            modifyQuantity(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTechBags.RowCount > 0)
            {
                if (dgvTechBags.Rows[0].Cells[8].Value.ToString() == "OUT")
                {
                    MessageBox.Show(null, "Sorry, but the bag is currently out.", "Equip item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadTechBags();
                    return;
                }


                Boolean okey = false;
                foreach (DataGridViewRow row in dgvTechBags.Rows)
                {
                    String quantity = row.Cells[3].Value.ToString();
                    String bagItemId = row.Cells[0].Value.ToString();

                    Database.set("UPDATE tblbagitem SET quantity = @quantity WHERE bagitem_id = @bagItemId;",new String[]{quantity,bagItemId});
                    okey = Database.executeNonQuery();
                }
                if (okey)
                {
                    MessageBox.Show(null,cbBagName.Text +" was successfully updated.", "Update bag item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTechBags();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTechBags.RowCount > 0)
            {
                if (dgvTechBags.Rows[0].Cells[8].Value.ToString() == "OUT")
                {
                    MessageBox.Show(null, "Sorry, but the bag is currently out.", "Equip item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
          

                try
                {
                    int rowIndex = dgvTechBags.CurrentCell.RowIndex;
                    DialogResult result = MessageBox.Show(null, "Are you sure you want to unequip this item from " + cbBagName.Text + "?", "Unequip item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.No)
                        return;

                    String bagItemId = dgvTechBags.Rows[rowIndex].Cells[0].Value.ToString();
                    String itemId = dgvTechBags.Rows[rowIndex].Cells[1].Value.ToString();
                    Database.set("DELETE FROM tblbagitem WHERE bagitem_id = @bagItemId;",new String[]{bagItemId});
                    if (Database.executeNonQuery())
                    {
                        Database.set("UPDATE tblitem SET tblitem.available = 1 WHERE tblitem.item_id = @itemId;",new String[]{itemId});
                        if (Database.executeNonQuery())
                        {
                            MessageBox.Show(null, "Item was successfully unequipped from ", "Unequip item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadTechBags();
                            loadItems();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(null, "Please select an item.", "Remove item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void linkGenerateProperty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (String.IsNullOrEmpty(cbType.Text))
                cbType.Focus();
            else
            {
                txtPropertyNo.Text = getAutoProperty(cbType.Text);
            }
        }


        //Methods
        private String getAutoProperty(String type)
        {
            String generated = null;
            String last = null;
            String no = "0";
            char[] strRemove = { ' ' };

            if (!type.Contains(" ") && type.Length > 3)
                last = type.Substring(1, 2).ToUpper();
            else if (type.Length < 3)
                last = type.Substring(0, 2);

            string[] strWords = type.Split(strRemove);

            foreach (string a in strWords)
            {
                generated += a[0];
            }

            Database.set("SELECT (MAX(item_id) + 1) FROM tblitem;");
            no += Database.executeString();

            generated = generated.Insert(0, "WAH-OFC"+DateTime.Now.Year+"-");
            return generated + last + no;
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvItems.RowCount > 0)
            {
                int rowIndex = -1;
                try
                {
                    rowIndex = dgvItems.CurrentCell.RowIndex;
                    String itemId = dgvItems.Rows[rowIndex].Cells[0].Value.ToString();

                    if (e.KeyCode == Keys.E && e.Modifiers == (Keys.Control))
                    {
                        if (!String.IsNullOrEmpty(itemId))
                        {
                            frmEditItem editItem = new frmEditItem();
                            editItem.inventory = this;
                            editItem.itemId = itemId;
                            editItem.ShowDialog();
                        }
                    }


                    if (e.KeyCode == Keys.Delete)
                    {

                        Database.set("SELECT tblinventory.item_id FROM tblinventory WHERE tblinventory.item_id = @itemId UNION SELECT tblbagitem.item_id FROM tblbagitem WHERE tblbagitem.item_id = @itemId UNION SELECT tbltechbag.item_id FROM tbltechbag WHERE tbltechbag.item_id = @itemId;", new String[] { itemId });
                        int count = Database.executeResultSet().Rows.Count;

                        if (count > 0)
                        {
                            MessageBox.Show(null, "This item cannot be deleted because it has an history of our inventory system.", "Delete item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }



                        DialogResult result = MessageBox.Show(null, "Are you sure you want to delete this item?", "Delete item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.Yes)
                        {
                            Database.set("DELETE FROM tblitemtype WHERE tblitemtype.item_id = @itemId;",new String[]{itemId});
                            if (Database.executeNonQuery())
                            {
                                Database.set("DELETE FROM tblitem WHERE tblitem.item_id = @itemId;", new String[] { itemId });
                                if (Database.executeNonQuery())
                                {
                                    MessageBox.Show(null, "Item was successfully deleted.", "Delete item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadItems();
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select an item.");
                    return;
                }
            }
        }






     

   

     
  



      
    }
}
