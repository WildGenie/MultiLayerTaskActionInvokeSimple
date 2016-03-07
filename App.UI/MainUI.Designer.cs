namespace App.UI
{
    partial class MainUI
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
            this.testCall = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testCall
            // 
            this.testCall.Location = new System.Drawing.Point(12, 12);
            this.testCall.Name = "testCall";
            this.testCall.Size = new System.Drawing.Size(75, 23);
            this.testCall.TabIndex = 0;
            this.testCall.Text = "Invoke";
            this.testCall.UseVisualStyleBackColor = true;
            this.testCall.Click += new System.EventHandler(this.testCall_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Location = new System.Drawing.Point(12, 41);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(325, 220);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 150;
            // 
            // countText
            // 
            this.countText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countText.Location = new System.Drawing.Point(158, 12);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(179, 23);
            this.countText.TabIndex = 2;
            this.countText.Text = "Count: 0";
            this.countText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 273);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.testCall);
            this.Name = "MainUI";
            this.Text = "Multi Layer Task, Action, Invoke Simple";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testCall;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

