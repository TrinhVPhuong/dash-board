# Lộ Trình Dự Án

## Mục Tiêu Cấp Cao
- Xây dựng một dashboard tập trung với các microservices cho tính năng thời tiết và lịch âm.
- Triển khai hệ thống xác thực tập trung sử dụng Auth0 và JWT.
- Triển khai hệ thống bằng Docker và điều phối với Docker Compose.

## Các Tính Năng Chính
- **Dashboard**: Tích hợp các dịch vụ thời tiết và lịch âm.
- **Dịch Vụ Thời Tiết**: Lấy và hiển thị dữ liệu thời tiết từ API OpenWeatherMap.
- **Dịch Vụ Lịch**: Quản lý và hiển thị sự kiện lịch âm.
- **Xác Thực**: Hệ thống xác thực tập trung với Auth0.

## Tiêu Chí Hoàn Thành
- Tất cả các dịch vụ được đóng gói container và điều phối bằng Docker Compose.
- Các dịch vụ được kiểm tra cục bộ và hoạt động như mong đợi.
- Nginx được cấu hình làm reverse proxy để định tuyến yêu cầu.

## Theo Dõi Tiến Độ
- [x] Tạo cấu trúc thư mục cho dự án.
- [x] Scaffold các dịch vụ Auth Service, Weather Service, và Calendar Service.
- [x] Cấu hình Auth0 cho xác thực.
- [x] Triển khai Weather Service với tích hợp API OpenWeatherMap.
- [x] Triển khai Calendar Service với cơ sở dữ liệu MySQL.
- [x] Cấu hình Nginx làm reverse proxy.
- [x] Tạo Dockerfile cho tất cả các dịch vụ.
- [x] Tạo cấu hình Docker Compose.
- [ ] Kiểm tra các dịch vụ cục bộ.
- [ ] Triển khai hệ thống.

## Nhiệm Vụ Đã Hoàn Thành
- Cấu trúc thư mục đã được tạo.
- Các dịch vụ đã được scaffold và cấu hình.
- Dockerfile và cấu hình Docker Compose đã hoàn thành.
