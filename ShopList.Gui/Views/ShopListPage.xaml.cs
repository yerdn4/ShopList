namespace ShopList.Gui.ViewModels;

public partial class ShopListPage : ContentPage
{
	public ShopListPage()
	{
		InitializeComponent();
		BindContext = new ShopListViewModels();
	}
}