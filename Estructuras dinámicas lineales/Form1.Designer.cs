namespace Estructuras_dinámicas_lineales
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
            TxtMult = new TextBox();
            BtnGuardarEstado = new Button();
            BtnUndo = new Button();
            BtnRedo = new Button();
            SuspendLayout();
            // 
            // TxtMult
            // 
            TxtMult.Location = new Point(179, 24);
            TxtMult.Multiline = true;
            TxtMult.Name = "TxtMult";
            TxtMult.Size = new Size(560, 163);
            TxtMult.TabIndex = 0;
            // 
            // BtnGuardarEstado
            // 
            BtnGuardarEstado.Location = new Point(156, 285);
            BtnGuardarEstado.Name = "BtnGuardarEstado";
            BtnGuardarEstado.Size = new Size(139, 29);
            BtnGuardarEstado.TabIndex = 1;
            BtnGuardarEstado.Text = "Guardar Estado";
            BtnGuardarEstado.UseVisualStyleBackColor = true;
            // 
            // BtnUndo
            // 
            BtnUndo.Location = new Point(367, 285);
            BtnUndo.Name = "BtnUndo";
            BtnUndo.Size = new Size(94, 29);
            BtnUndo.TabIndex = 2;
            BtnUndo.Text = "Undo";
            BtnUndo.UseVisualStyleBackColor = true;
            // 
            // BtnRedo
            // 
            BtnRedo.Location = new Point(543, 285);
            BtnRedo.Name = "BtnRedo";
            BtnRedo.Size = new Size(94, 29);
            BtnRedo.TabIndex = 3;
            BtnRedo.Text = "Redo";
            BtnRedo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 442);
            Controls.Add(BtnRedo);
            Controls.Add(BtnUndo);
            Controls.Add(BtnGuardarEstado);
            Controls.Add(TxtMult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMult;
        private Button BtnGuardarEstado;
        private Button BtnUndo;
        private Button BtnRedo;
    }
}
