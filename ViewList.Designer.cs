namespace PAIN_lab2
{
    partial class ViewList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewList));
            this.toolStripList = new System.Windows.Forms.ToolStrip();
            this.newPointButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButtonList = new System.Windows.Forms.ToolStripButton();
            this.ModifyButtonList = new System.Windows.Forms.ToolStripButton();
            this.listView = new System.Windows.Forms.ListView();
            this.label = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripList.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripList
            // 
            this.toolStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPointButton,
            this.DeleteButtonList,
            this.ModifyButtonList});
            this.toolStripList.Location = new System.Drawing.Point(0, 0);
            this.toolStripList.Name = "toolStripList";
            this.toolStripList.Size = new System.Drawing.Size(297, 25);
            this.toolStripList.TabIndex = 0;
            this.toolStripList.Text = "toolStrip1";
            this.toolStripList.Visible = false;
            // 
            // newPointButton
            // 
            this.newPointButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPointButton.Image = ((System.Drawing.Image)(resources.GetObject("newPointButton.Image")));
            this.newPointButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPointButton.Name = "newPointButton";
            this.newPointButton.Size = new System.Drawing.Size(23, 22);
            this.newPointButton.Text = "newPoint";
            this.newPointButton.Click += new System.EventHandler(this.toolNewPoint_Click);
            // 
            // DeleteButtonList
            // 
            this.DeleteButtonList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButtonList.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonList.Image")));
            this.DeleteButtonList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButtonList.Name = "DeleteButtonList";
            this.DeleteButtonList.Size = new System.Drawing.Size(23, 22);
            this.DeleteButtonList.Text = "toolStripButton1";
            this.DeleteButtonList.Click += new System.EventHandler(this.DeleteButtonList_Click);
            // 
            // ModifyButtonList
            // 
            this.ModifyButtonList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModifyButtonList.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButtonList.Image")));
            this.ModifyButtonList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyButtonList.Name = "ModifyButtonList";
            this.ModifyButtonList.Size = new System.Drawing.Size(23, 22);
            this.ModifyButtonList.Text = "toolStripButton2";
            this.ModifyButtonList.Click += new System.EventHandler(this.ModifyButtonList_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.label,
            this.x,
            this.y,
            this.colour});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(0, 18);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(297, 322);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // label
            // 
            this.label.Text = "person";
            this.label.Width = 115;
            // 
            // x
            // 
            this.x.Text = "x";
            this.x.Width = 34;
            // 
            // y
            // 
            this.y.Text = "y";
            this.y.Width = 38;
            // 
            // colour
            // 
            this.colour.Text = "colour";
            this.colour.Width = 109;
            // 
            // ViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 352);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStripList);
            this.Name = "ViewList";
            this.Text = "ViewList";
            this.Activated += new System.EventHandler(this.ViewList_Activated);
            this.Deactivate += new System.EventHandler(this.ViewList_Deactivate);
            this.toolStripList.ResumeLayout(false);
            this.toolStripList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripList;
        private System.Windows.Forms.ToolStripButton newPointButton;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader label;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader y;
        private System.Windows.Forms.ColumnHeader colour;
        private System.Windows.Forms.ToolStripButton DeleteButtonList;
        private System.Windows.Forms.ToolStripButton ModifyButtonList;
    }
}