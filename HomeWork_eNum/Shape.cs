namespace Homework_eNum{
    public class Shape{
        protected int side1;
        protected int side2;

        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Shape():this(0,0){}

        public Shape(int side1, int side2){
            this.side1 = side1;
            this.side2 = side2;
        }

        public virtual void PerimetreOfTheShape(){
            System.Console.WriteLine(
                "the perimetre of the shape is {0}",
                2*side1+2*side2
            );
        }
    }
}