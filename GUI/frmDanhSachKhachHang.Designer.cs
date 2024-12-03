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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachKhachHang));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            btnloadData = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnPrint = new DevExpress.XtraEditors.SimpleButton();
            dateend = new DevExpress.XtraEditors.DateEdit();
            datestart = new DevExpress.XtraEditors.DateEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            bar3 = new DevExpress.XtraBars.Bar();
            bar2 = new DevExpress.XtraBars.Bar();
            bar1 = new DevExpress.XtraBars.Bar();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar5 = new DevExpress.XtraBars.Bar();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            btnSua = new DevExpress.XtraBars.BarButtonItem();
            bar6 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            SuspendLayout();
            // 
            // btnloadData
            // 
            btnloadData.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnloadData.Appearance.Options.UseFont = true;
            btnloadData.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnloadData.ImageOptions.SvgImage");
            btnloadData.Location = new Point(12, 947);
            btnloadData.Name = "btnloadData";
            btnloadData.Size = new Size(494, 44);
            btnloadData.StyleController = layoutControl1;
            btnloadData.TabIndex = 5;
            btnloadData.Text = "Hiện thị thông tin hóa đơn";
            btnloadData.Click += btnloadData_Click;
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
            layoutControl1.Location = new Point(0, 33);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(704, 310, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(1017, 1003);
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
            // gridControl1
            // 
            gridLevelNode2.RelationName = "Level1";
            gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode2 });
            gridControl1.Location = new Point(12, 98);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(993, 845);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsFind.AlwaysVisible = true;
            gridView1.OptionsFind.FindFilterColumns = "Email";
            gridView1.OptionsFind.FindNullPrompt = "Nhập email khách hàng để tìm kiếm...";
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            gridView1.CellValueChanged += gridView1_CellValueChanged;
            // 
            // btnPrint
            // 
            btnPrint.Appearance.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnPrint.Appearance.Options.UseFont = true;
            btnPrint.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnPrint.ImageOptions.SvgImage");
            btnPrint.Location = new Point(510, 947);
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
            Root.Size = new Size(1017, 1003);
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
            layoutControlItem5.Location = new Point(0, 935);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(498, 48);
            layoutControlItem5.TextSize = new Size(0, 0);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = gridControl1;
            layoutControlItem6.Location = new Point(0, 86);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new Size(997, 849);
            layoutControlItem6.TextSize = new Size(0, 0);
            layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = btnPrint;
            layoutControlItem2.Location = new Point(498, 935);
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
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.DockCol = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.Text = "Status bar";
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.Text = "Main menu";
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.Text = "Tools";
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar5, bar6 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1, btnSua });
            barManager1.MainMenu = bar5;
            barManager1.MaxItemId = 3;
            barManager1.StatusBar = bar6;
            // 
            // bar5
            // 
            bar5.BarName = "Main menu";
            bar5.DockCol = 0;
            bar5.DockRow = 0;
            bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem1), new DevExpress.XtraBars.LinkPersistInfo(btnSua) });
            bar5.OptionsBar.MultiLine = true;
            bar5.OptionsBar.UseWholeRow = true;
            bar5.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Xóa";
            barButtonItem1.Id = 0;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            barButtonItem1.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Hovered.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            barButtonItem1.ItemAppearance.Pressed.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            barButtonItem1.ItemAppearance.Pressed.Options.UseFont = true;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // btnSua
            // 
            btnSua.Caption = "Sửa";
            btnSua.Id = 2;
            btnSua.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSua.ImageOptions.SvgImage");
            btnSua.ItemAppearance.Disabled.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSua.ItemAppearance.Disabled.Options.UseFont = true;
            btnSua.ItemAppearance.Hovered.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSua.ItemAppearance.Hovered.Options.UseFont = true;
            btnSua.ItemAppearance.Normal.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSua.ItemAppearance.Normal.Options.UseFont = true;
            btnSua.ItemAppearance.Pressed.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            btnSua.ItemAppearance.Pressed.Options.UseFont = true;
            btnSua.Name = "btnSua";
            btnSua.ItemClick += btnSua_ItemClick;
            // 
            // bar6
            // 
            bar6.BarName = "Status bar";
            bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar6.DockCol = 0;
            bar6.DockRow = 0;
            bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar6.OptionsBar.AllowQuickCustomization = false;
            bar6.OptionsBar.DrawDragBorder = false;
            bar6.OptionsBar.UseWholeRow = true;
            bar6.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(1017, 33);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 1036);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1017, 19);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 33);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 1003);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1017, 33);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 1003);
            // 
            // popupMenu1
            // 
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // frmDanhSachKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 1055);
            Controls.Add(layoutControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmDanhSachKhachHang";
            Text = "frmDanhSachKhachHang";
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateend.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)datestart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnSua;
    }
}