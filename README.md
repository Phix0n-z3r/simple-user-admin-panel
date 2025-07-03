# Simple User Admin Panel

<p align="center">
  <img src="assets/demo.png" alt="Demo Screenshot" width="600"/>
</p>

A **simple yet functional** ASP.NET Core user admin panel with SQL Server backend.

🎯 Version: `v1.0.0`  
📦 Release: [View Tag](https://github.com/Phix0n-z3r/simple-user-admin-panel/releases)

---

## ✨ Features

A basic user management system with the following capabilities:

- **➕ Add User**:  
  - Fields: `KarbarId`, `Nam`, `ShomareTelefon`

- **✏️ Edit User**:  
  - Editable by `KarbarId`  
  - Fields: `New:Nam`, `New:ShomareTelefon`

- **🗑️ Delete User**:  
  - By `KarbarId`

- **📋 View Users**:  
  - Display a list of all users from SQL Server DB

> 🚫 The database is **not included** in this repository.  
You will need to create your own database based on the `User(karbaran)` entity model.  
If you need assistance or a sample database, feel free to contact me via GitHub Issues or @PhixOn-z3r in telegram.


---

## ⚙️ Tech Stack

| Layer        | Technology           |
|--------------|----------------------|
| Backend      | .NET Framework 4.8   |
| Database     | SQL Server           |
| UI           | Web Forms            |

---

## 🚀 Getting Started

Clone the repository and run the app locally:

```bash
git clone https://github.com/Phix0n-z3r/simple-user-admin-panel.git
cd simple-user-admin-panel

# Restore NuGet packages
dotnet restore

# OPTIONAL: Apply EF migrations
dotnet ef database update

# Run the app
dotnet run
