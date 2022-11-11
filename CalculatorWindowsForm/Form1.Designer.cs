
namespace CalculatorWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button0num = new System.Windows.Forms.Button();
            this.buttonConverterFunc = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.button3num = new System.Windows.Forms.Button();
            this.button1num = new System.Windows.Forms.Button();
            this.button2num = new System.Windows.Forms.Button();
            this.button6num = new System.Windows.Forms.Button();
            this.button4num = new System.Windows.Forms.Button();
            this.button5num = new System.Windows.Forms.Button();
            this.button7name = new System.Windows.Forms.Button();
            this.button8num = new System.Windows.Forms.Button();
            this.buttonPercentFunc = new System.Windows.Forms.Button();
            this.buttonLastDeleteFunc = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button9num = new System.Windows.Forms.Button();
            this.buttonAllDeleteFunc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.TextBox();
            this.buttonDenominatorFunc = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonSumFunc = new System.Windows.Forms.Button();
            this.buttonSubFunc = new System.Windows.Forms.Button();
            this.buttonMultiFunc = new System.Windows.Forms.Button();
            this.buttonDivFunc = new System.Windows.Forms.Button();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // button0num
            // 
            this.button0num.Location = new System.Drawing.Point(92, 540);
            this.button0num.Name = "button0num";
            this.button0num.Size = new System.Drawing.Size(63, 48);
            this.button0num.TabIndex = 0;
            this.button0num.Text = "0";
            this.button0num.UseVisualStyleBackColor = true;
            this.button0num.Click += new System.EventHandler(this.button_click);
            // 
            // buttonConverterFunc
            // 
            this.buttonConverterFunc.Location = new System.Drawing.Point(22, 540);
            this.buttonConverterFunc.Name = "buttonConverterFunc";
            this.buttonConverterFunc.Size = new System.Drawing.Size(64, 48);
            this.buttonConverterFunc.TabIndex = 1;
            this.buttonConverterFunc.Text = "+/-";
            this.buttonConverterFunc.UseVisualStyleBackColor = true;
            // 
            // buttonComma
            // 
            this.buttonComma.Location = new System.Drawing.Point(161, 543);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(65, 45);
            this.buttonComma.TabIndex = 2;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.button_click);
            // 
            // button3num
            // 
            this.button3num.Location = new System.Drawing.Point(161, 489);
            this.button3num.Name = "button3num";
            this.button3num.Size = new System.Drawing.Size(65, 45);
            this.button3num.TabIndex = 5;
            this.button3num.Text = "3";
            this.button3num.UseVisualStyleBackColor = true;
            this.button3num.Click += new System.EventHandler(this.button_click);
            // 
            // button1num
            // 
            this.button1num.Location = new System.Drawing.Point(22, 486);
            this.button1num.Name = "button1num";
            this.button1num.Size = new System.Drawing.Size(64, 48);
            this.button1num.TabIndex = 4;
            this.button1num.Text = "1";
            this.button1num.UseVisualStyleBackColor = true;
            this.button1num.Click += new System.EventHandler(this.button_click);
            // 
            // button2num
            // 
            this.button2num.Location = new System.Drawing.Point(92, 486);
            this.button2num.Name = "button2num";
            this.button2num.Size = new System.Drawing.Size(63, 48);
            this.button2num.TabIndex = 3;
            this.button2num.Text = "2";
            this.button2num.UseVisualStyleBackColor = true;
            this.button2num.Click += new System.EventHandler(this.button_click);
            // 
            // button6num
            // 
            this.button6num.Location = new System.Drawing.Point(161, 435);
            this.button6num.Name = "button6num";
            this.button6num.Size = new System.Drawing.Size(65, 45);
            this.button6num.TabIndex = 8;
            this.button6num.Text = "6";
            this.button6num.UseVisualStyleBackColor = true;
            this.button6num.Click += new System.EventHandler(this.button_click);
            // 
            // button4num
            // 
            this.button4num.Location = new System.Drawing.Point(22, 432);
            this.button4num.Name = "button4num";
            this.button4num.Size = new System.Drawing.Size(64, 48);
            this.button4num.TabIndex = 7;
            this.button4num.Text = "4";
            this.button4num.UseVisualStyleBackColor = true;
            this.button4num.Click += new System.EventHandler(this.button_click);
            // 
            // button5num
            // 
            this.button5num.Location = new System.Drawing.Point(92, 432);
            this.button5num.Name = "button5num";
            this.button5num.Size = new System.Drawing.Size(63, 48);
            this.button5num.TabIndex = 6;
            this.button5num.Text = "5";
            this.button5num.UseVisualStyleBackColor = true;
            this.button5num.Click += new System.EventHandler(this.button_click);
            // 
            // button7name
            // 
            this.button7name.Location = new System.Drawing.Point(22, 378);
            this.button7name.Name = "button7name";
            this.button7name.Size = new System.Drawing.Size(64, 48);
            this.button7name.TabIndex = 10;
            this.button7name.Text = "7";
            this.button7name.UseVisualStyleBackColor = true;
            this.button7name.Click += new System.EventHandler(this.button_click);
            // 
            // button8num
            // 
            this.button8num.Location = new System.Drawing.Point(92, 378);
            this.button8num.Name = "button8num";
            this.button8num.Size = new System.Drawing.Size(63, 48);
            this.button8num.TabIndex = 9;
            this.button8num.Text = "8";
            this.button8num.UseVisualStyleBackColor = true;
            this.button8num.Click += new System.EventHandler(this.button_click);
            // 
            // buttonPercentFunc
            // 
            this.buttonPercentFunc.Location = new System.Drawing.Point(22, 256);
            this.buttonPercentFunc.Name = "buttonPercentFunc";
            this.buttonPercentFunc.Size = new System.Drawing.Size(64, 48);
            this.buttonPercentFunc.TabIndex = 13;
            this.buttonPercentFunc.Text = "%";
            this.buttonPercentFunc.UseVisualStyleBackColor = true;
            this.buttonPercentFunc.Click += new System.EventHandler(this.percent_click);
            // 
            // buttonLastDeleteFunc
            // 
            this.buttonLastDeleteFunc.Location = new System.Drawing.Point(92, 256);
            this.buttonLastDeleteFunc.Name = "buttonLastDeleteFunc";
            this.buttonLastDeleteFunc.Size = new System.Drawing.Size(63, 48);
            this.buttonLastDeleteFunc.TabIndex = 12;
            this.buttonLastDeleteFunc.Text = "CE";
            this.buttonLastDeleteFunc.UseVisualStyleBackColor = true;
            this.buttonLastDeleteFunc.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(255, 526);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(88, 62);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button9num
            // 
            this.button9num.Location = new System.Drawing.Point(161, 381);
            this.button9num.Name = "button9num";
            this.button9num.Size = new System.Drawing.Size(63, 48);
            this.button9num.TabIndex = 21;
            this.button9num.Text = "9";
            this.button9num.UseVisualStyleBackColor = true;
            this.button9num.Click += new System.EventHandler(this.button_click);
            // 
            // buttonAllDeleteFunc
            // 
            this.buttonAllDeleteFunc.Location = new System.Drawing.Point(160, 256);
            this.buttonAllDeleteFunc.Name = "buttonAllDeleteFunc";
            this.buttonAllDeleteFunc.Size = new System.Drawing.Size(63, 48);
            this.buttonAllDeleteFunc.TabIndex = 22;
            this.buttonAllDeleteFunc.Text = "C";
            this.buttonAllDeleteFunc.UseVisualStyleBackColor = true;
            this.buttonAllDeleteFunc.Click += new System.EventHandler(this.buttonAllDeleteFunc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(22, 197);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(321, 53);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.Menu;
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelCurrentOperation.Location = new System.Drawing.Point(22, 155);
            this.labelCurrentOperation.Multiline = true;
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(321, 36);
            this.labelCurrentOperation.TabIndex = 24;
            // 
            // buttonDenominatorFunc
            // 
            this.buttonDenominatorFunc.Location = new System.Drawing.Point(22, 310);
            this.buttonDenominatorFunc.Name = "buttonDenominatorFunc";
            this.buttonDenominatorFunc.Size = new System.Drawing.Size(64, 48);
            this.buttonDenominatorFunc.TabIndex = 26;
            this.buttonDenominatorFunc.Text = "1/X";
            this.buttonDenominatorFunc.UseVisualStyleBackColor = true;
            this.buttonDenominatorFunc.Click += new System.EventHandler(this.denominator_click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(91, 310);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(64, 48);
            this.buttonSquare.TabIndex = 27;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.square_click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Location = new System.Drawing.Point(159, 310);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(64, 48);
            this.buttonSquareRoot.TabIndex = 28;
            this.buttonSquareRoot.Text = "x^1/2";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.squareRoot_click);
            // 
            // buttonSumFunc
            // 
            this.buttonSumFunc.Location = new System.Drawing.Point(255, 458);
            this.buttonSumFunc.Name = "buttonSumFunc";
            this.buttonSumFunc.Size = new System.Drawing.Size(88, 62);
            this.buttonSumFunc.TabIndex = 29;
            this.buttonSumFunc.Text = "+";
            this.buttonSumFunc.UseVisualStyleBackColor = true;
            this.buttonSumFunc.Click += new System.EventHandler(this.operation_click);
            // 
            // buttonSubFunc
            // 
            this.buttonSubFunc.Location = new System.Drawing.Point(255, 390);
            this.buttonSubFunc.Name = "buttonSubFunc";
            this.buttonSubFunc.Size = new System.Drawing.Size(88, 62);
            this.buttonSubFunc.TabIndex = 30;
            this.buttonSubFunc.Text = "-";
            this.buttonSubFunc.UseVisualStyleBackColor = true;
            this.buttonSubFunc.Click += new System.EventHandler(this.operation_click);
            // 
            // buttonMultiFunc
            // 
            this.buttonMultiFunc.Location = new System.Drawing.Point(255, 322);
            this.buttonMultiFunc.Name = "buttonMultiFunc";
            this.buttonMultiFunc.Size = new System.Drawing.Size(88, 62);
            this.buttonMultiFunc.TabIndex = 31;
            this.buttonMultiFunc.Text = "*";
            this.buttonMultiFunc.UseVisualStyleBackColor = true;
            this.buttonMultiFunc.Click += new System.EventHandler(this.operation_click);
            // 
            // buttonDivFunc
            // 
            this.buttonDivFunc.Location = new System.Drawing.Point(255, 256);
            this.buttonDivFunc.Name = "buttonDivFunc";
            this.buttonDivFunc.Size = new System.Drawing.Size(88, 62);
            this.buttonDivFunc.TabIndex = 32;
            this.buttonDivFunc.Text = "/";
            this.buttonDivFunc.UseVisualStyleBackColor = true;
            this.buttonDivFunc.Click += new System.EventHandler(this.operation_click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(249, 99);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(94, 37);
            this.materialSwitch1.TabIndex = 33;
            this.materialSwitch1.Text = "Light";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(176, 109);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Theme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 606);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.buttonDivFunc);
            this.Controls.Add(this.buttonMultiFunc);
            this.Controls.Add(this.buttonSubFunc);
            this.Controls.Add(this.buttonSumFunc);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonDenominatorFunc);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAllDeleteFunc);
            this.Controls.Add(this.button9num);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPercentFunc);
            this.Controls.Add(this.buttonLastDeleteFunc);
            this.Controls.Add(this.button7name);
            this.Controls.Add(this.button8num);
            this.Controls.Add(this.button6num);
            this.Controls.Add(this.button4num);
            this.Controls.Add(this.button5num);
            this.Controls.Add(this.button3num);
            this.Controls.Add(this.button1num);
            this.Controls.Add(this.button2num);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonConverterFunc);
            this.Controls.Add(this.button0num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0num;
        private System.Windows.Forms.Button buttonConverterFunc;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button button3num;
        private System.Windows.Forms.Button button1num;
        private System.Windows.Forms.Button button2num;
        private System.Windows.Forms.Button button6num;
        private System.Windows.Forms.Button button4num;
        private System.Windows.Forms.Button button5num;
        private System.Windows.Forms.Button button7name;
        private System.Windows.Forms.Button button8num;
        private System.Windows.Forms.Button buttonPercentFunc;
        private System.Windows.Forms.Button buttonLastDeleteFunc;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button9num;
        private System.Windows.Forms.Button buttonAllDeleteFunc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox labelCurrentOperation;
        private System.Windows.Forms.Button buttonDenominatorFunc;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button buttonSumFunc;
        private System.Windows.Forms.Button buttonSubFunc;
        private System.Windows.Forms.Button buttonMultiFunc;
        private System.Windows.Forms.Button buttonDivFunc;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

