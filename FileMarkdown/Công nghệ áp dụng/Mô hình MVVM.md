# Mô hình MVVM
## MVVM được hiểu như thế nào ?
**View:**

Thành phần giao diện của ứng dụng. Tương tự như ở trong mô hình MVC, View là thành phần duy nhất mà người dùng có thể tương tác được trong chương trình, nó chính là thành phần mô tả dữ liệu.

Một điểm khác biệt so với các mô hình khác là View trong mô hình này tích cực hơn. Nó có khả năng thực hiện các hành vi và phản hồi lại người dùng thông qua tính năng là: binding, command.

**Model:**

Cũng tương tự như trong mô hình MVC. Model là các đối tượng giúp truy xuất và thao tác trên dữ liệu thực sự.

**ViewModel:**

Lớp trung gian giữa View và Model. ViewModel có thể được xem là thành phần thay thế cho Controller trong mô hình MVC. Nó chứa các mã lệnh cần thiết để thực hiện data binding, command.

**Một định nghĩa khác về ViewModel trong mvvm:**

**ViewModel**: Sẽ đảm nhận công việc đồng bộ dữ liệu từ model lên View. Mối quan hệ giữa View và View-Model là View sẽ được ánh xạ tới View-Model nhưng View-Model lại không biết thông tin gì về View. Nó được ẩn dấu qua cách sử dụng Data-binding và cơ chế của mô hình Observer. Một View-Model có thể được ánh xạ từ nhiều View.

**Một điểm cần lưu ý**: Là trong mô hình MVVM, các tầng bên dưới sẽ không biết được các thông tin gì về tầng bên trên nó. ViewModel không hề biết gì về View, một ViewModel có thể được sử dụng cho nhiều View (one-to-many). ViewModel sử dụng Observer design pattern để liên lạc với View (thường được gọi là binding data, có thể là 1 chiều hoặc 2 chiều tùy nhu cầu của ứng dụng).
## Cấu trúc thư mục trong MVVM
![](../images/Mô%20hình%20MVVM.png)

### Views

Trong thư mục Views chứ các file giao diện. Và mỗi file giao diện đều có class code-behind đi kèm. Đặc biệt file code-behind ta sẽ không sử dụng đến, mọi điều cần làm sẽ chuyển xuống class ViewModel. Tất nhiên là bạn có thể code trong file code-behind của XAML nhưng điều đó sẽ phá vỡ quy ước **MVVM.** Bạn có thể khai báo thuộc tính datacontext hoặc vài thiết lập khác nhưng nên hạn chế tối thiểu code ở đây. Views được sử dụng để kết hợp với các mô hình MVVM… Nó dùng để cung cấp một sự chia tách gọn gàng của khái niệm giữa UI và presentation logic và data.

### Models

Trong thư mục Models trong đó tạo các class chứa data và bất kỳ liên kết validation, logic nghiệp vụ để chắc chắc tính toàn vẹn của data, bạn có thể tách ra thư mục Repositories khác. Chúng được dùng như một phần của mô hình MVVM.

### ViewModels

Tương tự ta cũng tạo một thư mục ViewModels. Thông thường một file giao diện thì ta tạo một class ViewModels tương ứng (có đôi lúc ta tạo nhiều class phụ giúp tinh giản file code và gọi chúng trong class ViewModels chính).

ViewModels sẽ sử dụng các model nếu cần định nghĩa dữ liệu. Sự liên kết giữa View-ViewModel giúp chúng gửi và nhận dữ liệu, để hiểu rõ ta cần tìm hiểu các khái niệm về Binding, DataContext, Behaviors SDK. Nhờ đó ta tách code-behind của View và đưa xuống View Model.

Ngoài ra một lớp ViewModels chứa presentation logic và state của ứng dụng. ViewModels cần chứa các chức năng của ứng dụng. ViewModels định nghĩa properties, commands, và events, để chuyển đổi controls trong view cần data-bind.

## Data Binding

Data Binding là kĩ thuật dùng để tạo gắn kết giữa phần giao diện (UI) và dữ liệu thông qua phần business logic. Nhờ Data Binding, UI có thể tự động cập nhật lại để hiển thị các thay đổi trong dữ liệu. Ngoài ra, Data Binding trong WPF còn hỗ trợ các chiều khác nhau, nghĩa là các thay đổi có thể cập nhật từ UI vào dữ liệu. Kĩ thuật binding trong mô hình mvvm thực sự là một bước tiến mới, thỏa mãn những điều mà hầu hết lập trình viên mong đợi.

Nếu như tìm hiểu về tính năng này, bạn sẽ không ngạc nhiên gì khi nhiều người nói rằng data binding là thành phần cốt lỗi tạo nên các cơ chế hoạt động trong WPF. Bạn có thể binding dữ liệu nguồn và đích từ bất kì đối tượng nào: như cửa sổ, các control đơn giản như TextBlock cho đến một usercontrol phức tạp.

Tất cả được thực hiện một cách dễ dàng, nhanh chóng, hiệu quả và có thể không cần dùng đến bất kì dòng code-behind (C#, VB.NET, …) nào.

## Data Template

Data Template là kĩ thuật dùng để tạo ra một khuôn mẫu giao diện. Template chỉ được áp dụng cho các Control. Một template trong WPF xác định cách thức và cấu trúc mà dữ liệu hoặc control sẽ được hiển thị ra màn hình.

Nói riêng về Data Template, chức năng này giúp cho dữ liệu (thuộc dạng non-visual) được gắn vào một cấu trúc bao gồm một hoặc nhiều thành phần có khả năng hiển thị. Và do đó, dữ liệu sẽ được hiển thị lên cửa sổ một cách trực quan theo ý muốn của **lập trình viên**. Cũng như Data Binding, tính năng này không yêu cầu bạn phải biết trong code-behind của ứng dụng.

## Command

Data Binding và Data Template trong wpf giúp cho người dùng thấy được những gì có trong dữ liệu và có thể cập nhật lại dữ liệu đó. Tuy nhiên để nhận được tương tác từ người dùng và xử lý, WPF cung cấp một tính năng gọi là command. Các command có thể được xem như dữ liệu và được cung cấp cho người dùng thông qua chức năng binding.

Một command binding cho phép bạn tùy ý xác định các phương thức xử lý, phím tắt hoặc thao tác chuột để kích hoạt.

---------------------------------------------------
Trang trước: [Thư viện LiveChart](Thư%20viện%20LiveChart.md)
Trang sau:[Thư viện MaterialDesign](Thư%20viện%20MaterialDesign.md)