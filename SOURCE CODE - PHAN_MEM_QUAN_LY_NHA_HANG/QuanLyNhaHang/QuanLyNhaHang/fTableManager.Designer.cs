namespace QuanLyNhaHang
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new Guna.UI.WinForms.GunaNumeric();
            this.btnAddFood = new Guna.UI.WinForms.GunaGradientTileButton();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.gunaContextMenuStrip2 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaContextMenuStrip3 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaContextMenuStrip4 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.gunaContextMenuStrip5 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.gunaContextMenuStrip6 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSwitchTable = new Guna.UI.WinForms.GunaGradientTileButton();
            this.nmDisCount = new Guna.UI.WinForms.GunaNumeric();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnCheckOut = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton4 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton3 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gunaContextMenuStrip2.SuspendLayout();
            this.gunaContextMenuStrip3.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1878, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Cập nhật mật khẩu";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thêmMónToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(276, 36);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            this.thêmMónToolStripMenuItem.Click += new System.EventHandler(this.thêmMónToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(591, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 342);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(675, 337);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 166;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 194;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 151;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.txbTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.txbTotalPrice.Location = new System.Drawing.Point(372, 55);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(155, 37);
            this.txbTotalPrice.TabIndex = 7;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTotalPrice.TextChanged += new System.EventHandler(this.txbTotalPrice_TextChanged);
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(579, 33);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(94, 36);
            this.cbSwitchTable.TabIndex = 6;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmFoodCount.BackColor = System.Drawing.Color.Transparent;
            this.nmFoodCount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.nmFoodCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nmFoodCount.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nmFoodCount.ButtonForeColor = System.Drawing.Color.White;
            this.nmFoodCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmFoodCount.ForeColor = System.Drawing.Color.Black;
            this.nmFoodCount.Location = new System.Drawing.Point(349, 33);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmFoodCount.Maximum = ((long)(9999999));
            this.nmFoodCount.Minimum = ((long)(-9999999));
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Radius = 4;
            this.nmFoodCount.Size = new System.Drawing.Size(92, 30);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Text = "gunaNumeric1";
            this.nmFoodCount.Value = ((long)(1));
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged_1);
            // 
            // btnAddFood
            // 
            this.btnAddFood.AnimationHoverSpeed = 0.07F;
            this.btnAddFood.AnimationSpeed = 0.03F;
            this.btnAddFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnAddFood.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnAddFood.BorderColor = System.Drawing.Color.Black;
            this.btnAddFood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddFood.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.btnAddFood.ForeColor = System.Drawing.Color.Black;
            this.btnAddFood.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddFood.Location = new System.Drawing.Point(238, 5);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnAddFood.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnAddFood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddFood.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddFood.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.OnHoverImage")));
            this.btnAddFood.OnPressedColor = System.Drawing.Color.White;
            this.btnAddFood.Radius = 6;
            this.btnAddFood.Size = new System.Drawing.Size(108, 108);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click_1);
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(9, 51);
            this.cbFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(221, 36);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(9, 5);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(221, 36);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(0, 36);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(585, 602);
            this.flpTable.TabIndex = 5;
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gunaContextMenuStrip2
            // 
            this.gunaContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.gunaContextMenuStrip2.Name = "gunaContextMenuStrip2";
            this.gunaContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip2.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip2.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip2.Size = new System.Drawing.Size(244, 36);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // gunaContextMenuStrip3
            // 
            this.gunaContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.gunaContextMenuStrip3.Name = "gunaContextMenuStrip3";
            this.gunaContextMenuStrip3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip3.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip3.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip3.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip3.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip3.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip3.Size = new System.Drawing.Size(244, 68);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // gunaContextMenuStrip4
            // 
            this.gunaContextMenuStrip4.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip4.Name = "gunaContextMenuStrip4";
            this.gunaContextMenuStrip4.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip4.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip4.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip4.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip4.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip4.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip4.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip4.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip4.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // gunaContextMenuStrip5
            // 
            this.gunaContextMenuStrip5.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip5.Name = "gunaContextMenuStrip5";
            this.gunaContextMenuStrip5.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip5.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip5.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip5.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip5.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip5.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip5.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip5.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip5.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // gunaContextMenuStrip6
            // 
            this.gunaContextMenuStrip6.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gunaContextMenuStrip6.Name = "gunaContextMenuStrip6";
            this.gunaContextMenuStrip6.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip6.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip6.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip6.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip6.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip6.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip6.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip6.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip6.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.AnimationHoverSpeed = 0.07F;
            this.btnSwitchTable.AnimationSpeed = 0.03F;
            this.btnSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchTable.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnSwitchTable.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnSwitchTable.BorderColor = System.Drawing.Color.Black;
            this.btnSwitchTable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSwitchTable.FocusedColor = System.Drawing.Color.Empty;
            this.btnSwitchTable.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchTable.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSwitchTable.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchTable.Image")));
            this.btnSwitchTable.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSwitchTable.Location = new System.Drawing.Point(454, 0);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnSwitchTable.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnSwitchTable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSwitchTable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSwitchTable.OnHoverImage = null;
            this.btnSwitchTable.OnPressedColor = System.Drawing.Color.White;
            this.btnSwitchTable.Radius = 6;
            this.btnSwitchTable.Size = new System.Drawing.Size(117, 117);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click_1);
            // 
            // nmDisCount
            // 
            this.nmDisCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nmDisCount.BackColor = System.Drawing.Color.Transparent;
            this.nmDisCount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.nmDisCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nmDisCount.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nmDisCount.ButtonForeColor = System.Drawing.Color.White;
            this.nmDisCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmDisCount.ForeColor = System.Drawing.Color.Black;
            this.nmDisCount.Location = new System.Drawing.Point(134, 55);
            this.nmDisCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmDisCount.Maximum = ((long)(100));
            this.nmDisCount.Minimum = ((long)(0));
            this.nmDisCount.Name = "nmDisCount";
            this.nmDisCount.Radius = 4;
            this.nmDisCount.Size = new System.Drawing.Size(92, 30);
            this.nmDisCount.TabIndex = 9;
            this.nmDisCount.Text = "gunaNumeric1";
            this.nmDisCount.Value = ((long)(0));
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.btnCheckOut);
            this.gunaGradientPanel1.Controls.Add(this.txbTotalPrice);
            this.gunaGradientPanel1.Controls.Add(this.nmDisCount);
            this.gunaGradientPanel1.Controls.Add(this.gunaGradientTileButton4);
            this.gunaGradientPanel1.Controls.Add(this.gunaGradientTileButton3);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(593, 505);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(683, 138);
            this.gunaGradientPanel1.TabIndex = 13;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AnimationHoverSpeed = 0.07F;
            this.btnCheckOut.AnimationSpeed = 0.03F;
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnCheckOut.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnCheckOut.BorderColor = System.Drawing.Color.Black;
            this.btnCheckOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheckOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCheckOut.Location = new System.Drawing.Point(545, 16);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnCheckOut.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnCheckOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCheckOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCheckOut.OnHoverImage = null;
            this.btnCheckOut.OnPressedColor = System.Drawing.Color.White;
            this.btnCheckOut.Radius = 6;
            this.btnCheckOut.Size = new System.Drawing.Size(117, 117);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // gunaGradientTileButton4
            // 
            this.gunaGradientTileButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton4.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton4.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton4.Image")));
            this.gunaGradientTileButton4.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton4.Location = new System.Drawing.Point(238, 16);
            this.gunaGradientTileButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientTileButton4.Name = "gunaGradientTileButton4";
            this.gunaGradientTileButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.OnHoverImage = null;
            this.gunaGradientTileButton4.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton4.Radius = 6;
            this.gunaGradientTileButton4.Size = new System.Drawing.Size(117, 117);
            this.gunaGradientTileButton4.TabIndex = 10;
            this.gunaGradientTileButton4.Text = "Tổng tiền";
            // 
            // gunaGradientTileButton3
            // 
            this.gunaGradientTileButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton3.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.gunaGradientTileButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradientTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton3.Image")));
            this.gunaGradientTileButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton3.Location = new System.Drawing.Point(9, 15);
            this.gunaGradientTileButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientTileButton3.Name = "gunaGradientTileButton3";
            this.gunaGradientTileButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradientTileButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradientTileButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.OnHoverImage = null;
            this.gunaGradientTileButton3.OnPressedColor = System.Drawing.Color.White;
            this.gunaGradientTileButton3.Radius = 6;
            this.gunaGradientTileButton3.Size = new System.Drawing.Size(117, 117);
            this.gunaGradientTileButton3.TabIndex = 9;
            this.gunaGradientTileButton3.Text = "Giảm giá";
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.nmFoodCount);
            this.gunaGradientPanel2.Controls.Add(this.cbCategory);
            this.gunaGradientPanel2.Controls.Add(this.cbFood);
            this.gunaGradientPanel2.Controls.Add(this.btnAddFood);
            this.gunaGradientPanel2.Controls.Add(this.btnSwitchTable);
            this.gunaGradientPanel2.Controls.Add(this.cbSwitchTable);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.White;
            this.gunaGradientPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(593, 41);
            this.gunaGradientPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(691, 122);
            this.gunaGradientPanel2.TabIndex = 14;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1878, 1044);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fTableManager";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý nhà hàng";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gunaContextMenuStrip2.ResumeLayout(false);
            this.gunaContextMenuStrip3.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.gunaGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip4;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip5;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip6;
        private Guna.UI.WinForms.GunaGradientTileButton btnAddFood;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI.WinForms.GunaNumeric nmFoodCount;
        private Guna.UI.WinForms.GunaGradientTileButton btnSwitchTable;
        private Guna.UI.WinForms.GunaNumeric nmDisCount;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton3;
        private Guna.UI.WinForms.GunaGradientTileButton btnCheckOut;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton4;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
    }
}