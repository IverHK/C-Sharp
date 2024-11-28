namespace O_348B_Shapes;

class Program
{
    private static int _width = 50;
    private static int _height = 20;
    private static string _text = "Hello world";

    static void Main(string[] args)
    {
        var shapes = CreateShapes();
        var n = 20;
        while (n-- > 0)
        {
            Show(shapes);
            foreach (var shape in shapes)
            {
                shape.Move();
            }
            Thread.Sleep(400);
        }
    }
    

    private static Shape[] CreateShapes()
    {
        bool isText = false;
        var random = new Random();
        var shapes = new Shape[5];
        for (var i = 0; i < shapes.Length; i++)
        {
            int randomNumber = (random.Next(0, 3));
            
            
            if (randomNumber == 0)
                shapes[i] = new Rectangle(random, _width, _height);
            if (randomNumber == 1)
            {
                shapes[i] = new Text(random, _text, 10, 10);
                isText = true;
            }
            if (randomNumber == 2)
                shapes[i] = new Triangle(random, _height);
        }
        
        if (!isText) shapes[0] = new Text(random, _text, 10, 10);
        return shapes;
    }

    private static void Show(Shape[] shapes)
    {
        Console.Clear();
        for (var row = 0; row < _height; row++)
        {
            for (var col = 0; col < _width; col++)
            {
                var hasFoundCharacterToPrint = false;
                foreach (var shape in shapes)
                {
                    var character = shape.GetCharacter(row, col);
                    if (character != null)
                    {
                        Console.Write(character);
                        hasFoundCharacterToPrint = true;
                        break;
                    }
                }
                if (!hasFoundCharacterToPrint) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}