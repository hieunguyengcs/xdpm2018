namespace XDPM2018_DiskManagement.UserControls
{
    partial class ucDiskManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ucCustomer1 = new XDPM2018_DiskManagement.UserControls.ucCustomer();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(7, 42);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(790, 229);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = global::XDPM2018_DiskManagement.Properties.Resources.left_arrow;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroLink1.Location = new System.Drawing.Point(762, 3);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(35, 35);
            this.metroLink1.TabIndex = 0;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "QUẢN LÝ ĐĨA";
            // 
            // ucCustomer1
            // 
            this.ucCustomer1.Location = new System.Drawing.Point(7, 277);
            this.ucCustomer1.Name = "ucCustomer1";
            this.ucCustomer1.Size = new System.Drawing.Size(395, 150);
            this.ucCustomer1.TabIndex = 6;
            // 
            // ucListOfDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucCustomer1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.metroLink1);
            this.Name = "ucListOfDisk";
            this.Size = new System.Drawing.Size(800, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private ucCustomer ucCustomer1;
    }
}
