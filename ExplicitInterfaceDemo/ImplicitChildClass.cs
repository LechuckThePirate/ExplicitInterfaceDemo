namespace JoanVilarino.Demos.ExplicitInterfaceDemo
{
    public class ImplicitChildClass : ImplicitParentClass
    {
        public ImplicitChildClass(string test) : base(test) {}
        public ImplicitChildClass() : base() { }

        public bool TestIsEmpty()
        {
            return string.IsNullOrEmpty(this.TestMethod());
        }
    }
}
