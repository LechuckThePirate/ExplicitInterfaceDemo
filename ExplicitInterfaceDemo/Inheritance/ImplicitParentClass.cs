namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Inheritance
{
    public class ImplicitParentClass : ITest
    {
         private string _test = null;

        public string TestMethod()
        {
            return this._test;
        }

        protected virtual void SetTest(string test)
        {
            _test = test;
        }

        public ImplicitParentClass(string test)
        {
            _test = test;
        }

        public ImplicitParentClass() { }
    }
}
