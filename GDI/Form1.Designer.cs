namespace GDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo_label = new Label();
            usuario_tb = new TextBox();
            contra_tb = new TextBox();
            usuario_label = new Label();
            contra_label = new Label();
            login_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // titulo_label
            // 
            titulo_label.Anchor = AnchorStyles.Top;
            titulo_label.AutoSize = true;
            titulo_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            titulo_label.Location = new Point(140, 9);
            titulo_label.Name = "titulo_label";
            titulo_label.Size = new Size(203, 41);
            titulo_label.TabIndex = 0;
            titulo_label.Text = "Bienvenid@!!!";
            titulo_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuario_tb
            // 
            usuario_tb.Location = new Point(188, 107);
            usuario_tb.Name = "usuario_tb";
            usuario_tb.Size = new Size(125, 27);
            usuario_tb.TabIndex = 1;
            // 
            // contra_tb
            // 
            contra_tb.Location = new Point(188, 162);
            contra_tb.Name = "contra_tb";
            contra_tb.Size = new Size(125, 27);
            contra_tb.TabIndex = 2;
            // 
            // usuario_label
            // 
            usuario_label.AutoSize = true;
            usuario_label.Location = new Point(120, 110);
            usuario_label.Name = "usuario_label";
            usuario_label.Size = new Size(62, 20);
            usuario_label.TabIndex = 3;
            usuario_label.Text = "Usuario:";
            usuario_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contra_label
            // 
            contra_label.AutoSize = true;
            contra_label.Location = new Point(96, 165);
            contra_label.Name = "contra_label";
            contra_label.Size = new Size(86, 20);
            contra_label.TabIndex = 4;
            contra_label.Text = "Contraseña:";
            contra_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(310, 240);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 29);
            login_btn.TabIndex = 5;
            login_btn.Text = "Ingresar";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(96, 240);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(94, 29);
            exit_btn.TabIndex = 6;
            exit_btn.Text = "Salir";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 303);
            Controls.Add(exit_btn);
            Controls.Add(login_btn);
            Controls.Add(contra_label);
            Controls.Add(usuario_label);
            Controls.Add(contra_tb);
            Controls.Add(usuario_tb);
            Controls.Add(titulo_label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo_label;
        private TextBox usuario_tb;
        private TextBox contra_tb;
        private Label usuario_label;
        private Label contra_label;
        private Button login_btn;
        private Button exit_btn;
    }
}