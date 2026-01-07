namespace WinFormsSpil
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            Spiller1 = new PictureBox();
            Computer = new PictureBox();
            ball = new PictureBox();
            SpilTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Spiller1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // Spiller1
            // 
            Spiller1.BackColor = Color.Blue;
            Spiller1.Location = new Point(12, 138);
            Spiller1.Name = "Spiller1";
            Spiller1.Size = new Size(30, 120);
            Spiller1.TabIndex = 0;
            Spiller1.TabStop = false;
            // 
            // Computer
            // 
            Computer.BackColor = Color.BlueViolet;
            Computer.Location = new Point(758, 138);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // ball
            // 
            ball.BackColor = Color.BurlyWood;
            ball.Location = new Point(385, 165);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // SpilTimer
            // 
            SpilTimer.Enabled = true;
            SpilTimer.Interval = 20;
            SpilTimer.Tick += SpilTimerEvent;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(ball);
            Controls.Add(Computer);
            Controls.Add(Spiller1);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "Spiller1 0 -- Computer 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Spiller1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Spiller1;
        private PictureBox Computer;
        private PictureBox ball;
        private System.Windows.Forms.Timer SpilTimer;
    }
}