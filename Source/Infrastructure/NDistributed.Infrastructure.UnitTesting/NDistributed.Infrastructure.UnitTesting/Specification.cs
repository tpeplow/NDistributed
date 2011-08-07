using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NDistributed.Infrastructure.UnitTesting
{
    [TestClass]
    public abstract class ContextSpecification<TSystemUnderTest>
    {
        protected TSystemUnderTest Sut { get; private set; }

        [TestInitialize]
        public void SetupContext()
        {
            Initialise();
            Sut = CreateSystemUnderTest();
            GivenThat();
            BecauseOf();
        }

        protected abstract TSystemUnderTest CreateSystemUnderTest();

        [TestCleanup]
        public void TearDownContext()
        {
            Cleanup();
        }

        protected virtual void Initialise() { }

        protected virtual void GivenThat() { }

        protected virtual void BecauseOf() { }

        protected virtual void Cleanup() { }
    }
}