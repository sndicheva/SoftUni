namespace UniversityLibrary.Test;

using NUnit.Framework;
using System;

public class UniversityLibraryTests
{
    private TextBook textBook;
    private string title = "1984";
    private string author = "George Orwell";
    private string category = "Disthopy";

    private UniversityLibrary lib;
    [SetUp]
    public void Setup()
    {
        textBook = new TextBook(title, author, category);
        lib = new UniversityLibrary();
    }

    [Test]
    public void TestTextbookConstructor_SetsValueCorrectly()
    {
        Assert.AreEqual(textBook.Category, category);
        Assert.AreEqual(textBook.Author, author);
        Assert.AreEqual(textBook.Title, title);

        Assert.AreEqual(textBook.ToString(), $"Book: 1984 - 0{Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell");
        Assert.AreEqual(textBook.Holder, null);
    }

    [Test]
    public void TestTextbook_SetsValueCorrectly()
    {
        Assert.AreEqual(textBook.Holder, null);
        textBook.Category = "Cat";
        textBook.Author = "Az";
        textBook.Holder = "Peshkata";
        textBook.Title = "Jully";
        textBook.InventoryNumber = 3;

        Assert.AreEqual(textBook.Category, "Cat");
        Assert.AreEqual(textBook.Author, "Az");
        Assert.AreEqual(textBook.Title, "Jully");

        //Assert.AreEqual(textBook.ToString(), $"Book: 1984 - {Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell");
    }

    [Test]
    public void UniLibraryIsEmptyWhenNew()
    {
        Assert.AreEqual(0, lib.Catalogue.Count);
    }


    [Test]
    public void AddManyTextBooksWorksCorrectly()
    {
        for (int i = 0; i < 10; i++)
        {
            string result = lib.AddTextBookToLibrary(textBook);
        }

        Assert.AreEqual(textBook.InventoryNumber, 10);
    }

    [Test]
    public void AddTextBookWorksCorrectly()
    {
        string result = lib.AddTextBookToLibrary(textBook);
        Assert.AreEqual(textBook.InventoryNumber, 1);
        Assert.AreEqual(textBook.Title, title);
        Assert.AreEqual(lib.Catalogue.Count, 1);
        Assert.AreEqual(lib.Catalogue[0].Title, title);
        Assert.AreEqual(lib.Catalogue[0].Author, author);
        Assert.AreEqual(lib.Catalogue[0].Category, category);
        Assert.AreEqual(result, $"Book: 1984 - 1{Environment.NewLine}Category: Disthopy{Environment.NewLine}Author: George Orwell");
    }

    [Test]
    public void ReturnAndLoanThrowErrorWhenThextbookNotFound()
    {
        Assert.Throws<System.NullReferenceException>(() =>
        {
            lib.LoanTextBook(55, "test");
        });
        Assert.Throws<System.NullReferenceException>(() =>
        {
            lib.ReturnTextBook(55);
        });
    }


    [Test]
    public void LoanTextbookTests()
    {
        lib.AddTextBookToLibrary(textBook);
        Assert.AreEqual(textBook.Holder, null);

        string student = "Pesho";
        string result = lib.LoanTextBook(1, student);

        Assert.AreEqual(textBook.Holder, student);
        Assert.AreEqual(result, $"{textBook.Title} loaned to {student}.");

        result = lib.LoanTextBook(1, student);
        Assert.AreEqual($"{student} still hasn't returned {textBook.Title}!", result);
    }

    [Test]
    public void ReturnTextbookTests()
    {
        lib.AddTextBookToLibrary(textBook);
        string student = "Pesho";

        string result = lib.LoanTextBook(1, student);

        result = lib.ReturnTextBook(1);

        Assert.AreEqual("", textBook.Holder);
        Assert.AreEqual($"{textBook.Title} is returned to the library.", result);
    }
}