using BMI.ViewModels;

namespace BMI.Views;

public partial class EmployedPage : ContentPage
{
	public EmployedPage()
	{
		InitializeComponent();
		this.BindingContext = new EmployedPageViewModel();




	}
}