namespace Utilities
{
    public class PublicClassForTesting
    {
        public int PublicProperty { get; set; }
        internal int InternalProperty { get; set; }
        protected int ProtectedProperty { get; set; }
        protected internal int ProtectedInternalProperty { get; set; }
        private protected int PrivateProtectedProperty { get; set; }

        public void PublicMethod()
        {
            InternalProperty = 1;
            ProtectedProperty = 2;
            ProtectedInternalProperty = 3;
            PrivateProtectedProperty = 4;
            Console.WriteLine("I am a public method in another project");
            PrivateMethod();

            var myFileClass = new MyFileClass();
        }

        private void PrivateMethod()
        {
            var internalData = new InternalClass();
        }

        private class InternalClass
        {
            public int Data { get; set; }
        }
    }

    file class MyFileClass
    {
        public int MyProperty { get; set; }
    }
}