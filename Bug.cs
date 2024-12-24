public class ExampleClass
{
    private int _myField;

    public int MyProperty
    {
        get { return _myField; }
        set { _myField = value; }
    }

    public void MyMethod()
    {
        // ... some code ...
        int x = MyProperty; //accessing property
        MyProperty = x + 5; //modifying property
        // ... more code ...
    }
}