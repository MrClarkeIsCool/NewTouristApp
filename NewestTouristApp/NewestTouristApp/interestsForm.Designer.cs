namespace NewestTouristApp
{
    partial class interestsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interestsForm));
            this.doneButton = new System.Windows.Forms.Button();
            this.sitdownFoodButton = new System.Windows.Forms.Button();
            this.fastFoodButton = new System.Windows.Forms.Button();
            this.amusementParksButton = new System.Windows.Forms.Button();
            this.hikingButton = new System.Windows.Forms.Button();
            this.naturalButton = new System.Windows.Forms.Button();
            this.manMadeButton = new System.Windows.Forms.Button();
            this.ruralButton = new System.Windows.Forms.Button();
            this.urbanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.touristAttractionsDataSet = new NewestTouristApp.TouristAttractionsDataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new NewestTouristApp.TouristAttractionsDataSetTableAdapters.Table1TableAdapter();
            this.tableAdapterManager = new NewestTouristApp.TouristAttractionsDataSetTableAdapters.TableAdapterManager();
            this.table1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.touristAttractionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).BeginInit();
            this.table1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Red;
            this.doneButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(156, 488);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(309, 82);
            this.doneButton.TabIndex = 19;
            this.doneButton.Text = "You have selected 0 interest(s). Please select 4 more.";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // sitdownFoodButton
            // 
            this.sitdownFoodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.sitdownFoodButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sitdownFoodButton.ForeColor = System.Drawing.Color.White;
            this.sitdownFoodButton.Location = new System.Drawing.Point(320, 387);
            this.sitdownFoodButton.Name = "sitdownFoodButton";
            this.sitdownFoodButton.Size = new System.Drawing.Size(145, 82);
            this.sitdownFoodButton.TabIndex = 18;
            this.sitdownFoodButton.Text = "Sit-Down Dining";
            this.sitdownFoodButton.UseVisualStyleBackColor = false;
            this.sitdownFoodButton.Click += new System.EventHandler(this.sitdownFoodButton_Click);
            // 
            // fastFoodButton
            // 
            this.fastFoodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.fastFoodButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastFoodButton.ForeColor = System.Drawing.Color.White;
            this.fastFoodButton.Location = new System.Drawing.Point(156, 387);
            this.fastFoodButton.Name = "fastFoodButton";
            this.fastFoodButton.Size = new System.Drawing.Size(145, 82);
            this.fastFoodButton.TabIndex = 17;
            this.fastFoodButton.Text = "Fast Food";
            this.fastFoodButton.UseVisualStyleBackColor = false;
            this.fastFoodButton.Click += new System.EventHandler(this.fastFoodButton_Click);
            // 
            // amusementParksButton
            // 
            this.amusementParksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.amusementParksButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amusementParksButton.ForeColor = System.Drawing.Color.White;
            this.amusementParksButton.Location = new System.Drawing.Point(320, 285);
            this.amusementParksButton.Name = "amusementParksButton";
            this.amusementParksButton.Size = new System.Drawing.Size(145, 82);
            this.amusementParksButton.TabIndex = 16;
            this.amusementParksButton.Text = "Amusement Parks";
            this.amusementParksButton.UseVisualStyleBackColor = false;
            this.amusementParksButton.Click += new System.EventHandler(this.amusementParksButton_Click);
            // 
            // hikingButton
            // 
            this.hikingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.hikingButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hikingButton.ForeColor = System.Drawing.Color.White;
            this.hikingButton.Location = new System.Drawing.Point(156, 285);
            this.hikingButton.Name = "hikingButton";
            this.hikingButton.Size = new System.Drawing.Size(145, 82);
            this.hikingButton.TabIndex = 15;
            this.hikingButton.Text = "Hiking/Exercise";
            this.hikingButton.UseVisualStyleBackColor = false;
            this.hikingButton.Click += new System.EventHandler(this.hikingButton_Click);
            // 
            // naturalButton
            // 
            this.naturalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.naturalButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naturalButton.ForeColor = System.Drawing.Color.White;
            this.naturalButton.Location = new System.Drawing.Point(320, 181);
            this.naturalButton.Name = "naturalButton";
            this.naturalButton.Size = new System.Drawing.Size(145, 82);
            this.naturalButton.TabIndex = 14;
            this.naturalButton.Text = "Natural Attractions";
            this.naturalButton.UseVisualStyleBackColor = false;
            this.naturalButton.Click += new System.EventHandler(this.naturalButton_Click);
            // 
            // manMadeButton
            // 
            this.manMadeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.manMadeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manMadeButton.ForeColor = System.Drawing.Color.White;
            this.manMadeButton.Location = new System.Drawing.Point(156, 181);
            this.manMadeButton.Name = "manMadeButton";
            this.manMadeButton.Size = new System.Drawing.Size(145, 82);
            this.manMadeButton.TabIndex = 13;
            this.manMadeButton.Text = "Man-made Attractions";
            this.manMadeButton.UseVisualStyleBackColor = false;
            this.manMadeButton.Click += new System.EventHandler(this.manMadeButton_Click);
            // 
            // ruralButton
            // 
            this.ruralButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.ruralButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruralButton.ForeColor = System.Drawing.Color.White;
            this.ruralButton.Location = new System.Drawing.Point(320, 80);
            this.ruralButton.Name = "ruralButton";
            this.ruralButton.Size = new System.Drawing.Size(145, 82);
            this.ruralButton.TabIndex = 12;
            this.ruralButton.Text = "Rural Landscape";
            this.ruralButton.UseVisualStyleBackColor = false;
            this.ruralButton.Click += new System.EventHandler(this.ruralButton_Click);
            // 
            // urbanButton
            // 
            this.urbanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.urbanButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urbanButton.ForeColor = System.Drawing.Color.White;
            this.urbanButton.Location = new System.Drawing.Point(156, 80);
            this.urbanButton.Name = "urbanButton";
            this.urbanButton.Size = new System.Drawing.Size(145, 82);
            this.urbanButton.TabIndex = 11;
            this.urbanButton.Text = "Urban Landscape";
            this.urbanButton.UseVisualStyleBackColor = false;
            this.urbanButton.Click += new System.EventHandler(this.urbanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "What are your interests? (Pick Four)";
            // 
            // touristAttractionsDataSet
            // 
            this.touristAttractionsDataSet.DataSetName = "TouristAttractionsDataSet";
            this.touristAttractionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this.touristAttractionsDataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table1TableAdapter = this.table1TableAdapter;
            this.tableAdapterManager.UpdateOrder = NewestTouristApp.TouristAttractionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // table1BindingNavigator
            // 
            this.table1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table1BindingNavigator.BindingSource = this.table1BindingSource;
            this.table1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table1BindingNavigatorSaveItem});
            this.table1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table1BindingNavigator.Name = "table1BindingNavigator";
            this.table1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table1BindingNavigator.Size = new System.Drawing.Size(607, 25);
            this.table1BindingNavigator.TabIndex = 20;
            this.table1BindingNavigator.Text = "bindingNavigator1";
            this.table1BindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table1BindingNavigatorSaveItem
            // 
            this.table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table1BindingNavigatorSaveItem.Image")));
            this.table1BindingNavigatorSaveItem.Name = "table1BindingNavigatorSaveItem";
            this.table1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table1BindingNavigatorSaveItem.Text = "Save Data";
            this.table1BindingNavigatorSaveItem.Click += new System.EventHandler(this.table1BindingNavigatorSaveItem_Click);
            // 
            // interestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(607, 587);
            this.Controls.Add(this.table1BindingNavigator);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.sitdownFoodButton);
            this.Controls.Add(this.fastFoodButton);
            this.Controls.Add(this.amusementParksButton);
            this.Controls.Add(this.hikingButton);
            this.Controls.Add(this.naturalButton);
            this.Controls.Add(this.manMadeButton);
            this.Controls.Add(this.ruralButton);
            this.Controls.Add(this.urbanButton);
            this.Controls.Add(this.label1);
            this.Name = "interestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.interestsForm_FormClosed);
            this.Load += new System.EventHandler(this.interestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.touristAttractionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingNavigator)).EndInit();
            this.table1BindingNavigator.ResumeLayout(false);
            this.table1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button sitdownFoodButton;
        private System.Windows.Forms.Button fastFoodButton;
        private System.Windows.Forms.Button amusementParksButton;
        private System.Windows.Forms.Button hikingButton;
        private System.Windows.Forms.Button naturalButton;
        private System.Windows.Forms.Button manMadeButton;
        private System.Windows.Forms.Button ruralButton;
        private System.Windows.Forms.Button urbanButton;
        private System.Windows.Forms.Label label1;
        private TouristAttractionsDataSet touristAttractionsDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private TouristAttractionsDataSetTableAdapters.Table1TableAdapter table1TableAdapter;
        private TouristAttractionsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table1BindingNavigatorSaveItem;
    }
}