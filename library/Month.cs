public struct Month{
    private int _month;
    private const int _minValue = 1;
    private const int _maxValue = 12;
    public Month(int value){
        if(value < _minValue || value > _maxValue){
            throw new OutBoundedException("Input should be an integer between 1 and 12.");
        }
        _month = value;
    }
    
    public readonly int MinValue { get{return _minValue;}  }
    public readonly int MaxValue { get{return _maxValue;}  }

    public static implicit operator int(Month month) => month._month;
    public static implicit operator Month(int value) => new Month(value);
    // public static explicit operator Month(int value) => new Month(value);

}