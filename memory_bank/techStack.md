# Công Nghệ Sử Dụng

## Frontend
- **Framework**: Vue.js
- **Tích Hợp Micro-frontend**: Single-SPA
- **Thư Viện Giao Diện**: DaisyUI
- **Tiện Ích**: VueUse

## Backend
- **Ngôn Ngữ**: C# (ASP.NET Core)
- **Xác Thực**: Auth0 với JWT
- **Dịch Vụ Thời Tiết**: Tích hợp với API OpenWeatherMap
- **Dịch Vụ Lịch**: Cơ sở dữ liệu MySQL cho sự kiện lịch âm

## Reverse Proxy
- **Máy Chủ**: Nginx
- **Mục Đích**: Định tuyến yêu cầu đến các microservices tương ứng

## DevOps
- **Đóng Gói Container**: Docker
- **Điều Phối**: Docker Compose

## Các Quyết Định Chính
- **C# cho Backend**: Được chọn vì hiệu suất và khả năng mở rộng.
- **MySQL**: Được chọn vì sự đơn giản và tương thích với Dịch Vụ Lịch.
- **Auth0**: Cung cấp cơ chế xác thực mạnh mẽ và an toàn.
- **Nginx**: Hoạt động như một reverse proxy để tối ưu hóa định tuyến và cân bằng tải.
