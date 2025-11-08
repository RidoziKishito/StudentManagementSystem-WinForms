# Student Management System (WinForms)

A Windows Forms (C#) Student Management System backed by SQL Server. This application supports three user roles (Student, Lecturer, Admin) and provides features for course enrollment, grade management, tuition & salary handling, and account administration. The project is implemented using OOP principles and a straightforward WinForms UI for learning and demonstration purposes.
This application was developed as a second-year (Year 2) university project as part of coursework and practical training.

## ✨ Features

- 🔐 Role-based access: Student, Lecturer, Admin.
- 📚 Course management: add/remove courses and allow students to enroll or withdraw from courses.
- 📝 Result management: enter/edit midterm and final scores, view results for a student or all students.
- 💰 Tuition management: display balance, allow students to pay partially or fully; Admins can update tuition amounts.
- 🧾 Salary management: manage lecturer salary based on academic qualification.
- 👤 Account management: Admins can add, remove, and change user passwords.
- 🖨 Reporting & printing: print DataGridView reports using the included DGVPrinter helper.
- 📈 Student dashboard: a sample GPA chart per course for visualization.

---

## 🛠️ Tech Stack

| Technology                    | Purpose                                      |
| :---------------------------- | :------------------------------------------- |
| **C# (.NET Framework 4.7.2)** | WinForms application and business logic      |
| **Windows Forms**             | Desktop user interface                       |
| **SQL Server**                | Database (see `DatabaseCreatingScript.sql`)  |
| **DGVPrinterHelper**          | DataGridView printing (file `DGVPrinter.cs`) |

---

## ⚙️ Installation & Running (Windows)

1. Clone the repository or open the project folder in Visual Studio:

   - Open the solution file `STUDENT_MS.sln` in Visual Studio (targeting .NET Framework 4.7.2).

2. Create the database (SQL Server):

   - Open `DatabaseCreatingScript.sql` in SQL Server Management Studio (SSMS) and run the script to create the `STUDENT_MS` database and required tables.

3. Configure the connection string:

   - Open `STUDENT_MANAGEMENT/Connection.cs`.
   - Update the `connectionString` value to match your SQL Server instance and authentication method. The default in the code is:
     ```csharp
     private static string connectionString = @"Data Source=htruc;Initial Catalog=STUDENT_MS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
     ```
   - If you use SQL Server Authentication, replace with the appropriate username/password entry.

4. Build & Run:

   - Build the solution in Visual Studio (Build → Build Solution).
   - Run the app from Visual Studio (F5) or execute `bin\Debug\STUDENT_MS.exe`.

---

## 📷 Preview

Run `STUDENT_MS.exe` (or launch from Visual Studio) to view the UI. Main screens include:

- Login screen
- Main dashboard (MainForm) with role-based navigation
- UserControls for: Home, Course, Result, Tuition/Salary, Edit Student/Lecturer/Course

<img width="422" height="307" alt="image" src="https://github.com/user-attachments/assets/4a0a2c83-84b1-4c64-bdc7-3cada029bcc7" />

<img width="618" height="385" alt="image" src="https://github.com/user-attachments/assets/9a092840-cd36-46b1-952e-bbe290217112" />

---

## 📌 Project Notes

- This project was created for educational purposes during the students' second year at university to practice OOP, WinForms, and database interaction. It does not implement advanced security measures (e.g., password hashing). Default/simple passwords may be used when creating accounts in the code (for example: `"1"`).
- Important behaviors discovered in the code:
  - Login checks the first character of the username to determine role: 'A' = Admin, 'L' = Lecturer, 'S' = Student.
  - Most database operations (queries/updates) are implemented in the `Modify` class (see `Modify.cs`).
  - Printing is handled via the `DGVPrinter` implementation located in `DGVPrinter.cs` with many print options.
- If you change the database schema, ensure you update the corresponding queries in `Modify.cs`.

---

## ⚠️ Known Caveats & Edge Cases

- Verify and update the connection string before running — the app will throw exceptions if it cannot connect to the database.
- Some user inputs are not strictly validated (e.g., parsing numeric values from text boxes) and may cause exceptions if formatted incorrectly.
- Printing/preview opens the OS print dialog; ensure the host machine has a printer driver if you intend to print physically.

---

## 🙌 Acknowledgements

- Thanks to the open-source and community resources used (notably the DGVPrinter helper).
- Thanks to instructors and classmates for feedback and guidance during development.

---

## 📄 License

This project is open source and available under the **MIT License**.

---

## 🤝 Contact & Support

If you encounter any issues or have questions about this project, feel free to reach out:

- 📧 Email: huytranquoc24@gmail.com
- 🌐 Facebook: https://www.facebook.com/huy.tranquoc.129357/
- 💼 LinkedIn: https://www.linkedin.com/in/tran-quoc-huy-0612-ai/

---

## 👨‍💻 Project Team (placeholder)

💡 Created with ❤️ by:

- **Tran Quoc Huy** - 23110026
- **Le Huu Truc** - 23110068
