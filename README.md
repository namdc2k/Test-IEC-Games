# Task 1: Thực hiện các thay đổi để cải thiện hiệu suất
- Update text time mỗi một giây thay vì gọi liên tục trong Update. Sử dụng StringBuilder hoặc toString thay vì string.Format
- Sử dụng Object Pooling cho các normal item thay vì Instantiate và Destroy
- Xóa bỏ các prefab không dùng đến khỏi folder Resource(hạn chế sử dụng folder resource).
- Các sprite cùng sử dụng tại 1 thời điểm nên cho vào atlas để giảm draw call
- tất cả các task đã được comment //TODO: để dễ tìm kiếm
# Task 5: Các ý kiến tổ chức lại project.
- Hạn chế asset trong Resource sẽ ảnh hưởng đến load game và load asset vào ram. Thay vào đó có thể dùng Addressable để quản lý asset và có thể đẩy lên remote giảm size build.
- Phần Gen new item nên chuyển sang Factory pattern để dễ quản lý, mở rộng.
- Tối ưu canvas UI nên chia ra nhiều canvas nhỏ và sử dụng atlas texture.
- Áp dụng SOLID trong việc tổ chức code và 1 số pattern phổ biến như Singleton, Observer, StateMachine thay vì switch case.
