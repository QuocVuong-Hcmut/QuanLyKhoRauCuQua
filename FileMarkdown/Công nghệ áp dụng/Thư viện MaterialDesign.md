# Thư viện MaterialDesign
## Đặc điểm

-   Các kiểu và các biến thể cho phần lớn các điều khiển WPF tiêu chuẩn
-   Nhiều điều khiển bổ sung khác để hỗ trợ tính thẩm mỹ và quy trình của Material Design
-   Dễ dàng cấu hình Material Design Bảng màu ở cả thiết kế và thời gian chạy
-   Hoạt động độc lập và cũng tương thích với các khung WPF phổ biến khác, MahApps và Dragablz
-   Khung MVVM bất khả tri
## Giao diện MaterialDesign
![](../images/Giao%20diên%20MaterialDesign.png)
## Cách sử dụng
Bắt đầu một dự án mới và cài đặt từ NuGet. Từ Bảng điều khiển Trình quản lý Gói trong loại Visual Studio

```Csharp
PM> Install-Package MaterialDesignThemes
```
Mở project của bạn vào app.xalm
```Csharp
  <ResourceDictionary >
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml" />

                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml" />
                <ResourceDictionary Source="./Resourcexaml/ResourceMainViewModel.xaml"/>
           
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>


    </Application.Resources>

```
Sau đó mở file xaml bạn muốn sử dụng lên và chèn
```csharp

<Window x:Class="Navigation_Drawer_App.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Navigation_Drawer_App"
        xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
        xmlns:i="http://schemas.microsoft.com/expression/2010/interactivity"
        xmlns:chart="clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf"
        xmlns:sta="clr-namespace:Navigation_Drawer_App.UserControls"
        mc:Ignorable="d"
        Title="MainWindow" 
        x:Name="Mainwindow"
        Height="600" 
        Width="1000"
        DataContext="{StaticResource MV}"
         ResizeMode="NoResize"
        WindowStyle="None"
        >
		<Window>
```
## Làm gì tiếp theo?

Có một số điều bạn sẽ muốn nghĩ đến; bảng màu, cấu trúc giao diện người dùng và các tính năng bổ sung nào mà Material Design trong Bộ công cụ XAML có thể mang lại cho ứng dụng của bạn?

Có rất nhiều thứ để khám phá để bạn thỏa sức sáng tạo trong thiết bị. Chúng tôi thực sự khuyên bạn nên tải xuống bản demo và khám phá tất cả những thứ được cung cấp; kiểu mới, điều khiển, chuyển tiếp, hộp thoại và hơn thế nữa. Bạn cũng nên xem một số bài báo trên [Wiki](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit/wiki).

Cuối cùng, bạn có thể tham gia Gitter chantroom; ghé qua, chào hỏi và yêu cầu giúp đỡ .... mọi thứ đều được chào đón!

-   Để tải xuống nguồn và bản trình diễn bao gồm, hãy truy cập [GitHub](https://github.com/ButchersBoy/MaterialDesignInXamlToolkit)
-   Để trò chuyện, hãy ghé thăm [Gitter](https://gitter.im/ButchersBoy/MaterialDesignInXamlToolkit)

----------------------------------------------------
Trang trước: [Mô hình MVVM](Mô%20hình%20MVVM.md)
Trang sau: [Thư viện LiveChart](Thư%20viện%20LiveChart.md)
