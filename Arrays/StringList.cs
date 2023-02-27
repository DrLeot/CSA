namespace VL2;

public class StringList
{
    private int _size;
    public int Size
    {
        get => _size;
        set
        {
            Data = new string[value];
            _size = value;
        }

    }
    public string[] Data;

    public string this[int idx]
    {
        get => Data[idx];
        set => Data[idx] = value;
    }
}