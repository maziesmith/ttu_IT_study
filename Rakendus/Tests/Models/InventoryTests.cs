using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rakendus.Models;

namespace Tests.Models {
    [TestClass]
    public class InventoryTests {
        [TestMethod]
        public void Invetory() {
            Inventory item = new Inventory { CarId = 1, Color = "Blue", Make = "Chevy", PetName = "Kit", IsChanged = false };

            Assert.AreEqual(1, item.CarId);
            Assert.AreEqual("Blue", item.Color);
            Assert.AreEqual("Chevy", item.Make);
            Assert.AreEqual("Kit", item.PetName);
        }
    }
}