namespace StarterCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Shapes.Shape shape = new Shapes.Shape();
            Console.WriteLine(shape);
            shape.Draw();
        }
    }
}