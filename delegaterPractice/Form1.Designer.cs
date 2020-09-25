namespace delegaterPractice
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnSort3 = new System.Windows.Forms.Button();
            this.btnSortReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 18;
            this.listBoxProducts.Location = new System.Drawing.Point(13, 13);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(220, 328);
            this.listBoxProducts.TabIndex = 0;
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(13, 348);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(220, 33);
            this.btnSort1.TabIndex = 1;
            this.btnSort1.Text = "정렬(함수이름)";
            this.btnSort1.UseVisualStyleBackColor = true;
            // 
            // btnSort2
            // 
            this.btnSort2.Location = new System.Drawing.Point(12, 387);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(220, 33);
            this.btnSort2.TabIndex = 2;
            this.btnSort2.Text = "정렬(익명 델리게이터)";
            this.btnSort2.UseVisualStyleBackColor = true;
            // 
            // btnSort3
            // 
            this.btnSort3.Location = new System.Drawing.Point(13, 426);
            this.btnSort3.Name = "btnSort3";
            this.btnSort3.Size = new System.Drawing.Size(220, 33);
            this.btnSort3.TabIndex = 3;
            this.btnSort3.Text = "정렬(람다)";
            this.btnSort3.UseVisualStyleBackColor = true;
            // 
            // btnSortReset
            // 
            this.btnSortReset.Location = new System.Drawing.Point(13, 465);
            this.btnSortReset.Name = "btnSortReset";
            this.btnSortReset.Size = new System.Drawing.Size(220, 33);
            this.btnSortReset.TabIndex = 4;
            this.btnSortReset.Text = "정렬 초기화";
            this.btnSortReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 562);
            this.Controls.Add(this.btnSortReset);
            this.Controls.Add(this.btnSort3);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Button btnSort3;
        private System.Windows.Forms.Button btnSortReset;
    }
}

