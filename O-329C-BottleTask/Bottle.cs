namespace O_329C_BottleTask;

public class Bottle
{
    internal int Capacity { get; private set; } = 5;
    internal int _content;
    
    internal Bottle(int content)
    {
        _content = content;
    }

    
    internal void FillBottle()
    {
        _content = Capacity;
    }
        

        
    internal void EmptyBottle()
    {
        _content = 0;
    }
    
        
    internal void FillBottleWithOtherBottle(Bottle otherBottle)
    {
        if (otherBottle._content + _content > 5)
        {
            _content = (_content + otherBottle._content) % 5;
            otherBottle._content = 5;
        }
        else
        {
            otherBottle._content += _content;
            _content = 0;
        }
    }

    internal void EmptyBottleInOtherBottle(Bottle otherBottle)
    {
        otherBottle._content  = Math.Min(_content + otherBottle._content, Capacity);
        _content = 0;
    }


}