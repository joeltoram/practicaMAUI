using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace BMI.ViewModels
{
    public partial class BMICalculatorPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(BMIScore))]
        [AlsoNotifyChangeFor(nameof(BMIResult))]
        public double _height;
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(BMIScore))]
        [AlsoNotifyChangeFor(nameof(BMIResult))]
        public double _weight;

        public double BMIScore
            => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

        public string BMIResult
        {
            get
            {
                if (BMIScore < 18.5)
                    return "Bajo Peso";
                else if (BMIScore < 25)
                    return "Saludable";
                else if (BMIScore < 30)
                    return "Sobre Peso";
                else
                    return "Obeso (a)";
            }
        }

    }
}
