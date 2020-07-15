namespace PingPong.Windows
{
    partial class Game
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxPlayerUno = new System.Windows.Forms.PictureBox();
            this.pbxPlayerDos = new System.Windows.Forms.PictureBox();
            this.lblPuntoLocal = new System.Windows.Forms.Label();
            this.lblPuntoVisitante = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbxBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(446, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 500);
            this.panel1.TabIndex = 0;
            // 
            // pbxPlayerUno
            // 
            this.pbxPlayerUno.BackColor = System.Drawing.Color.White;
            this.pbxPlayerUno.Location = new System.Drawing.Point(0, 100);
            this.pbxPlayerUno.Name = "pbxPlayerUno";
            this.pbxPlayerUno.Size = new System.Drawing.Size(10, 100);
            this.pbxPlayerUno.TabIndex = 1;
            this.pbxPlayerUno.TabStop = false;
            // 
            // pbxPlayerDos
            // 
            this.pbxPlayerDos.BackColor = System.Drawing.Color.White;
            this.pbxPlayerDos.Location = new System.Drawing.Point(890, 100);
            this.pbxPlayerDos.Name = "pbxPlayerDos";
            this.pbxPlayerDos.Size = new System.Drawing.Size(10, 100);
            this.pbxPlayerDos.TabIndex = 1;
            this.pbxPlayerDos.TabStop = false;
            // 
            // lblPuntoLocal
            // 
            this.lblPuntoLocal.AutoSize = true;
            this.lblPuntoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoLocal.ForeColor = System.Drawing.Color.White;
            this.lblPuntoLocal.Location = new System.Drawing.Point(354, 9);
            this.lblPuntoLocal.Name = "lblPuntoLocal";
            this.lblPuntoLocal.Size = new System.Drawing.Size(66, 46);
            this.lblPuntoLocal.TabIndex = 2;
            this.lblPuntoLocal.Text = "00";
            // 
            // lblPuntoVisitante
            // 
            this.lblPuntoVisitante.AutoSize = true;
            this.lblPuntoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntoVisitante.ForeColor = System.Drawing.Color.White;
            this.lblPuntoVisitante.Location = new System.Drawing.Point(480, 9);
            this.lblPuntoVisitante.Name = "lblPuntoVisitante";
            this.lblPuntoVisitante.Size = new System.Drawing.Size(66, 46);
            this.lblPuntoVisitante.TabIndex = 2;
            this.lblPuntoVisitante.Text = "00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = global::PingPong.Windows.Properties.Resources.Cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(855, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 33);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pbxBall
            // 
            this.pbxBall.BackColor = System.Drawing.Color.White;
            this.pbxBall.Location = new System.Drawing.Point(208, 149);
            this.pbxBall.Name = "pbxBall";
            this.pbxBall.Size = new System.Drawing.Size(10, 10);
            this.pbxBall.TabIndex = 4;
            this.pbxBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.pbxBall);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblPuntoVisitante);
            this.Controls.Add(this.lblPuntoLocal);
            this.Controls.Add(this.pbxPlayerDos);
            this.Controls.Add(this.pbxPlayerUno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayerDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxPlayerUno;
        private System.Windows.Forms.PictureBox pbxPlayerDos;
        private System.Windows.Forms.Label lblPuntoLocal;
        private System.Windows.Forms.Label lblPuntoVisitante;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbxBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

