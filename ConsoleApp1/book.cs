using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Клас, що реалізує інтерфейс IBook
public class Book : IBook
{
    private string title;
    private string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string GetTitle()
    {
        return title;  // Реалізація методу GetTitle
    }

    public string GetAuthor()
    {
        return author;  // Реалізація методу GetAuthor
    }
}

// Клас, що реалізує інтерфейс IMagazine
public class Magazine : IMagazine
{
    private string title;
    private int issueNumber;

    public Magazine(string title, int issueNumber)
    {
        this.title = title;
        this.issueNumber = issueNumber;
    }

    public string GetTitle()
    {
        return title;  // Реалізація методу GetTitle
    }

    public int GetIssueNumber()
    {
        return issueNumber;  // Реалізація методу GetIssueNumber
    }
}
