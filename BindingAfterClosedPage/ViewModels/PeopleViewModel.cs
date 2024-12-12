using System.Collections.ObjectModel;

namespace BindingAfterClosedPage.ViewModels
{
	public class PeopleViewModel
	{

		private ObservableCollection<PersonViewModel> _people = new ObservableCollection<PersonViewModel>();

		public PeopleViewModel()
		{
			_people.Add(new PersonViewModel() { FirstName = "Arthur", LastName = "Zeta-Jones" });
			_people.Add(new PersonViewModel() { FirstName = "Zach", LastName = "Anderson" });
		}

		public ObservableCollection<PersonViewModel> People
		{
			get { return _people; }
		}

		public void ClearPeople()
		{
			_people.Clear();
		}

	}
}
