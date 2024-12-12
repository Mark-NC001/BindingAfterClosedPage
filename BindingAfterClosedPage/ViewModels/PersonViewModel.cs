
namespace BindingAfterClosedPage.ViewModels
{
	public class PersonViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override string ToString()
		{
			return LastName.ToUpper() + ", " + FirstName;
		}
	}
}
