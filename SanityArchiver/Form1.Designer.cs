namespace SanityArchiver
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asddwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Compress = new System.Windows.Forms.Button();
            this.Crypt = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDeleteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.pathTextBox2 = new System.Windows.Forms.TextBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openButton2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBox2 = new System.Windows.Forms.TextBox();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(291, 11);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(24, 21);
            this.openButton.TabIndex = 18;
            this.openButton.Text = "...";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(70, 11);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(223, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "directory.jpg");
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(17, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 325);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adasdToolStripMenuItem,
            this.asdasdToolStripMenuItem,
            this.asddwToolStripMenuItem,
            this.qqToolStripMenuItem,
            this.compressToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.readOnlyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 158);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // adasdToolStripMenuItem
            // 
            this.adasdToolStripMenuItem.Name = "adasdToolStripMenuItem";
            this.adasdToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adasdToolStripMenuItem.Text = "Hide";
            this.adasdToolStripMenuItem.Click += new System.EventHandler(this.adasdToolStripMenuItem_Click);
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.asdasdToolStripMenuItem.Text = "Copy";
            this.asdasdToolStripMenuItem.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // asddwToolStripMenuItem
            // 
            this.asddwToolStripMenuItem.Name = "asddwToolStripMenuItem";
            this.asddwToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.asddwToolStripMenuItem.Text = "Move";
            this.asddwToolStripMenuItem.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // qqToolStripMenuItem
            // 
            this.qqToolStripMenuItem.Name = "qqToolStripMenuItem";
            this.qqToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.qqToolStripMenuItem.Text = "Crypt";
            this.qqToolStripMenuItem.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Compress
            // 
            this.Compress.Location = new System.Drawing.Point(275, 418);
            this.Compress.Name = "Compress";
            this.Compress.Size = new System.Drawing.Size(105, 23);
            this.Compress.TabIndex = 5;
            this.Compress.Text = "Compress";
            this.Compress.UseVisualStyleBackColor = true;
            this.Compress.Visible = false;
            this.Compress.Click += new System.EventHandler(this.Compress_Click);
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(164, 418);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(105, 23);
            this.Crypt.TabIndex = 6;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Visible = false;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Name:";
            // 
            // fileDeleteButton
            // 
            this.fileDeleteButton.Location = new System.Drawing.Point(386, 418);
            this.fileDeleteButton.Name = "fileDeleteButton";
            this.fileDeleteButton.Size = new System.Drawing.Size(105, 23);
            this.fileDeleteButton.TabIndex = 10;
            this.fileDeleteButton.Text = "Delete";
            this.fileDeleteButton.UseVisualStyleBackColor = true;
            this.fileDeleteButton.Visible = false;
            this.fileDeleteButton.Click += new System.EventHandler(this.fileDeleteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(497, 418);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(105, 23);
            this.copyButton.TabIndex = 11;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Visible = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(53, 418);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(105, 23);
            this.moveButton.TabIndex = 12;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Visible = false;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // listView2
            // 
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(338, 67);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(298, 325);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // pathTextBox2
            // 
            this.pathTextBox2.Location = new System.Drawing.Point(386, 11);
            this.pathTextBox2.Name = "pathTextBox2";
            this.pathTextBox2.Size = new System.Drawing.Size(228, 20);
            this.pathTextBox2.TabIndex = 14;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(386, 38);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(250, 20);
            this.nameTextBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "File Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "File Name:";
            // 
            // openButton2
            // 
            this.openButton2.Location = new System.Drawing.Point(612, 11);
            this.openButton2.Name = "openButton2";
            this.openButton2.Size = new System.Drawing.Size(24, 20);
            this.openButton2.TabIndex = 18;
            this.openButton2.Text = "...";
            this.openButton2.UseVisualStyleBackColor = true;
            this.openButton2.Click += new System.EventHandler(this.openButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Directory Size: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Directory Size: ";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(164, 392);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(151, 20);
            this.searchBox.TabIndex = 21;
            this.searchBox.Text = "Search...";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchBox2
            // 
            this.searchBox2.Location = new System.Drawing.Point(485, 392);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.Size = new System.Drawing.Size(151, 20);
            this.searchBox2.TabIndex = 22;
            this.searchBox2.Text = "Search...";
            this.searchBox2.TextChanged += new System.EventHandler(this.searchBox2_TextChanged);
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compressToolStripMenuItem.Text = "Compress";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.Compress_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.fileDeleteButton_Click);
            // 
            // readOnlyToolStripMenuItem
            // 
            this.readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            this.readOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readOnlyToolStripMenuItem.Text = "Read-Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 421);
            this.Controls.Add(this.searchBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.openButton2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox2);
            this.Controls.Add(this.pathTextBox2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.fileDeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.Compress);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pathTextBox);
            this.Name = "Form1";
            this.Text = "Sanity Archiver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Compress;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fileDeleteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox pathTextBox2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asddwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qqToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.TextBox searchBox2;
        private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readOnlyToolStripMenuItem;
    }
}

