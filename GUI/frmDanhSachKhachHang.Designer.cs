namespace GUI
{
    partial class frmDanhSachKhachHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKhachHang));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            btnloadData = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            dateend = new DevExpress.XtraEditors.DateEdit();
            datestart = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridControl1.Location = new Point(12, 98);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(993, 897);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsFind.AlwaysVisible = true;
            gridView1.OptionsFind.FindFilterColumns = "Email";
            gridView1.OptionsFind.FindNullPrompt = "Nhập email khách hàng để tìm kiếm...";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = gridControl1;
            layoutControlItem6.Location = new Point(0, 86);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(997, 901);
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // btnloadData
            // 
            btnloadData.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnloadData.Appearance.Options.UseFont = true;
            btnloadData.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnloadData.ImageOptions.SvgImage");
            btnloadData.Location = new Point(12, 999);
            btnloadData.Name = "btnloadData";
            btnloadData.Size = new Size(494, 44);
            btnloadData.StyleController = layoutControl1;
            btnloadData.TabIndex = 5;
            btnloadData.Text = "Hiện thị dữ liệu";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(txtEmail);
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Controls.Add(btnloadData);
            layoutControl1.Controls.Add(btnPrint);
            layoutControl1.Controls.Add(dateend);
            layoutControl1.Controls.Add(datestart);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(704, 310, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1017, 1055);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 22);
            txtEmail.StyleController = layoutControl1;
            txtEmail.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrint.ImageOptions.SvgImage");
            btnPrint.Location = new Point(510, 999);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(495, 44);
            btnPrint.StyleController = layoutControl1;
            btnPrint.TabIndex = 6;
            btnPrint.Text = "In dữ liệu";
            btnPrint.Click += btnPrint_Click;
            // 
            // dateend
            // 
            dateend.EditValue = null;
            dateend.Location = new Point(821, 50);
            dateend.Name = "dateend";
            dateend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateend.Size = new Size(172, 22);
            dateend.StyleController = layoutControl1;
            dateend.TabIndex = 3;
            // 
            // datestart
            // 
            datestart.EditValue = null;
            datestart.Location = new Point(501, 50);
            datestart.Name = "datestart";
            datestart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            datestart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            datestart.Size = new Size(171, 22);
            datestart.StyleController = layoutControl1;
            datestart.TabIndex = 2;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup1, layoutControlItem5, layoutControlItem6, layoutControlItem2, layoutControlGroup2 });
            Root.Name = "Root";
            Root.Size = new Size(1017, 1055);
            Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem4, layoutControlItem3 });
            layoutControlGroup1.Location = new Point(332, 0);
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(665, 86);
            layoutControlGroup1.Text = "Chọn thời gian";
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = dateend;
            layoutControlItem4.Location = new Point(320, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(321, 36);
            layoutControlItem4.Text = "Thời gian kết thúc";
            layoutControlItem4.TextSize = new Size(133, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = datestart;
            layoutControlItem3.Location = new Point(0, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(320, 36);
            layoutControlItem3.Text = "Thời gian bắt đầu";
            layoutControlItem3.TextSize = new Size(133, 16);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = btnloadData;
            layoutControlItem5.Location = new Point(0, 987);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(498, 48);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnPrint;
            layoutControlItem2.Location = new Point(498, 987);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(499, 48);
            layoutControlItem2.TextSize = new Size(0, 0);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1 });
            layoutControlGroup2.Location = new Point(0, 0);
            layoutControlGroup2.Name = "layoutControlGroup2";
            layoutControlGroup2.Size = new Size(332, 86);
            layoutControlGroup2.Text = "Tìm kiếm";
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = txtEmail;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(308, 26);
            layoutControlItem1.Text = "Nhập Email khách hàng";
            layoutControlItem1.TextSize = new Size(133, 16);
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 26);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(308, 10);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // frmDanhSachKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 1055);
            Controls.Add(layoutControl1);
            Name = "frmDanhSachKhachHang";
            Text = "frmDanhSachKhachHang";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnloadData;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.DateEdit dateend;
        private DevExpress.XtraEditors.DateEdit datestart;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}