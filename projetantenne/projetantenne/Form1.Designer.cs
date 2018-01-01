namespace projetantenne
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
            this.map = new SharpMap.Forms.MapBox();
            this.MyMap = new SharpMap.Forms.MapBox();
            this.lbl = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.map.Cursor = System.Windows.Forms.Cursors.Default;
            this.map.FineZoomFactor = 10D;
            this.map.Location = new System.Drawing.Point(12, 114);
            this.map.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.map.Name = "map";
            this.map.QueryGrowFactor = 5F;
            this.map.QueryLayerIndex = 0;
            this.map.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.map.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.map.ShowProgressUpdate = false;
            this.map.Size = new System.Drawing.Size(565, 294);
            this.map.TabIndex = 0;
            this.map.Text = "mapBox1";
            this.map.WheelZoomMagnitude = -2D;
            // 
            // MyMap
            // 
            this.MyMap.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.MyMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MyMap.FineZoomFactor = 10D;
            this.MyMap.Location = new System.Drawing.Point(105, 12);
            this.MyMap.MapQueryMode = SharpMap.Forms.MapBox.MapQueryType.LayerByIndex;
            this.MyMap.Name = "MyMap";
            this.MyMap.QueryGrowFactor = 5F;
            this.MyMap.QueryLayerIndex = 0;
            this.MyMap.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MyMap.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.MyMap.ShowProgressUpdate = false;
            this.MyMap.Size = new System.Drawing.Size(447, 370);
            this.MyMap.TabIndex = 1;
            this.MyMap.Text = "mapBox1";
            this.MyMap.WheelZoomMagnitude = -2D;
            this.MyMap.MouseDown += new SharpMap.Forms.MapBox.MouseEventHandler(this.MyMap_MouseDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 398);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(12, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 3;
            this.X.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(12, 43);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 6;
            this.Y.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 420);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.MyMap);
            this.Controls.Add(this.map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpMap.Forms.MapBox map;
        private SharpMap.Forms.MapBox MyMap;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Y;
    }
}

