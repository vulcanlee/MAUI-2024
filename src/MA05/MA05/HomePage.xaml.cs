namespace MA05;

public partial class HomePage : ContentPage
{
    // �o�̬O Code-Behind ���{���X
    public HomePage()
    {
        InitializeComponent();

        #region �w�� UI ��������l�]�w
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

        // �ˬd Number1 �O�_���X�k��ƼƭȡA�Y�����ߡA�N�T����ܦb Message ��
        if (!CheckNumber1())
        {
            return;
        }

        // �ˬd Number2 �O�_���X�k��ƼƭȡA�Y�����ߡA�N�T����ܦb Message ��
        if (!CheckNumber2())
        {
            return;
        }

        // �i�� Number1 �P Number2 ���[�`�B��
        int number1 = int.Parse(Number1.Text);
        int number2 = int.Parse(Number2.Text);
        int summary = number1 + number2;

        // �N�[�`���G��ܦb Summary ��
        Summary.Text = $"{number1} + {number2} �[�`���G�� {summary}";
    }

    // �ˬd Number1 �O�_���X�k��ƼƭȡA�Y�����ߡA�N�T����ܦb Message ��
    private bool CheckNumber1()
    {
        if (int.TryParse(Number1.Text, out int number1) == false)
        {
            Message.IsVisible = true;
            Message.Text = "Number1 ��������Ƽƭ�";
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
            Message.Text = "Number2 ��������Ƽƭ�";
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