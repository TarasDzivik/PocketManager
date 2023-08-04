namespace PocketManager.Services.BindingHelpers.Abstract;
public abstract class BaseLabelUpdater<T> where T : Label
{
    public static void TextState(T element, string stateText) => element.Dispatcher.Dispatch(() => element.Text = stateText);
    public static void TextColorState(T element, Color color) => element.Dispatcher.Dispatch(() => element.TextColor = color);
    public static void FontSizeState(T element, double size) => element.Dispatcher.Dispatch(() => element.FontSize = size);
}
