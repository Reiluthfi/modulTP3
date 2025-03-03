namespace modulTP3
{
    public partial class Form1 : Form
    {
        private TextBox txtInput;
        private Button btnSubmit;
        private Label lblOutput;

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.txtInput = new TextBox();
            this.btnSubmit = new Button();
            this.lblOutput = new Label();

            // Form Settings
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = "Form Input Nama";

            // TextBox (Input)
            this.txtInput.Location = new System.Drawing.Point(50, 30);
            this.txtInput.Size = new System.Drawing.Size(200, 30);

            // Button (Submit)
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Location = new System.Drawing.Point(270, 30);
            this.btnSubmit.Click += new EventHandler(this.BtnSubmit_Click);

            // Label (Output)
            this.lblOutput.Location = new System.Drawing.Point(50, 80);
            this.lblOutput.Size = new System.Drawing.Size(300, 30);
            this.lblOutput.Text = "Halo ";

            // Add Controls to Form
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutput);
        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string nama = txtInput.Text;
            lblOutput.Text = "Halo " + nama;
        }
    }
}
