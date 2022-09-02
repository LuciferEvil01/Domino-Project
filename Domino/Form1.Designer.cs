namespace Domino
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
            this.Option1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerTeam = new System.Windows.Forms.TextBox();
            this.PlayerIA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.Option4 = new System.Windows.Forms.Button();
            this.Option5 = new System.Windows.Forms.Button();
            this.DNine = new System.Windows.Forms.Button();
            this.DSix = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.NumPlayers = new System.Windows.Forms.TextBox();
            this.Inf1 = new System.Windows.Forms.Button();
            this.Inf2 = new System.Windows.Forms.Button();
            this.Inf3 = new System.Windows.Forms.Button();
            this.Inf4 = new System.Windows.Forms.Button();
            this.Inf5 = new System.Windows.Forms.Button();
            this.Inf6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones delJuego";
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(111, 203);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(63, 23);
            this.Option1.TabIndex = 1;
            this.Option1.Text = "Estandar";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Opciones);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fichas por jugador";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(81, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Less_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(47, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Plus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Posibles Caras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jugador:";
            // 
            // PlayerTeam
            // 
            this.PlayerTeam.Location = new System.Drawing.Point(273, 126);
            this.PlayerTeam.Name = "PlayerTeam";
            this.PlayerTeam.Size = new System.Drawing.Size(25, 20);
            this.PlayerTeam.TabIndex = 10;
            this.PlayerTeam.Text = "0";
            // 
            // PlayerIA
            // 
            this.PlayerIA.Location = new System.Drawing.Point(273, 100);
            this.PlayerIA.Name = "PlayerIA";
            this.PlayerIA.Size = new System.Drawing.Size(25, 20);
            this.PlayerIA.TabIndex = 11;
            this.PlayerIA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "IA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Equipo:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(304, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlusIA_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(304, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlusTeam_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(223, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Incluir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(290, 314);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(92, 33);
            this.Aceptar.TabIndex = 17;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Option2
            // 
            this.Option2.Location = new System.Drawing.Point(111, 232);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(63, 23);
            this.Option2.TabIndex = 18;
            this.Option2.Text = "Estandar";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.Click += new System.EventHandler(this.Opciones);
            // 
            // Option3
            // 
            this.Option3.Location = new System.Drawing.Point(111, 261);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(63, 23);
            this.Option3.TabIndex = 19;
            this.Option3.Text = "Estandar";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.Click += new System.EventHandler(this.Opciones);
            // 
            // Option4
            // 
            this.Option4.Location = new System.Drawing.Point(111, 290);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(63, 23);
            this.Option4.TabIndex = 20;
            this.Option4.Text = "Estandar";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.Click += new System.EventHandler(this.Opciones);
            // 
            // Option5
            // 
            this.Option5.Location = new System.Drawing.Point(111, 319);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(63, 23);
            this.Option5.TabIndex = 21;
            this.Option5.Text = "Individual";
            this.Option5.UseVisualStyleBackColor = true;
            this.Option5.Click += new System.EventHandler(this.Opciones);
            // 
            // DNine
            // 
            this.DNine.Location = new System.Drawing.Point(12, 103);
            this.DNine.Name = "DNine";
            this.DNine.Size = new System.Drawing.Size(40, 23);
            this.DNine.TabIndex = 22;
            this.DNine.Text = "D/9";
            this.DNine.UseVisualStyleBackColor = true;
            this.DNine.Click += new System.EventHandler(this.DNine_Click);
            // 
            // DSix
            // 
            this.DSix.Location = new System.Drawing.Point(58, 103);
            this.DSix.Name = "DSix";
            this.DSix.Size = new System.Drawing.Size(40, 23);
            this.DSix.TabIndex = 23;
            this.DSix.Text = "D/6";
            this.DSix.UseVisualStyleBackColor = true;
            this.DSix.Click += new System.EventHandler(this.DSix_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Validar Jugada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Forma de Turnarse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor de las Fichas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Fin del Juego:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Determinar Ganador:";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(281, 156);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(51, 23);
            this.Eliminar.TabIndex = 29;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Jugadores:";
            // 
            // NumPlayers
            // 
            this.NumPlayers.Location = new System.Drawing.Point(290, 179);
            this.NumPlayers.Name = "NumPlayers";
            this.NumPlayers.Size = new System.Drawing.Size(35, 20);
            this.NumPlayers.TabIndex = 31;
            this.NumPlayers.Text = "0";
            // 
            // Inf1
            // 
            this.Inf1.Location = new System.Drawing.Point(180, 203);
            this.Inf1.Name = "Inf1";
            this.Inf1.Size = new System.Drawing.Size(30, 23);
            this.Inf1.TabIndex = 32;
            this.Inf1.Text = "?";
            this.Inf1.UseVisualStyleBackColor = true;
            this.Inf1.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Inf2
            // 
            this.Inf2.Location = new System.Drawing.Point(180, 232);
            this.Inf2.Name = "Inf2";
            this.Inf2.Size = new System.Drawing.Size(30, 23);
            this.Inf2.TabIndex = 33;
            this.Inf2.Text = "?";
            this.Inf2.UseVisualStyleBackColor = true;
            this.Inf2.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Inf3
            // 
            this.Inf3.Location = new System.Drawing.Point(180, 261);
            this.Inf3.Name = "Inf3";
            this.Inf3.Size = new System.Drawing.Size(30, 23);
            this.Inf3.TabIndex = 34;
            this.Inf3.Text = "?";
            this.Inf3.UseVisualStyleBackColor = true;
            this.Inf3.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Inf4
            // 
            this.Inf4.Location = new System.Drawing.Point(180, 290);
            this.Inf4.Name = "Inf4";
            this.Inf4.Size = new System.Drawing.Size(30, 23);
            this.Inf4.TabIndex = 35;
            this.Inf4.Text = "?";
            this.Inf4.UseVisualStyleBackColor = true;
            this.Inf4.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Inf5
            // 
            this.Inf5.Location = new System.Drawing.Point(180, 319);
            this.Inf5.Name = "Inf5";
            this.Inf5.Size = new System.Drawing.Size(30, 23);
            this.Inf5.TabIndex = 36;
            this.Inf5.Text = "?";
            this.Inf5.UseVisualStyleBackColor = true;
            this.Inf5.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Inf6
            // 
            this.Inf6.Location = new System.Drawing.Point(338, 98);
            this.Inf6.Name = "Inf6";
            this.Inf6.Size = new System.Drawing.Size(29, 23);
            this.Inf6.TabIndex = 37;
            this.Inf6.Text = "?";
            this.Inf6.UseVisualStyleBackColor = true;
            this.Inf6.Click += new System.EventHandler(this.ShowInformation);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 392);
            this.Controls.Add(this.Inf6);
            this.Controls.Add(this.Inf5);
            this.Controls.Add(this.Inf4);
            this.Controls.Add(this.Inf3);
            this.Controls.Add(this.Inf2);
            this.Controls.Add(this.Inf1);
            this.Controls.Add(this.NumPlayers);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DSix);
            this.Controls.Add(this.DNine);
            this.Controls.Add(this.Option5);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerIA);
            this.Controls.Add(this.PlayerTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Domino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlayerTeam;
        private System.Windows.Forms.TextBox PlayerIA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option3;
        private System.Windows.Forms.Button Option4;
        private System.Windows.Forms.Button Option5;
        private System.Windows.Forms.Button DNine;
        private System.Windows.Forms.Button DSix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NumPlayers;
        private System.Windows.Forms.Button Inf1;
        private System.Windows.Forms.Button Inf2;
        private System.Windows.Forms.Button Inf3;
        private System.Windows.Forms.Button Inf4;
        private System.Windows.Forms.Button Inf5;
        private System.Windows.Forms.Button Inf6;
    }
}

