namespace Test_H5_Klasse_Pokemon_LEEG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonValAan1 = new System.Windows.Forms.Button();
            this.buttonValAan2 = new System.Windows.Forms.Button();
            this.labelGezondheid1 = new System.Windows.Forms.Label();
            this.labelGezondheid2 = new System.Windows.Forms.Label();
            this.buttonGenees1 = new System.Windows.Forms.Button();
            this.buttonGenees2 = new System.Windows.Forms.Button();
            this.buttonToonPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speler 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speler 2";
            // 
            // buttonValAan1
            // 
            this.buttonValAan1.Location = new System.Drawing.Point(65, 108);
            this.buttonValAan1.Name = "buttonValAan1";
            this.buttonValAan1.Size = new System.Drawing.Size(154, 23);
            this.buttonValAan1.TabIndex = 3;
            this.buttonValAan1.Text = "Val speler 2 aan...";
            this.buttonValAan1.UseVisualStyleBackColor = true;
            // 
            // buttonValAan2
            // 
            this.buttonValAan2.Location = new System.Drawing.Point(341, 108);
            this.buttonValAan2.Name = "buttonValAan2";
            this.buttonValAan2.Size = new System.Drawing.Size(154, 23);
            this.buttonValAan2.TabIndex = 4;
            this.buttonValAan2.Text = "Val speler 1 aan...";
            this.buttonValAan2.UseVisualStyleBackColor = true;
            // 
            // labelGezondheid1
            // 
            this.labelGezondheid1.AutoSize = true;
            this.labelGezondheid1.Location = new System.Drawing.Point(62, 75);
            this.labelGezondheid1.Name = "labelGezondheid1";
            this.labelGezondheid1.Size = new System.Drawing.Size(86, 16);
            this.labelGezondheid1.TabIndex = 5;
            this.labelGezondheid1.Text = "Gezondheid: ";
            // 
            // labelGezondheid2
            // 
            this.labelGezondheid2.AutoSize = true;
            this.labelGezondheid2.Location = new System.Drawing.Point(352, 75);
            this.labelGezondheid2.Name = "labelGezondheid2";
            this.labelGezondheid2.Size = new System.Drawing.Size(86, 16);
            this.labelGezondheid2.TabIndex = 6;
            this.labelGezondheid2.Text = "Gezondheid: ";
            // 
            // buttonGenees1
            // 
            this.buttonGenees1.Location = new System.Drawing.Point(65, 148);
            this.buttonGenees1.Name = "buttonGenees1";
            this.buttonGenees1.Size = new System.Drawing.Size(154, 23);
            this.buttonGenees1.TabIndex = 7;
            this.buttonGenees1.Text = "Genees";
            this.buttonGenees1.UseVisualStyleBackColor = true;
            // 
            // buttonGenees2
            // 
            this.buttonGenees2.Location = new System.Drawing.Point(341, 148);
            this.buttonGenees2.Name = "buttonGenees2";
            this.buttonGenees2.Size = new System.Drawing.Size(154, 23);
            this.buttonGenees2.TabIndex = 8;
            this.buttonGenees2.Text = "Genees";
            this.buttonGenees2.UseVisualStyleBackColor = true;
            // 
            // buttonToonPos
            // 
            this.buttonToonPos.Location = new System.Drawing.Point(203, 198);
            this.buttonToonPos.Name = "buttonToonPos";
            this.buttonToonPos.Size = new System.Drawing.Size(175, 23);
            this.buttonToonPos.TabIndex = 9;
            this.buttonToonPos.Text = "Toon posities";
            this.buttonToonPos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 242);
            this.Controls.Add(this.buttonToonPos);
            this.Controls.Add(this.buttonGenees2);
            this.Controls.Add(this.buttonGenees1);
            this.Controls.Add(this.labelGezondheid2);
            this.Controls.Add(this.labelGezondheid1);
            this.Controls.Add(this.buttonValAan2);
            this.Controls.Add(this.buttonValAan1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pokemon game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonValAan1;
        private System.Windows.Forms.Button buttonValAan2;
        private System.Windows.Forms.Label labelGezondheid1;
        private System.Windows.Forms.Label labelGezondheid2;
        private System.Windows.Forms.Button buttonGenees1;
        private System.Windows.Forms.Button buttonGenees2;
        private System.Windows.Forms.Button buttonToonPos;
    }
}

