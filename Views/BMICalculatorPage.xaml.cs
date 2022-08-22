using BMI.ViewModels;

namespace BMI.Views;

public partial class BMICalculatorPage : ContentPage
{
    public BMICalculatorPage()
    {
        InitializeComponent();
        this.BindingContext = new BMICalculatorPageViewModel();
    }

  
}