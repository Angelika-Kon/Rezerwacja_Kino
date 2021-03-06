
namespace po
{
	partial class KinoWPF
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
			if(disposing && ( components != null ))
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
            this.Miejsca = new System.Windows.Forms.FlowLayoutPanel();
            this.ListaRepertuarow = new System.Windows.Forms.ListBox();
            this.Seanse = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.StanKonta = new System.Windows.Forms.Label();
            this.Informations = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Miejsca
            // 
            this.Miejsca.AutoScroll = true;
            this.Miejsca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Miejsca.Location = new System.Drawing.Point(484, 68);
            this.Miejsca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Miejsca.Name = "Miejsca";
            this.Miejsca.Size = new System.Drawing.Size(1160, 191);
            this.Miejsca.TabIndex = 2;
            // 
            // ListaRepertuarow
            // 
            this.ListaRepertuarow.FormattingEnabled = true;
            this.ListaRepertuarow.ItemHeight = 16;
            this.ListaRepertuarow.Location = new System.Drawing.Point(16, 52);
            this.ListaRepertuarow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListaRepertuarow.Name = "ListaRepertuarow";
            this.ListaRepertuarow.Size = new System.Drawing.Size(233, 436);
            this.ListaRepertuarow.TabIndex = 3;
            this.ListaRepertuarow.SelectedIndexChanged += new System.EventHandler(this.ZmienionoRepertuar);
            // 
            // Seanse
            // 
            this.Seanse.FormattingEnabled = true;
            this.Seanse.ItemHeight = 16;
            this.Seanse.Location = new System.Drawing.Point(260, 52);
            this.Seanse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Seanse.Name = "Seanse";
            this.Seanse.Size = new System.Drawing.Size(215, 436);
            this.Seanse.TabIndex = 4;
            this.Seanse.SelectedIndexChanged += new System.EventHandler(this.ZmienionoSeans);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1252, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stan konta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StanKonta
            // 
            this.StanKonta.AutoSize = true;
            this.StanKonta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StanKonta.Location = new System.Drawing.Point(1452, 20);
            this.StanKonta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StanKonta.Name = "StanKonta";
            this.StanKonta.Size = new System.Drawing.Size(179, 39);
            this.StanKonta.TabIndex = 13;
            this.StanKonta.Text = "Stan konta";
            // 
            // Informations
            // 
            this.Informations.AutoSize = true;
            this.Informations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Informations.Location = new System.Drawing.Point(484, 262);
            this.Informations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Informations.MaximumSize = new System.Drawing.Size(1067, 0);
            this.Informations.Name = "Informations";
            this.Informations.Size = new System.Drawing.Size(0, 31);
            this.Informations.TabIndex = 14;
            this.Informations.Click += new System.EventHandler(this.Informations_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(484, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dostępne miejsca:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dzień";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(252, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Filmy";
            // 
            // KinoWPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Informations);
            this.Controls.Add(this.StanKonta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seanse);
            this.Controls.Add(this.ListaRepertuarow);
            this.Controls.Add(this.Miejsca);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KinoWPF";
            this.Text = "KinoWPF";
            this.Load += new System.EventHandler(this.KinoWPF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel Miejsca;
		private System.Windows.Forms.ListBox ListaRepertuarow;
		private System.Windows.Forms.ListBox Seanse;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.FontDialog fontDialog2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label StanKonta;
		private System.Windows.Forms.Label Informations;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}