using FrontDeskApp;
using NUnit.Framework;
using System;

namespace BookigApp.Tests
{
    public class Tests
    {
        private Hotel hotel;

        [SetUp]
        public void Setup()
        {
            hotel = new Hotel("Radison", 5);
        }

        [Test]
        public void ConstructorSetsFullNameAndCategoryCorrectly()
        {
            string expectedFullName = "Radison";
            int expectedCategory = 3;

            Hotel testHotel = new Hotel(expectedFullName, expectedCategory);

            Assert.That(testHotel.FullName, Is.EqualTo(expectedFullName));
            Assert.That(testHotel.Category, Is.EqualTo(expectedCategory));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("    ")]
        public void FullNameSetterThrowsExceptionWhenValueIsNullOtWhiteSpace(string fullName)
        {
            Assert.Throws<ArgumentNullException>(() => new Hotel(fullName, 5));
        }

        [TestCase(-10)]
        [TestCase(0)]
        [TestCase(6)]
        [TestCase(10)]
        public void CategorySetterThrowsExceptionWhenValueValueOutOfRange(int category)
        {
            Assert.Throws<ArgumentException>(() => new Hotel("Radison", category));
        }

        [Test]
        public void AddRoomAddsRoomCorrectly()
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void BookRoomThrowsExceptionWhenThereIsNoAdults(int adults)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(adults, 2, 3, 200));
        }

        [TestCase(-10)]
        [TestCase(-1)]
        public void BookRoomThrowsExceptionWhenChildrenAreLessThanZero(int children)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(3, children, 3, 200));
        }

        [TestCase(-10)]
        [TestCase(0)]
        public void BookRoomThrowsExceptionWhenThereIsNoResidenseDuration(int residenceDuration)
        {
            Room room = new(3, 100);

            hotel.AddRoom(room);

            Assert.Throws<ArgumentException>(() => hotel.BookRoom(2, 2, residenceDuration, 200));
        }

        [Test]
        public void BookRoomNoTurnoverWhenNotEnoughBeds()
        {
            Room room = new(3, 100);
            hotel.AddRoom(room);
            hotel.BookRoom(4, 1, 2, 100);

            Assert.That(hotel.Turnover, Is.EqualTo(0));
        }

        [Test]
        public void BookRoomNoBookingWhenBudgetTooLow()
        {
            Room room = new(5, 70);
            hotel.AddRoom(room);
            hotel.BookRoom(4, 0, 2, 100);

            double expectedTurnover = 0;

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
            Assert.That(hotel.Bookings.Count, Is.EqualTo(0));
            Assert.That(expectedTurnover, Is.EqualTo(0));
        }

        [Test]
        public void BookRoomBooksRoomCorrectly()
        {
            Room room = new(5, 70);
            hotel.AddRoom(room);
            hotel.BookRoom(4, 1, 2, 150);

            double expectedTurnover = 140;

            Assert.That(hotel.Rooms.Count, Is.EqualTo(1));
            Assert.That(hotel.Bookings.Count, Is.EqualTo(1));
            Assert.That(expectedTurnover, Is.EqualTo(hotel.Turnover));
        }
    }
}