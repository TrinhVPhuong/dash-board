# Tóm Tắt Mã Nguồn

## Các Thành Phần Chính và Tương Tác
- **Auth Service**: Xử lý xác thực người dùng bằng Auth0 và JWT.
- **Weather Service**: Lấy dữ liệu thời tiết từ API OpenWeatherMap.
- **Calendar Service**: Quản lý sự kiện lịch âm bằng cơ sở dữ liệu MySQL.
- **Nginx**: Hoạt động như một reverse proxy để định tuyến yêu cầu đến các dịch vụ tương ứng.

## Luồng Dữ Liệu
1. **Xác Thực**:
   - Yêu cầu của người dùng được xác thực qua Auth0.
   - JWT được sử dụng để bảo mật các API.
2. **Dữ Liệu Thời Tiết**:
   - Weather Service lấy dữ liệu từ API OpenWeatherMap và trả về cho frontend.
3. **Lịch Âm**:
   - Calendar Service tương tác với MySQL để quản lý và truy xuất sự kiện lịch âm.

## Phụ Thuộc Bên Ngoài
- **Auth0**: Dùng cho xác thực tập trung.
- **OpenWeatherMap API**: Dùng để lấy dữ liệu thời tiết.
- **MySQL**: Dùng để lưu trữ sự kiện lịch âm.

## Các Thay Đổi Gần Đây
- Tạo Dockerfile cho tất cả các dịch vụ và Nginx.
- Cấu hình Docker Compose để điều phối các dịch vụ.
- Triển khai CRUD trong Calendar Service.
- Tích hợp Weather Service với API OpenWeatherMap.

## Tích Hợp Phản Hồi Người Dùng
- Thêm hướng dẫn chi tiết để cài đặt .NET SDK nhằm hỗ trợ kiểm tra cục bộ.
- Ghi lại nhiệm vụ hiện tại và các bước tiếp theo để đảm bảo rõ ràng.
