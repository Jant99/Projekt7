Book Rental Service Application
This project is a simple book rental service application developed in C# using .NET technology. The application provides functionalities for managing a database of readers and books, facilitating lending and returning operations. The goal is to create an intuitive and user-friendly windowing application with basic CRUD (Create, Read, Update, Delete) operations.

Features
Two Tables: The application consists of two tables representing readers and the stock of books.
Addition Operations: There are four buttons responsible for adding new readers, adding new books, lending books, and returning books.
Flexible Adding: Users can add new readers and books through a separate window, directly in the gridview, or any other convenient method.
Loan and Return Operations: Users can carry out loan and return operations seamlessly within the application.
Persistence: The application ensures data persistence by reading and writing data when the application starts and closes, respectively. This allows users to pick up where they left off and ensures data integrity.
Requirements
.NET Framework (version 4.7.2 or higher)
Visual Studio (optional, for development)
Installation
Clone the repository to your local machine.
Open the solution file (WpfApp7.sln) in Visual Studio.
Build the solution to restore NuGet packages and compile the application.
Run the application.
Usage
Upon launching the application, you will be presented with the main window displaying tables for readers and books.
To add a new reader, click on the "Dodaj czytelnika" button and fill in the necessary information in the provided form.
To add a new book, click on the "Dodaj książkę" button and provide the details of the book.
To lend a book to a reader, click on the "Wypożycz" button, and then select a book from the stock table and insert a reader's ID, then click on the "Wypożycz" button.
To return a book, click the "Wypożycz" button, and then insert a reader's ID and select the book from the stock table and click on the "Oddaj" button.
Any changes made will be saved automatically upon closing the application.
Contributing
Contributions are welcome! If you'd like to contribute to this project, please fork the repository and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgements
This project was inspired by the need for a simple book rental service application.
