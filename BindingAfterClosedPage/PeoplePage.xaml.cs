using BindingAfterClosedPage.ViewModels;

namespace BindingAfterClosedPage;

public partial class PeoplePage : ContentPage
{
	public PeoplePage(PeopleViewModel viewModel)
	{
		InitializeComponent();

		PeopleListView.ItemsSource = viewModel.People;

		ToolbarItems.Add(new ToolbarItem("Back", null, async () =>
		{
			await Navigation.PopModalAsync(true);
		}));

	}
}