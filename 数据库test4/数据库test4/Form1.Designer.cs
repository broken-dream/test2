namespace 数据库test4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.dataSet11 = new 数据库test4.DataSet1();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.DataSource = this.dataSet11;
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(27, 324);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(798, 192);
            this.dataGrid2.TabIndex = 1;
            this.dataGrid2.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid2_Navigate);
            this.dataGrid2.Click += new System.EventHandler(this.dataGrid2_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT  SalesOrderID, OrderDate, DueDate, ShipDate, Status, SalesOrderNumber\r\nFRO" +
    "M      Sales.SalesOrderHeader";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-LB6QPBVM\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=AdventureWorks";
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "OrderDate"),
            new System.Data.OleDb.OleDbParameter("DueDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "DueDate"),
            new System.Data.OleDb.OleDbParameter("ShipDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "ShipDate"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_DueDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DueDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ShipDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ShipDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ShipDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_DueDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DueDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ShipDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ShipDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ShipDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SalesOrderHeader", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SalesOrderID", "SalesOrderID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("DueDate", "DueDate"),
                        new System.Data.Common.DataColumnMapping("ShipDate", "ShipDate"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("SalesOrderNumber", "SalesOrderNumber")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = resources.GetString("oleDbSelectCommand2.CommandText");
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, "SalesOrderID"),
            new System.Data.OleDb.OleDbParameter("CarrierTrackingNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "CarrierTrackingNumber"),
            new System.Data.OleDb.OleDbParameter("OrderQty", System.Data.OleDb.OleDbType.SmallInt, 0, "OrderQty"),
            new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"),
            new System.Data.OleDb.OleDbParameter("SpecialOfferID", System.Data.OleDb.OleDbType.Integer, 0, "SpecialOfferID"),
            new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"),
            new System.Data.OleDb.OleDbParameter("UnitPriceDiscount", System.Data.OleDb.OleDbType.Currency, 0, "UnitPriceDiscount"),
            new System.Data.OleDb.OleDbParameter("rowguid", System.Data.OleDb.OleDbType.Guid, 0, "rowguid"),
            new System.Data.OleDb.OleDbParameter("ModifiedDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "ModifiedDate")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, "SalesOrderID"),
            new System.Data.OleDb.OleDbParameter("CarrierTrackingNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "CarrierTrackingNumber"),
            new System.Data.OleDb.OleDbParameter("OrderQty", System.Data.OleDb.OleDbType.SmallInt, 0, "OrderQty"),
            new System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.Integer, 0, "ProductID"),
            new System.Data.OleDb.OleDbParameter("SpecialOfferID", System.Data.OleDb.OleDbType.Integer, 0, "SpecialOfferID"),
            new System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, "UnitPrice"),
            new System.Data.OleDb.OleDbParameter("UnitPriceDiscount", System.Data.OleDb.OleDbType.Currency, 0, "UnitPriceDiscount"),
            new System.Data.OleDb.OleDbParameter("rowguid", System.Data.OleDb.OleDbType.Guid, 0, "rowguid"),
            new System.Data.OleDb.OleDbParameter("ModifiedDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "ModifiedDate"),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderDetailID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CarrierTrackingNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CarrierTrackingNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CarrierTrackingNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CarrierTrackingNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderQty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderQty", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SpecialOfferID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SpecialOfferID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPriceDiscount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPriceDiscount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_LineTotal", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((byte)(38)), ((byte)(6)), "LineTotal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_rowguid", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rowguid", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ModifiedDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ModifiedDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SalesOrderDetailID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SalesOrderDetailID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CarrierTrackingNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CarrierTrackingNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CarrierTrackingNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CarrierTrackingNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_OrderQty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderQty", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SpecialOfferID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SpecialOfferID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_UnitPriceDiscount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPriceDiscount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_LineTotal", System.Data.OleDb.OleDbType.Numeric, 0, System.Data.ParameterDirection.Input, false, ((byte)(38)), ((byte)(6)), "LineTotal", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_rowguid", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rowguid", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ModifiedDate", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ModifiedDate", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SalesOrderDetail", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SalesOrderID", "SalesOrderID"),
                        new System.Data.Common.DataColumnMapping("SalesOrderDetailID", "SalesOrderDetailID"),
                        new System.Data.Common.DataColumnMapping("CarrierTrackingNumber", "CarrierTrackingNumber"),
                        new System.Data.Common.DataColumnMapping("OrderQty", "OrderQty"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("SpecialOfferID", "SpecialOfferID"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitPriceDiscount", "UnitPriceDiscount"),
                        new System.Data.Common.DataColumnMapping("LineTotal", "LineTotal"),
                        new System.Data.Common.DataColumnMapping("rowguid", "rowguid"),
                        new System.Data.Common.DataColumnMapping("ModifiedDate", "ModifiedDate")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.dataSet11;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(27, 12);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(798, 280);
            this.dataGrid1.TabIndex = 0;
            this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            this.dataGrid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 552);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
    }
}

