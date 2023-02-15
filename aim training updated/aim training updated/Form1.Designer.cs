
namespace aim_training_updated
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m1_hard_RBT = new System.Windows.Forms.RadioButton();
            this.m1_med_RBT = new System.Windows.Forms.RadioButton();
            this.m1_easy_RBT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m2_hard_RBT = new System.Windows.Forms.RadioButton();
            this.m2_med_RBT = new System.Windows.Forms.RadioButton();
            this.m2_easy_RBT = new System.Windows.Forms.RadioButton();
            this.firstMode_RBT = new System.Windows.Forms.RadioButton();
            this.secondMode_RBT = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m1_hard_RBT);
            this.groupBox1.Controls.Add(this.m1_med_RBT);
            this.groupBox1.Controls.Add(this.m1_easy_RBT);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // m1_hard_RBT
            // 
            resources.ApplyResources(this.m1_hard_RBT, "m1_hard_RBT");
            this.m1_hard_RBT.Name = "m1_hard_RBT";
            this.m1_hard_RBT.UseVisualStyleBackColor = true;
            // 
            // m1_med_RBT
            // 
            resources.ApplyResources(this.m1_med_RBT, "m1_med_RBT");
            this.m1_med_RBT.Name = "m1_med_RBT";
            this.m1_med_RBT.UseVisualStyleBackColor = true;
            // 
            // m1_easy_RBT
            // 
            resources.ApplyResources(this.m1_easy_RBT, "m1_easy_RBT");
            this.m1_easy_RBT.Name = "m1_easy_RBT";
            this.m1_easy_RBT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m2_hard_RBT);
            this.groupBox2.Controls.Add(this.m2_med_RBT);
            this.groupBox2.Controls.Add(this.m2_easy_RBT);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // m2_hard_RBT
            // 
            resources.ApplyResources(this.m2_hard_RBT, "m2_hard_RBT");
            this.m2_hard_RBT.Name = "m2_hard_RBT";
            this.m2_hard_RBT.UseVisualStyleBackColor = true;
            // 
            // m2_med_RBT
            // 
            resources.ApplyResources(this.m2_med_RBT, "m2_med_RBT");
            this.m2_med_RBT.Name = "m2_med_RBT";
            this.m2_med_RBT.UseVisualStyleBackColor = true;
            // 
            // m2_easy_RBT
            // 
            resources.ApplyResources(this.m2_easy_RBT, "m2_easy_RBT");
            this.m2_easy_RBT.Name = "m2_easy_RBT";
            this.m2_easy_RBT.UseVisualStyleBackColor = true;
            // 
            // firstMode_RBT
            // 
            resources.ApplyResources(this.firstMode_RBT, "firstMode_RBT");
            this.firstMode_RBT.Name = "firstMode_RBT";
            this.firstMode_RBT.UseVisualStyleBackColor = true;
            this.firstMode_RBT.CheckedChanged += new System.EventHandler(this.firstMode_RBT_CheckedChanged);
            // 
            // secondMode_RBT
            // 
            resources.ApplyResources(this.secondMode_RBT, "secondMode_RBT");
            this.secondMode_RBT.Name = "secondMode_RBT";
            this.secondMode_RBT.UseVisualStyleBackColor = true;
            this.secondMode_RBT.CheckedChanged += new System.EventHandler(this.secondMode_RBT_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondMode_RBT);
            this.Controls.Add(this.firstMode_RBT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton firstMode_RBT;
        private System.Windows.Forms.RadioButton secondMode_RBT;
        private System.Windows.Forms.RadioButton m1_hard_RBT;
        private System.Windows.Forms.RadioButton m1_med_RBT;
        private System.Windows.Forms.RadioButton m1_easy_RBT;
        private System.Windows.Forms.RadioButton m2_hard_RBT;
        private System.Windows.Forms.RadioButton m2_med_RBT;
        private System.Windows.Forms.RadioButton m2_easy_RBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

