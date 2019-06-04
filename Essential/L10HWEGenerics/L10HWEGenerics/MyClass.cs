namespace L10HWEGenerics
{
    internal class MyClass<T>
    {
        public T FactoryMethod()
        {
            T field = default;
            return field;
        }
    }
}