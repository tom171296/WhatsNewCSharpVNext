var person = new Person();

var testValue = 26;

person.refReadOnly(testValue);


class Person()
{
    public void refReadOnly(int someValue)
    {
        Console.WriteLine(someValue);
    }
}