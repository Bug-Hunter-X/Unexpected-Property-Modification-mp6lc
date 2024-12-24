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
        int y = x + 5; //modifying property in a temporary variable 
        MyProperty = y; //Assign the modified value to the property 
        // ... more code ...
    }
}