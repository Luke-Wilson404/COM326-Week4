using Library;

namespace LibraryTests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        public void MemberConstructor_ShouldInitialiseProperties()
        {
            // Arrange

            int memberId = 1;
            string name = "John Doe";
            string address = "123 Main St";
            int phone = 1234567890;

            // Act 

            Member member = new Member(memberId, name, address, phone);

            // Assert

            Assert.AreEqual(memberId, member.MemberId);
            Assert.AreEqual(name, member.Name);
            Assert.AreEqual(address, member.Address);
            Assert.AreEqual(phone, member.Phone);
        }
        [TestMethod]
        public void NameProperty_ShouldGetAndSet()
        {
            // Arrange

            Member member = new Member(1, "John Doe", "123 Main St", 1234567890);
            string newName = "Jane Doe";

            // Act

            member.Name = newName;

            // Assert

            Assert.AreEqual(newName, member.Name);
        }
    }
}
