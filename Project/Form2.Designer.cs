namespace Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.IB_text_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.IB_pic_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // IB_text_Panel
            // 
            this.IB_text_Panel.AutoScroll = true;
            this.IB_text_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.IB_text_Panel.Location = new System.Drawing.Point(159, 46);
            this.IB_text_Panel.Name = "IB_text_Panel";
            this.IB_text_Panel.Size = new System.Drawing.Size(267, 97);
            this.IB_text_Panel.TabIndex = 0;
            this.IB_text_Panel.WrapContents = false;
            // 
            // IB_pic_Panel
            // 
            this.IB_pic_Panel.AutoScroll = true;
            this.IB_pic_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.IB_pic_Panel.Location = new System.Drawing.Point(432, 46);
            this.IB_pic_Panel.Name = "IB_pic_Panel";
            this.IB_pic_Panel.Size = new System.Drawing.Size(132, 97);
            this.IB_pic_Panel.TabIndex = 0;
            this.IB_pic_Panel.WrapContents = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(159, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 77);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(571, 46);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 97);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 477);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IB_pic_Panel);
            this.Controls.Add(this.IB_text_Panel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel IB_text_Panel;
        private System.Windows.Forms.FlowLayoutPanel IB_pic_Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}