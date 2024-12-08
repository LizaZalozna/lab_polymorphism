namespace lab_polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(280, 90, 65, this);
            circle.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square(150, 190, 60, this);
            square.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rhomb rhomb = new Rhomb(170, 220, 120, 30,this);
            rhomb.MoveRight();
        }
    }
}
