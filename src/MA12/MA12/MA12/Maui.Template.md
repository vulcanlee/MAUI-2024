# 擴充與客製化 Prism-MAUI 的專案樣板

會用到的指令為

* 切換到工作目錄

* 使用此專案範本，產生一個新的專案

# Create a new empty project of Prism.Maui

dotnet new Vulcan-Maui -o d:\Temp\MyApp

# Create a new full project of Prism.Maui (has flyout menu)

dotnet new Full-Maui -o d:\Temp\MyApp

* 建立 View / ViewModel 項目

# Create a new View and ViewModel (don't append Page to view-name parameter)

dotnet new MVVMItem  --namespace MyApp --view-name MyFirst

* 移除此專案範本

dotnet new uninstall Vulcan.Maui.Template


# 字體檔案查詢網頁

https://pictogrammers.com/library/mdi/
