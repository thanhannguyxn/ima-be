# ima-be

- Cách setup database (Hiện tại e đang chạy DB trên local = phpMyAdmin qua Xampp), nếu chị chạy = SQL Server Management Studio c giúp e config file appsettings.json để có thể chạy DB trên máy chị ạ
- Tạo bảng User:
  CREATE DATABASE IF NOT EXISTS inventory_manager;

  USE inventory_manager;

  CREATE TABLE Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Username VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL
  );
- Hiện tại các bảng khác e vx đang làm ạ...
