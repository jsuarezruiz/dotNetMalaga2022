namespace dotNetMalaga2022.Views;

public partial class DesktopView : ContentPage
{
	public DesktopView()
	{
		InitializeComponent();

        BindingContext = this;
	}

    void OnMenuItemItemClicked(object sender, EventArgs e)
    {
        if (sender is MenuFlyoutItem mfi)
        {
            MenuLabel.Text = $"You clicked on Menu Item: {mfi.Text}";
        }
    }

    async void OnEntryShowTextClicked(object sender, EventArgs e)
    {
        await DisplayAlert(
            title: "Entry",
            message: $"The entry's text is: {EntryWithContextFlyout.Text}",
            cancel: "OK");
    }

    void OnEntryAddTextClicked(object sender, EventArgs e)
    {
        EntryWithContextFlyout.Text += " more text!";
    }

    void OnEntryClearTextClicked(object sender, EventArgs e)
    {
        EntryWithContextFlyout.Text = string.Empty;
    }

    void OnNewWindowClicked(object sender, EventArgs e)
    {
        Application.Current.OpenWindow(new Window(new BorderView()));
    }

    void OnSetCustomSize(object sender, EventArgs e)
    {
        Window.Width = 700;
        Window.Height = 500;
    }

    void OnHoverBegan(object sender, PointerEventArgs e)
    {
        HoverLabel.Text = "Thanks for hovering me!";
    }

    void OnHoverEnded(object sender, PointerEventArgs e)
    {
        HoverLabel.Text = "Hover me again!";
    }

    void OnHoverMoved(object sender, PointerEventArgs e)
    {
        PositionLabel.Text = $"Pointer position is at: {e.GetPosition((View)sender)}";
        PositionToWindow.Text = $"Pointer position inside window: {e.GetPosition(null)}";
        PositionToThisLabel.Text = $"Pointer position relative to this label: {e.GetPosition(PositionToThisLabel)}";
    }
}