namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        [Test]
        [TestCase("I.E.", 17)]
        public void RobotConstructorShouldWorkFine(string name, int maximumBattery)
        {
            Robot robot = new Robot(name, maximumBattery);

            Assert.AreEqual(17, robot.Battery);
            Assert.AreEqual(17, robot.MaximumBattery);
            Assert.AreEqual("I.E.", robot.Name);
        }

        //[Test]
        //[TestCase(null, 17)]
        //[TestCase("I.E.", 0)]
        //[TestCase("I.E.", null)]
        //public void RobotConstructorShouldWorkFineWithNull(string name, int maximumBattery)
        //{
        //    Robot robot = new Robot(name, maximumBattery);

        //    Assert.AreEqual(17, robot.Battery);
        //    Assert.AreEqual(17, robot.MaximumBattery);
        //    Assert.AreEqual("I.E.", robot.Name);
        //}

        [Test]
        [TestCase(1)]
        public void RobotMenagerConstructorShouldWorkFine(int capacity)
        {
            RobotManager robotManager = new RobotManager(capacity);

            Assert.AreEqual(1, robotManager.Capacity);
            
        }

        [Test]
        [TestCase(-1)]
        public void RobotMenagerConstructorShouldThrowExeptionIfCapacityIsNegative(int capacity)
        {
            RobotManager robotManager;

            Assert.Throws<ArgumentException>(() => robotManager = new RobotManager(capacity));

        }

        [Test]
        [TestCase(0)]
        public void RobotMenagerConstructorShouldWorkIfCapacityIsZero(int capacity)
        {
            RobotManager robotManager = new RobotManager(capacity);

            Assert.AreEqual(0, robotManager.Capacity);

        }

        [Test]
        [TestCase(2, "I.T.", 2)]
        public void AddMetodSholuldThrowExeptionIfRobotAllreadyExist(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));

        }

        [Test]
        [TestCase(0, "I.T.", 2)]
        public void AddMetodSholuldThrowExeptionIfNotEnoughCapacity(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));

        }

        [Test]
        [TestCase(1, "I.T.", 2)]
        public void AddMetodSholuldWorkFine(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);

            robotManager.Add(robot);

            Assert.AreEqual(1, robotManager.Capacity);

            Robot test2 = new Robot("test", 10);
            robotManager.Add(test2);
            Assert.AreEqual(2, robotManager.Capacity);

        }

        [Test]
        [TestCase(1, "Test", 2)]
        public void RemoveMetodSholuldThrowExeptionIfSurchedRobotDontExist(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("nqma me"));

        }

        [Test]
        [TestCase(1, "Test", 2)]
        public void RemoveMetodSholuldWorkFine(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);

            robotManager.Remove("Test");
            Assert.AreEqual(0, robotManager.Count);

        }

        [Test]
        [TestCase(1, "Test", 2)]
        public void WorkMetodSholuldThrowExeptionIfRobotDontExist(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("nqma me", "nqma", 1));

        }

        [Test]
        [TestCase(1, "Test", 2)]
        public void WorkMetodSholuldThrowExeptionIfRobotBoatteryIsNotEnough(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Test", "Work", 3));

        }

        [Test]
        [TestCase(1, "Test", 3)]
        public void WorkMetodSholuldWorkFine(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);

            robotManager.Work("Test", "Work", 3);

            Assert.AreEqual(0, robot.Battery);

        }

        [Test]
        [TestCase(1, "Test", 2)]
        public void ChargeMetodSholuldThrowExeptionIfRobotDontExist(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("nqma me"));

        }

        [Test]
        [TestCase(1, "Test", 3)]
        public void ChargeMetodSholuldWorkFine(int capacity, string name, int maximumBattery)
        {
            RobotManager robotManager = new RobotManager(capacity);
            Robot robot = new Robot(name, maximumBattery);
            robotManager.Add(robot);
            robotManager.Work("Test", "work", 2);
            robotManager.Charge("Test");

            Assert.AreEqual(3, robot.Battery);

            

        }


    }
}
