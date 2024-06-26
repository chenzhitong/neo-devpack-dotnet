using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo.SmartContract.Testing;
using Neo.SmartContract.Testing.Exceptions;
using Neo.SmartContract.Testing.TestingStandards;

namespace Neo.SmartContract.Template.UnitTests.templates.neocontractnep17
{
    /// <summary>
    /// You need to build the solution to resolve Nep17Contract class.
    /// </summary>
    [TestClass]
    public class OwnerContractTests : OwnableTests<Nep17ContractTemplate>
    {
        /// <summary>
        /// Initialize Test
        /// </summary>
        public OwnerContractTests() : base(Nep17ContractTemplate.Nef, Nep17ContractTemplate.Manifest) { }

        [TestMethod]
        public override void TestSetGetOwner()
        {
            base.TestSetGetOwner();

            // Test throw if was stored an invalid owner
            // Technically not possible, but raise 100% coverage

            Contract.Storage.Put(new byte[] { 0xff }, 123);
            Assert.ThrowsException<TestException>(() => Contract.Owner);
        }
    }
}
