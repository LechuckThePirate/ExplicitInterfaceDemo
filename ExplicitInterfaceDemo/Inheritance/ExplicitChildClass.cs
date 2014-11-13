namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Inheritance
{
    public class ExplicitChildClass : ExplicitParentlass
    {
        public ExplicitChildClass(string test) : base(test) {}
        public ExplicitChildClass() : base() {}

        public bool TestIsEmpty()
        {
            return string.IsNullOrEmpty(((ITest)this).TestMethod());
        }

    }
}
