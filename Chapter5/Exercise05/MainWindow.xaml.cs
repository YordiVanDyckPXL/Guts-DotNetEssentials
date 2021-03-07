using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Exercise05
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            DrawLogo(paperCanvas, brush, 10, 20);
            DrawLogo(paperCanvas, brush, 100, 100);
            DrawTriangle2(paperCanvas, brush, 100, 10, 40, 40);
            DrawTriangle2(paperCanvas, brush, 10, 100, 20, 60);
            

        }

        private void DrawTriangle2(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPlace,
                                   double yPlace,
                                   double width,
                                   double height)
        {
            //TODO
            Polygon myPolygon = new Polygon();
            Point point1 = new Point(xPlace, yPlace);
            Point point2 = new Point(width, yPlace);
            Point point3 = new Point(width, height);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(point1);
            myPointCollection.Add(point2);
            myPointCollection.Add(point3);
            myPolygon.Points = myPointCollection;
            myPolygon.Stroke = brushToUse;
            drawingArea.Children.Add(myPolygon);
        }



        private void DrawLogo(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double xPos,
                              double yPos)
        {
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 20);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 40);
            DrawRectangle(drawingArea, brushToUse, xPos, yPos, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double size)
        {
            Rectangle rectangle = new Rectangle
            {
                Width = size,
                Height = size,
                Margin = new Thickness(xPos, yPos, 0, 0),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(rectangle);
        }


    }

}
