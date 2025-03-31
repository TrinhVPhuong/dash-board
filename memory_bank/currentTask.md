# Nhiệm Vụ Hiện Tại

## Mục Tiêu
- Kiểm tra các dịch vụ cục bộ để đảm bảo chúng hoạt động như mong đợi.
- Xác minh tích hợp của Auth0, Weather Service, và Calendar Service.
- Đảm bảo Nginx định tuyến yêu cầu đúng đến các dịch vụ tương ứng.

## Bối Cảnh
- Dự án bao gồm ba microservices (Auth Service, Weather Service, Calendar Service) và một reverse proxy (Nginx).
- Tất cả các dịch vụ đã được đóng gói container với Dockerfile và điều phối bằng Docker Compose.
- Cần cài đặt .NET SDK để kiểm tra các dịch vụ cục bộ.

## Các Bước Tiếp Theo
1. Cài đặt .NET SDK theo hướng dẫn trong `userInstructions/install-dotnet-sdk.md`.
2. Kiểm tra Auth Service bằng cách chạy cục bộ.
3. Kiểm tra Weather Service bằng cách chạy cục bộ và xác minh tích hợp API OpenWeatherMap.
4. Kiểm tra Calendar Service bằng cách chạy cục bộ và xác minh tích hợp cơ sở dữ liệu MySQL.
5. Kiểm tra định tuyến Nginx bằng cách gửi yêu cầu đến từng dịch vụ thông qua reverse proxy.
6. Ghi lại bất kỳ vấn đề nào gặp phải trong quá trình kiểm tra và giải quyết chúng.
