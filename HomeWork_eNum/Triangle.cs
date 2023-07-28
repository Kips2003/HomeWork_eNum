namespace Homework_eNum{
    public class Triangle:Shape{
        protected int side3;

        public int Side3 { get; set; }
        public void TriangleInfo(int height, int Base){
            System.Console.WriteLine(
                "The area of triangel is {0}",
                Base*height
            );
        }

        public void TriangleInfo(int side1, int side2, int side3){
            System.Console.WriteLine(
                "The perimetre of the triangle is {0}",
                side1+side2+side3
            );
        }

        public Triangle(){}

        public Triangle(int side1,int side2,int side3):base(side1,side2){
            this.side3 = side3;
        }

        public override void PerimetreOfTheShape()
        {
            System.Console.WriteLine(
                "the perimetre of the shape is {0}",
                side1+side2+side3
            );
        }
    }
}