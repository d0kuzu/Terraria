
namespace Проект
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Item_fall = new System.Windows.Forms.Timer(this.components);
            this.dvizhenie_kirki = new System.Windows.Forms.Timer(this.components);
            this.dvizhenie_mecha = new System.Windows.Forms.Timer(this.components);
            this.slime_life = new System.Windows.Forms.Timer(this.components);
            this.damage = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Item_fall
            // 
            this.Item_fall.Interval = 10;
            this.Item_fall.Tick += new System.EventHandler(this.Item_fall_Tick);
            // 
            // dvizhenie_kirki
            // 
            this.dvizhenie_kirki.Interval = 10;
            this.dvizhenie_kirki.Tick += new System.EventHandler(this.dvizhenie_kirki_Tick);
            // 
            // dvizhenie_mecha
            // 
            this.dvizhenie_mecha.Interval = 10;
            this.dvizhenie_mecha.Tick += new System.EventHandler(this.dvizhenie_mecha_Tick);
            // 
            // slime_life
            // 
            this.slime_life.Enabled = true;
            this.slime_life.Tick += new System.EventHandler(this.slime_life_Tick);
            // 
            // damage
            // 
            this.damage.Enabled = true;
            this.damage.Interval = 1000;
            this.damage.Tick += new System.EventHandler(this.damage_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Item_fall;
        private System.Windows.Forms.Timer dvizhenie_kirki;
        private System.Windows.Forms.Timer dvizhenie_mecha;
        private System.Windows.Forms.Timer slime_life;
        private System.Windows.Forms.Timer damage;
    }
}

