namespace lab2_2
{
    public class MyClass<T> where T : new()
    {
        static T FactoryMethod()
        {
            return new T();
        }
    }
}