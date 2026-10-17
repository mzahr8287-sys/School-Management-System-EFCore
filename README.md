# School Management System (Data Access Layer) 🚀

This repository contains the **Data Access Layer (DAL)** for a School Management System, developed as part of my training in the **Digital Egypt Pioneers Initiative (DEPI)**. 

The project focuses on building a robust database architecture using **C#**, **.NET Core**, and **Entity Framework Core (EF Core)** with a heavy emphasis on the **Fluent API** configuration for data modeling.

---

## 📌 Project Features & Database Architecture

The system models complex academic relationships with full data integrity:
* **Many-to-Many Relationships:** 
  * `Students` & `Courses` mapped via the composite bridge entity `StudentCourse` (which tracks extra fields like `Grade`).
  * `Instructors` & `Courses` mapped via `CourseInstructor` to assign multiple instructors to various courses.
* **One-to-One Relationship:** 
  * Management mapping where an `Instructor` can manage a `Department` as a `Manager`.
* **One-to-Many Relationships:**
  * `Department` hosting multiple `Students` and `Instructors`.
  * `Topic` grouping multiple `Courses`.
* **Self-Referencing Relationship (Unary):**
  * Student hierarchy where a `Student` can have a supervisor/leader (`Super`) from the same `Student` entity.

---

## 🛠️ Tech Stack & Tools

* **Language:** C# (.NET Core)
* **ORM:** Entity Framework Core (EF Core)
* **Database Provider:** Microsoft SQL Server (MSSQL)
* **Approach:** Code-First with Fluent API
* **IDE:** Visual Studio

---

## 💻 Key Configurations (Fluent API Showcase)

Instead of relying solely on Data Annotations, **Fluent API** was fully utilized in `First14DbContext.cs` to handle:
1. **Composite Primary Keys:** For join tables to prevent duplicate entries.
2. **Explicit Foreign Keys & Cardinality:** Defining clear `.HasOne().WithMany()` or `.WithOne()` relationships.
3. **Data Types Overrides:** Configuring specific SQL column types like `nvarchar(30)` using `.HasColumnType()`.

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   [git clone https://github.com](https://github.com/mzahr8287-sys/School-Management-System-EFCore.git)
   ```
2. Update the connection string in `First14DbContext.cs` to match your local SQL Server instance:
   ```csharp
   optionsBuilder.UseSqlServer("Server=.;Database=SchoolManagementDB;Trusted_Connection=True;");
   ```
3. Open the Package Manager Console and apply migrations:
   ```bash
   Add-Migration InitialCreate
   Update-Database
   ```

---

## 🎓 About DEPI
The **Digital Egypt Pioneers Initiative (DEPI)** is a national initiative launched by the **Ministry of Communications and Information Technology (MCIT) Egypt** aimed at preparing top-tier digital talent for the global technology market.

---
*Developed with 💻 and C#.*
