﻿namespace OctagonHelpdesk
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panelcontent = new System.Windows.Forms.Panel();
            this.containerstimer = new System.Windows.Forms.Timer(this.components);
            this.containerhome = new System.Windows.Forms.Panel();
            this.btneditartickets = new System.Windows.Forms.Button();
            this.paneltickets = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneluser = new System.Windows.Forms.Panel();
            this.panelouter = new System.Windows.Forms.Panel();
            this.panelhelp = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.panelsalir = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnverticket = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.btnagregarticket = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.addticketpicbx = new System.Windows.Forms.PictureBox();
            this.editpicturebox = new System.Windows.Forms.PictureBox();
            this.verpicturebox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerhome.SuspendLayout();
            this.paneltickets.SuspendLayout();
            this.panel1.SuspendLayout();
            this.paneluser.SuspendLayout();
            this.panelouter.SuspendLayout();
            this.panelhelp.SuspendLayout();
            this.panelsalir.SuspendLayout();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addticketpicbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verpicturebox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 25;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // panelcontent
            // 
            this.panelcontent.Location = new System.Drawing.Point(42, 25);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1227, 658);
            this.panelcontent.TabIndex = 1;
            // 
            // containerstimer
            // 
            this.containerstimer.Interval = 15;
            this.containerstimer.Tick += new System.EventHandler(this.containerstimer_Tick);
            // 
            // containerhome
            // 
            this.containerhome.Controls.Add(this.btneditartickets);
            this.containerhome.Controls.Add(this.btnverticket);
            this.containerhome.Controls.Add(this.verpicturebox);
            this.containerhome.Controls.Add(this.editpicturebox);
            this.containerhome.Controls.Add(this.paneltickets);
            this.containerhome.Controls.Add(this.btnagregarticket);
            this.containerhome.Controls.Add(this.addticketpicbx);
            this.containerhome.Location = new System.Drawing.Point(0, 53);
            this.containerhome.MaximumSize = new System.Drawing.Size(143, 150);
            this.containerhome.MinimumSize = new System.Drawing.Size(143, 39);
            this.containerhome.Name = "containerhome";
            this.containerhome.Size = new System.Drawing.Size(143, 39);
            this.containerhome.TabIndex = 0;
            // 
            // btneditartickets
            // 
            this.btneditartickets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btneditartickets.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuText;
            this.btneditartickets.FlatAppearance.BorderSize = 0;
            this.btneditartickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditartickets.Location = new System.Drawing.Point(51, 112);
            this.btneditartickets.Margin = new System.Windows.Forms.Padding(0);
            this.btneditartickets.Name = "btneditartickets";
            this.btneditartickets.Size = new System.Drawing.Size(92, 37);
            this.btneditartickets.TabIndex = 4;
            this.btneditartickets.Text = "Editar tickets";
            this.btneditartickets.UseVisualStyleBackColor = false;
            this.btneditartickets.Click += new System.EventHandler(this.btneditartickets_Click);
            // 
            // paneltickets
            // 
            this.paneltickets.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.paneltickets.Controls.Add(this.homebtn);
            this.paneltickets.Location = new System.Drawing.Point(0, 0);
            this.paneltickets.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.paneltickets.Name = "paneltickets";
            this.paneltickets.Size = new System.Drawing.Size(143, 39);
            this.paneltickets.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(143, 39);
            this.panel1.TabIndex = 7;
            // 
            // paneluser
            // 
            this.paneluser.Controls.Add(this.btnuser);
            this.paneluser.Location = new System.Drawing.Point(0, 92);
            this.paneluser.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.paneluser.Name = "paneluser";
            this.paneluser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.paneluser.Size = new System.Drawing.Size(143, 39);
            this.paneluser.TabIndex = 4;
            // 
            // panelouter
            // 
            this.panelouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelouter.BackgroundImage")));
            this.panelouter.Controls.Add(this.panelhelp);
            this.panelouter.Controls.Add(this.containerhome);
            this.panelouter.Controls.Add(this.paneluser);
            this.panelouter.Controls.Add(this.panelsalir);
            this.panelouter.Controls.Add(this.panel1);
            this.panelouter.Controls.Add(this.panelmenu);
            this.panelouter.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelouter.Location = new System.Drawing.Point(0, 0);
            this.panelouter.MaximumSize = new System.Drawing.Size(143, 740);
            this.panelouter.MinimumSize = new System.Drawing.Size(50, 740);
            this.panelouter.Name = "panelouter";
            this.panelouter.Size = new System.Drawing.Size(143, 740);
            this.panelouter.TabIndex = 0;
            // 
            // panelhelp
            // 
            this.panelhelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelhelp.Controls.Add(this.btnhelp);
            this.panelhelp.Location = new System.Drawing.Point(0, 603);
            this.panelhelp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelhelp.Name = "panelhelp";
            this.panelhelp.Size = new System.Drawing.Size(143, 39);
            this.panelhelp.TabIndex = 6;
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.DarkGray;
            this.btnhelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhelp.Image = global::OctagonHelpdesk.Properties.Resources.question;
            this.btnhelp.Location = new System.Drawing.Point(-12, -17);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(166, 75);
            this.btnhelp.TabIndex = 2;
            this.btnhelp.Text = "  Help";
            this.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhelp.UseVisualStyleBackColor = false;
            // 
            // panelsalir
            // 
            this.panelsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelsalir.Controls.Add(this.btnsalir);
            this.panelsalir.Location = new System.Drawing.Point(0, 642);
            this.panelsalir.Name = "panelsalir";
            this.panelsalir.Size = new System.Drawing.Size(143, 39);
            this.panelsalir.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkGray;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Image = global::OctagonHelpdesk.Properties.Resources.logout;
            this.btnsalir.Location = new System.Drawing.Point(-12, -17);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(166, 75);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "  Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.btnmenu);
            this.panelmenu.Location = new System.Drawing.Point(0, 1);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(143, 49);
            this.panelmenu.TabIndex = 2;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnmenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmenu.Image = global::OctagonHelpdesk.Properties.Resources.menu_1_;
            this.btnmenu.Location = new System.Drawing.Point(-23, -15);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(190, 82);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "     Menu";
            this.btnmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // btnverticket
            // 
            this.btnverticket.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnverticket.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnverticket.FlatAppearance.BorderSize = 0;
            this.btnverticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverticket.Location = new System.Drawing.Point(51, 72);
            this.btnverticket.Margin = new System.Windows.Forms.Padding(0);
            this.btnverticket.Name = "btnverticket";
            this.btnverticket.Size = new System.Drawing.Size(92, 40);
            this.btnverticket.TabIndex = 2;
            this.btnverticket.Text = "   Ver tickets";
            this.btnverticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnverticket.UseVisualStyleBackColor = false;
            this.btnverticket.Click += new System.EventHandler(this.btnverticket_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.DarkGray;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homebtn.Image = global::OctagonHelpdesk.Properties.Resources.addticket;
            this.homebtn.Location = new System.Drawing.Point(-12, -19);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(166, 75);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "  Tickets";
            this.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // btnagregarticket
            // 
            this.btnagregarticket.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnagregarticket.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregarticket.FlatAppearance.BorderSize = 0;
            this.btnagregarticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregarticket.Location = new System.Drawing.Point(51, 39);
            this.btnagregarticket.Margin = new System.Windows.Forms.Padding(0);
            this.btnagregarticket.Name = "btnagregarticket";
            this.btnagregarticket.Size = new System.Drawing.Size(92, 37);
            this.btnagregarticket.TabIndex = 0;
            this.btnagregarticket.Text = "   Agregar ticket";
            this.btnagregarticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarticket.UseVisualStyleBackColor = false;
            this.btnagregarticket.Click += new System.EventHandler(this.btnagregarticket_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-12, -17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "  Temp";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.DarkGray;
            this.btnuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnuser.Image = global::OctagonHelpdesk.Properties.Resources.user;
            this.btnuser.Location = new System.Drawing.Point(-13, -21);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(166, 75);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "   Usuario";
            this.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuser.UseVisualStyleBackColor = false;
            // 
            // addticketpicbx
            // 
            this.addticketpicbx.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.addticketpicbx.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.plus;
            this.addticketpicbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addticketpicbx.Location = new System.Drawing.Point(0, 39);
            this.addticketpicbx.Name = "addticketpicbx";
            this.addticketpicbx.Size = new System.Drawing.Size(54, 37);
            this.addticketpicbx.TabIndex = 8;
            this.addticketpicbx.TabStop = false;
            this.addticketpicbx.Click += new System.EventHandler(this.addticketpicbx_Click);
            // 
            // editpicturebox
            // 
            this.editpicturebox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editpicturebox.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.plus;
            this.editpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editpicturebox.Location = new System.Drawing.Point(0, 110);
            this.editpicturebox.Name = "editpicturebox";
            this.editpicturebox.Size = new System.Drawing.Size(54, 42);
            this.editpicturebox.TabIndex = 9;
            this.editpicturebox.TabStop = false;
            this.editpicturebox.Click += new System.EventHandler(this.editpicturebox_Click);
            // 
            // verpicturebox
            // 
            this.verpicturebox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.verpicturebox.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.see;
            this.verpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.verpicturebox.Location = new System.Drawing.Point(-1, 72);
            this.verpicturebox.Name = "verpicturebox";
            this.verpicturebox.Size = new System.Drawing.Size(54, 40);
            this.verpicturebox.TabIndex = 10;
            this.verpicturebox.TabStop = false;
            this.verpicturebox.Click += new System.EventHandler(this.verpicturebox_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.helpMenu});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(143, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(60, 19);
            this.fileMenu.Text = "Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.newToolStripMenuItem.Text = "&Nuevo";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.openToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveToolStripMenuItem.Text = "&Guardar";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saveAsToolStripMenuItem.Text = "Guardar &como";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.printToolStripMenuItem.Text = "&Imprimir";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.printSetupToolStripMenuItem.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 19);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelouter);
            this.Controls.Add(this.panelcontent);
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Frame";
            this.ShowIcon = false;
            this.Text = "Frame";
            this.containerhome.ResumeLayout(false);
            this.paneltickets.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.paneluser.ResumeLayout(false);
            this.panelouter.ResumeLayout(false);
            this.panelhelp.ResumeLayout(false);
            this.panelsalir.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addticketpicbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verpicturebox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelouter;
        private System.Windows.Forms.Panel paneltickets;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Panel panelsalir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panelhelp;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel containerhome;
        private System.Windows.Forms.Button btnagregarticket;
        private System.Windows.Forms.Timer containerstimer;
        private System.Windows.Forms.Button btneditartickets;
        private System.Windows.Forms.Button btnverticket;
        private System.Windows.Forms.PictureBox verpicturebox;
        private System.Windows.Forms.PictureBox addticketpicbx;
        private System.Windows.Forms.PictureBox editpicturebox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}