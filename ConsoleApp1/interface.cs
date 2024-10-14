using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Інтерфейс, що представляє загальний тип видання
public interface IEdition
{
    string GetTitle();  // Метод для отримання назви
}

// Інтерфейс, що успадковує IEdition і додає метод для отримання автора
public interface IBook : IEdition
{
    string GetAuthor();  // Метод для отримання автора
}

// Інтерфейс, що успадковує IEdition і додає метод для отримання періодичності випуску
public interface IMagazine : IEdition
{
    int GetIssueNumber();  // Метод для отримання номеру випуску
}

