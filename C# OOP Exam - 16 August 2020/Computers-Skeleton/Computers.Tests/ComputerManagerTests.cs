using NUnit.Framework;
using System;

namespace Computers.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("VW", "Passat", 17d)]
        public void ComputerConstructorShouldWorkFine(string manufacturer, string model, decimal price)
        {
            Computer computer = new Computer(manufacturer, model, price);
            Assert.AreEqual("VW", computer.Manufacturer);
            Assert.AreEqual("Passat", computer.Model);
            Assert.AreEqual(17d, computer.Price);

        }

        [Test]
        public void ComputerManagerConstructorShouldWorkFine()
        {
            ComputerManager computerManager = new ComputerManager();
            int expectedLenght = 0;
            int actualLenght  = computerManager.Computers.Count;

            Assert.AreEqual(expectedLenght, actualLenght);
        }

        [Test]
        public void AddComputerMethodShouldThrowExeptionIfNullIsPassed()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);

            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));

        }

        [Test]
        public void AddComputerMethodShouldWorkFine()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);

            Assert.AreEqual(1, computerManager.Count);
            Assert.AreEqual(1, computerManager.Computers.Count);
            
        }

        [Test]
        public void AddComputerMethodShouldThrowExeptionIfPassedDuplicatedComputer()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(computer));
        }

        [Test]
        public void RemoveComputerMethodSholudWorkFine()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);
            computerManager.RemoveComputer("Test", "Test");

            Assert.AreEqual(0, computerManager.Computers.Count);
        }

        [Test]
        public void RemoveComputerMethodSholudThrowExeptionIfDataIsInvalid()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);
            computerManager.RemoveComputer("Test", "Test");



            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer(null, "Test"));
            Assert.Throws<ArgumentNullException>(() => computerManager.RemoveComputer("Test", null));
            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("Wow", "Wow"));
            Assert.Throws<ArgumentException>(() => computerManager.RemoveComputer("Test", "Test"));
        }



        [Test]
        public void GetComputerMethodShouldThrowEceptionIfDataIsInvalid()
        {
            ComputerManager computerManager = new ComputerManager();
            
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "Test"));
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer("Test", null));
            Assert.Throws<ArgumentException>(() => computerManager.GetComputer("Test", "Test"));
                        
        }

        [Test]
        public void GetComputerMethodShouldWorkFine()
        {
            ComputerManager computerManager = new ComputerManager();
            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);

            var resultComputer = computerManager.GetComputer("Test", "Test");

            Assert.AreEqual(computer, resultComputer);

        }

        [Test]
        public void GetComputersByManufacturerMethodShouldThrowEceptionIfDataIsInvalid()
        {
            ComputerManager computerManager = new ComputerManager();

            Computer computer = new Computer("Test", "Test", 17);
            computerManager.AddComputer(computer);

            Computer computer2 = new Computer("Test", "Test2", 17);
            computerManager.AddComputer(computer2);

            Computer computer3 = new Computer("Wow", "Wow", 10);
            computerManager.AddComputer(computer3);

            var colectionComputersFromMenadger = computerManager.GetComputersByManufacturer("Test");

            CollectionAssert.Contains(colectionComputersFromMenadger, computer);
            CollectionAssert.Contains(colectionComputersFromMenadger, computer2);
            CollectionAssert.DoesNotContain(colectionComputersFromMenadger, computer3);

            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputersByManufacturer(null));

        }


    }
}