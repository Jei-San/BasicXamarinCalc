using BasicXamarinCalc.Static;
using calculatorUICOOP.Models;
using System.ComponentModel;

namespace calculatorUICOOP.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private Expression exp;

        public event PropertyChangedEventHandler PropertyChanged;

        public Expression Exp 
        { 
            get => exp;
            set { exp = value; OnPropertyChanged(nameof(Exp)); }
        }  // Mathmatical expression that contains the variables and operator

        public MainPageViewModel()
        {
            Reset();
        }

        /// <summary>
        /// Evaluate math expression based on defined operator
        /// </summary>
        /// <returns>String represenatation of expression's result</returns>
        public string Evaluate()
        {
            string output;  // Text to populate Display Label with
            decimal result; // Numberical result of math expression being evaluated

            switch (Exp.Operator)
            {
                case Operator.Add:
                    result = Math.Add(Exp.X, Exp.Y);
                    break;
                case Operator.Subtract:
                    result = Math.Subtract(Exp.X, Exp.Y);
                    break;
                case Operator.Multiply:
                    result = Math.Multiply(Exp.X, Exp.Y);
                    break;
                case Operator.Divide:
                    result = Math.Divide(Exp.X, Exp.Y);
                    break;
                default:
                    return "No operator";
            }

            Exp.X = result;
            output = $"{result}";
            return output;
        }

        public void Reset()
        {
            Exp = new Expression();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
