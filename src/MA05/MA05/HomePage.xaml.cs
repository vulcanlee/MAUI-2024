namespace MA05;

public partial class HomePage : ContentPage
{
    // 這裡是 Code-Behind 的程式碼
    public HomePage()
    {
        InitializeComponent();

        #region 針對 UI 做相關初始設定
        Message.Text = string.Empty;
        Summary.Text = string.Empty;
        Number1.Text = "0";
        Number2.Text = "0";
        #endregion
    }

    void FullNumberCheck()
    {
        Message.Text = string.Empty;
        Summary.Text = string.Empty;

        // 檢查 Number1 是否為合法整數數值，若不成立，將訊息顯示在 Message 內
        if (!CheckNumber1())
        {
            return;
        }

        // 檢查 Number2 是否為合法整數數值，若不成立，將訊息顯示在 Message 內
        if (!CheckNumber2())
        {
            return;
        }

        // 進行 Number1 與 Number2 的加總運算
        int number1 = int.Parse(Number1.Text);
        int number2 = int.Parse(Number2.Text);
        int summary = number1 + number2;

        // 將加總結果顯示在 Summary 內
        Summary.Text = $"{number1} + {number2} 加總結果為 {summary}";
    }

    // 檢查 Number1 是否為合法整數數值，若不成立，將訊息顯示在 Message 內
    private bool CheckNumber1()
    {
        if (int.TryParse(Number1.Text, out int number1) == false)
        {
            Message.IsVisible = true;
            Message.Text = "Number1 必須為整數數值";
            return false;
        }
        else
            return true;
    }
    private bool CheckNumber2()
    {
        if (int.TryParse(Number2.Text, out int number2) == false)
        {
            Message.IsVisible = true;
            Message.Text = "Number2 必須為整數數值";
            return false;
        }
        else
            return true;
    }

    private void Number2_TextChanged(object sender, TextChangedEventArgs e)
    {
        FullNumberCheck();
    }

    private void Number1_TextChanged(object sender, TextChangedEventArgs e)
    {
        FullNumberCheck();
    }
}