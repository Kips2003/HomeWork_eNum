namespace Homework_eNum{
    public class Person{
        public string Name { get; set; }
        public int Age { get; set; }
        public static int count = 0;

        public Person(){
            Name = "NoName";
            Age = 0;
            count++;
        }
        public Person(string name, int age){
            Name = name;
            Age = age;
            count++;
        }
    }
}