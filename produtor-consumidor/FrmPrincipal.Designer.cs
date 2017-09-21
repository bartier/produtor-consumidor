namespace produtor_consumidor
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel = new System.Windows.Forms.Panel();
            this.txtMensagens = new System.Windows.Forms.TextBox();
            this.pbBox = new System.Windows.Forms.PictureBox();
            this.panelBananas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.pbConsumidor = new System.Windows.Forms.PictureBox();
            this.pbProdutor = new System.Windows.Forms.PictureBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnSalvarLog = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.panelBananas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsumidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtMensagens);
            this.panel.Controls.Add(this.pbBox);
            this.panel.Location = new System.Drawing.Point(33, 158);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(758, 277);
            this.panel.TabIndex = 2;
            // 
            // txtMensagens
            // 
            this.txtMensagens.BackColor = System.Drawing.Color.Black;
            this.txtMensagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagens.ForeColor = System.Drawing.Color.White;
            this.txtMensagens.Location = new System.Drawing.Point(14, 10);
            this.txtMensagens.Multiline = true;
            this.txtMensagens.Name = "txtMensagens";
            this.txtMensagens.ReadOnly = true;
            this.txtMensagens.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtMensagens.Size = new System.Drawing.Size(733, 230);
            this.txtMensagens.TabIndex = 1;
            this.txtMensagens.TabStop = false;
            this.txtMensagens.Text = "Clique em iniciar para começar.";
            // 
            // pbBox
            // 
            this.pbBox.Image = global::produtor_consumidor.Properties.Resources.box;
            this.pbBox.Location = new System.Drawing.Point(3, -1);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(753, 251);
            this.pbBox.TabIndex = 0;
            this.pbBox.TabStop = false;
            // 
            // panelBananas
            // 
            this.panelBananas.Controls.Add(this.label1);
            this.panelBananas.Controls.Add(this.pb4);
            this.panelBananas.Controls.Add(this.pb3);
            this.panelBananas.Controls.Add(this.pb2);
            this.panelBananas.Controls.Add(this.pb1);
            this.panelBananas.Controls.Add(this.pb0);
            this.panelBananas.Location = new System.Drawing.Point(33, 441);
            this.panelBananas.Name = "panelBananas";
            this.panelBananas.Size = new System.Drawing.Size(766, 183);
            this.panelBananas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buffer:";
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(614, 16);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(144, 152);
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(462, 16);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(144, 152);
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(312, 16);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(144, 152);
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(162, 16);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(144, 152);
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pb0
            // 
            this.pb0.Image = ((System.Drawing.Image)(resources.GetObject("pb0.Image")));
            this.pb0.Location = new System.Drawing.Point(12, 16);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(144, 152);
            this.pb0.TabIndex = 0;
            this.pb0.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Location = new System.Drawing.Point(255, 13);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(75, 23);
            this.btnSobre.TabIndex = 5;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // pbConsumidor
            // 
            this.pbConsumidor.Image = global::produtor_consumidor.Properties.Resources.consumidor;
            this.pbConsumidor.Location = new System.Drawing.Point(604, 41);
            this.pbConsumidor.Name = "pbConsumidor";
            this.pbConsumidor.Size = new System.Drawing.Size(187, 140);
            this.pbConsumidor.TabIndex = 1;
            this.pbConsumidor.TabStop = false;
            // 
            // pbProdutor
            // 
            this.pbProdutor.Image = global::produtor_consumidor.Properties.Resources.produtor;
            this.pbProdutor.Location = new System.Drawing.Point(45, 42);
            this.pbProdutor.Name = "pbProdutor";
            this.pbProdutor.Size = new System.Drawing.Size(187, 140);
            this.pbProdutor.TabIndex = 0;
            this.pbProdutor.TabStop = false;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(93, 13);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 6;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnSalvarLog
            // 
            this.btnSalvarLog.Location = new System.Drawing.Point(174, 13);
            this.btnSalvarLog.Name = "btnSalvarLog";
            this.btnSalvarLog.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarLog.TabIndex = 7;
            this.btnSalvarLog.Text = "Salvar log";
            this.btnSalvarLog.UseVisualStyleBackColor = true;
            this.btnSalvarLog.Click += new System.EventHandler(this.btnSalvarLog_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 636);
            this.Controls.Add(this.btnSalvarLog);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.panelBananas);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pbConsumidor);
            this.Controls.Add(this.pbProdutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema do Produtor e Consumidor";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.panelBananas.ResumeLayout(false);
            this.panelBananas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConsumidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdutor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProdutor;
        private System.Windows.Forms.PictureBox pbConsumidor;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pbBox;
        private System.Windows.Forms.Panel panelBananas;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.TextBox txtMensagens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnSalvarLog;
    }
}

