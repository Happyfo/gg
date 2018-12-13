namespace WindowsFormsApp2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("calculator");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("UTILITIES", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Room");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("STUDENTS", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.aggy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, -1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "calculator";
            treeNode2.Name = "Node0";
            treeNode2.Text = "UTILITIES";
            treeNode3.Name = "Node13";
            treeNode3.Text = "Room";
            treeNode4.Name = "Node12";
            treeNode4.Text = "STUDENTS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(239, 450);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.calculator);
            // 
            // aggy
            // 
            this.aggy.Location = new System.Drawing.Point(251, -1);
            this.aggy.Name = "aggy";
            this.aggy.Size = new System.Drawing.Size(549, 450);
            this.aggy.TabIndex = 1;
            this.aggy.DoubleClick += new System.EventHandler(this.calculator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aggy);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel aggy;
    }
}

