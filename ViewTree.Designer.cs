namespace PAIN_lab2
{
    partial class ViewTree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("people");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTree));
            this.treeView = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newPointButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButtonTree = new System.Windows.Forms.ToolStripButton();
            this.ModifyButtonTree = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(0, 28);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Node0";
            treeNode1.Text = "people";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.Size = new System.Drawing.Size(284, 406);
            this.treeView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPointButton,
            this.DeleteButtonTree,
            this.ModifyButtonTree});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
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
            // DeleteButtonTree
            // 
            this.DeleteButtonTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButtonTree.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButtonTree.Image")));
            this.DeleteButtonTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButtonTree.Name = "DeleteButtonTree";
            this.DeleteButtonTree.Size = new System.Drawing.Size(23, 22);
            this.DeleteButtonTree.Text = "DeleteButtonTree";
            this.DeleteButtonTree.Click += new System.EventHandler(this.DeleteButtonTree_Click);
            // 
            // ModifyButtonTree
            // 
            this.ModifyButtonTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModifyButtonTree.Image = ((System.Drawing.Image)(resources.GetObject("ModifyButtonTree.Image")));
            this.ModifyButtonTree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModifyButtonTree.Name = "ModifyButtonTree";
            this.ModifyButtonTree.Size = new System.Drawing.Size(23, 22);
            this.ModifyButtonTree.Text = "toolStripButton2";
            this.ModifyButtonTree.Click += new System.EventHandler(this.ModifyButtonTree_Click);
            // 
            // ViewTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 437);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView);
            this.Name = "ViewTree";
            this.Text = "ViewTree";
            this.Activated += new System.EventHandler(this.ViewTree_Activated);
            this.Deactivate += new System.EventHandler(this.ViewTree_Deactivate);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newPointButton;
        private System.Windows.Forms.ToolStripButton DeleteButtonTree;
        private System.Windows.Forms.ToolStripButton ModifyButtonTree;

    }
}