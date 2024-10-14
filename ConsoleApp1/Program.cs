public class Program
{
    public static void Main()
    {
        // Створення об'єкта Книга
        IBook book = new Book("Майстер і Маргарита", "Михайло Булгаков");
        Console.WriteLine($"Книга: {book.GetTitle()}, Автор: {book.GetAuthor()}");

        // Створення об'єкта Журнал
        IMagazine magazine = new Magazine("Науковий вісник", 10);
        Console.WriteLine($"Журнал: {magazine.GetTitle()}, Номер випуску: {magazine.GetIssueNumber()}");
    }
}
