namespace PocketManager.Veiw.Pages;

public partial class Main_Page : ContentPage

{
    int count = 0;
    public Main_Page()
    {
        InitializeComponent();
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

}