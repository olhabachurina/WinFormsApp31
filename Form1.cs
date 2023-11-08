namespace WinFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Forma1_Paint;
        }

        private void Forma1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Red);
            Rectangle squareRect = new Rectangle(50, 50, 100, 100);
            g.DrawRectangle(blackPen, squareRect);
            Point[] trianglePoints = new Point[]
        {
            new Point(250, 50),
            new Point(200, 150),
            new Point(300, 150)
        };
            g.DrawPolygon(blackPen, trianglePoints);
            Rectangle circleRect = new Rectangle(450, 50, 100, 100);
            g.DrawEllipse(blackPen, circleRect);
            g.Dispose();
        }
    }
}