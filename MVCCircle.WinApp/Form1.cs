namespace MVCCircle.WinApp
{
    public partial class Form1 : Form
    {
        private Logic.CircleController _conroller = new();
        public Form1()
        {
            InitializeComponent();

            _conroller.Model.Changed += UpdateUI!;
            txbRadius.Text = _conroller.Radius.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _conroller.Radius = double.Parse(txbRadius.Text);
            }
            catch (Logic.MVCException ex)
            {
                MessageBox.Show(ex.Message, "Radius", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Radius", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void UpdateUI(object sender, EventArgs args)
        {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int r = (int)_conroller.Radius;
            int w = ClientSize.Width;
            int h = ClientSize.Height;

            Pen pen = new Pen(Color.Blue);

            e.Graphics.DrawEllipse(pen, w / 2 - r, h / 2 - r, 2 * r, 2 * r);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}