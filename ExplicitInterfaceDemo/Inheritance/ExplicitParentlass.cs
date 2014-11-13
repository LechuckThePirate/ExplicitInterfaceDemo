namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Inheritance
{
    public class ExplicitParentlass : ITest
    {
        private string _test = null;

        string ITest.TestMethod()
        {
            return this._test;
        }

        protected virtual void SetTest(string test)
        {
            _test = test;
        }

        public ExplicitParentlass(string test)
        {
            _test = test;
        }

        public ExplicitParentlass() {}
    }
}
