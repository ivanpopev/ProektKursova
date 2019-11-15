namespace ProektKursova
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Scene : Form
    {
        public Scene()
        {
            InitializeComponent();
        }

        private void Scene_Click(object sender, EventArgs e)
        {

        }

        private void Scene_Load(object sender, EventArgs e)
        {
            Scene scene = new Scene();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                var firstSide = double.Parse(textBoxFirstSideOfTriangle.Text);
                var secondSide = double.Parse(textBoxSecondSideOfTriangle.Text);
                var thirdSide = double.Parse(textBoxThirdSideOfTriangle.Text);
                var firstHeight = double.Parse(textBoxFirstHeightOfTriangle.Text);
                var secondHeight = double.Parse(textBoxSecondHeightOfTriangle.Text);
                var thirdHeight = double.Parse(textBoxThirdHeightOfTriangle.Text);
                var triangle = new Triangle(firstSide, secondSide, thirdSide,
                                            firstHeight, secondHeight, thirdHeight);
                var perimeter = triangle.Perimeter;
                var surface = triangle.Surface;

                textBoxTrianglePerimeter.Text = perimeter.ToString();
                textBoxTriangleSurface.Text = surface.ToString();

                textBoxTrianglePerimeter.BackColor = Color.White;
                textBoxTriangleSurface.BackColor = Color.White;
                textBoxErrorMessage.Text = "";
            }
            catch (Exception someError)
            {
                textBoxErrorMessage.Text = someError.Message;
                textBoxTrianglePerimeter.BackColor = Color.Red;
                textBoxTriangleSurface.BackColor = Color.Red;
                textBoxTrianglePerimeter.Text = null;
                textBoxTriangleSurface.Text = null;
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                var sideOfSquare = double.Parse(textBoxSquareSide.Text);
                var square = new Square(sideOfSquare);
                var perimeter = square.Perimeter;
                var surface = square.Surface;
                textBoxSquarePerimeter.Text = perimeter.ToString();
                textBoxSquareSurface.Text = surface.ToString();

                textBoxErrorMessage.Text = "";
                textBoxSquarePerimeter.BackColor = Color.White;
                textBoxSquareSurface.BackColor = Color.White;
            }
            catch (Exception someError)
            {
                MessageBox.Show("The number must be positive");
            }

        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                var firstSide = double.Parse(textBoxFirstSideOfRectangle.Text);
                var secondSide = double.Parse(textBoxSecondSideOfRectangle.Text);
                var rectangle = new Rectangle(firstSide, secondSide);
                var perimeter = rectangle.Perimeter;
                var surface = rectangle.Surface;
                textBoxRectanglePerimeter.Text = perimeter.ToString();
                textBoxRectangleSurface.Text = surface.ToString();

                textBoxRectanglePerimeter.BackColor = Color.White;
                textBoxRectangleSurface.BackColor = Color.White;
                textBoxErrorMessage.Text = "";
            }
            catch (Exception someError)
            {
                textBoxErrorMessage.Text = someError.Message;
                textBoxRectanglePerimeter.BackColor = Color.Red;
                textBoxRectangleSurface.BackColor = Color.Red;
                textBoxRectanglePerimeter.Text = null;
                textBoxRectangleSurface.Text = null;
            }

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            try
            {
                var radius = double.Parse(textBoxRadiusOfCircle.Text);
                var circle = new Circle(radius);
                var perimeter = circle.Perimeter;
                var surface = circle.Surface;

                textBoxCirclePerimeter.Text = perimeter.ToString();
                textBoxCircleSurface.Text = surface.ToString();

                textBoxErrorMessage.Text = "";
                textBoxCirclePerimeter.BackColor = Color.White;
                textBoxCircleSurface.BackColor = Color.White;
            }
            catch (Exception someError)
            {
                textBoxCirclePerimeter.BackColor = Color.Red;
                textBoxCircleSurface.BackColor = Color.Red;
                textBoxCircleSurface.Text = null;
                textBoxCirclePerimeter.Text = null;
                textBoxErrorMessage.Text = someError.Message;
            }
        }
    }
}
