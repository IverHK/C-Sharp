namespace O_348B_Shapes;

 class Text : Shape
{
 private string _text { get; }
 private readonly int _minimumSize = 3;

 
 public Text(Random random, string text, int maxX, int maxY) : base(random)
 {
  _text = text;
  X = random.Next(0, maxX - _minimumSize);
  Y = random.Next(0, maxY - _minimumSize);
 }
  
 public override string GetCharacter(int row, int col)
 {
  if (row == Y && col >= X && col < X + _text.Length)
  {
   return _text[col - X].ToString();
  }

  return null;
  }
}