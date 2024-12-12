using BindingAfterClosedPage.ViewModels;

namespace BindingAfterClosedPage
{
	public partial class MainPage : ContentPage
	{

		private PeopleViewModel _viewModel = new PeopleViewModel();

		public MainPage()
		{
			InitializeComponent();
		}

		private async void OpenPeoplePage_Clicked(object sender, EventArgs e)
		{
			NavigationPage navigationPage = new NavigationPage(new PeoplePage(_viewModel));

			await Navigation.PushModalAsync(navigationPage);
		}

		private void ClearPeople_Clicked(object sender, EventArgs e)
		{
			_viewModel.ClearPeople();
		}
	}

}
