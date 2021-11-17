using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;

namespace App1.ViewModel;

internal class MainViewModel : ObservableObject
{
    private int _myNumber;
    public int MyNumber
    {
        get => _myNumber;
        set => SetProperty(ref _myNumber, value);
    }
    public ICommand OnClickCommand { get; set; }
    
    public MainViewModel()
    {
        OnClickCommand = new RelayCommand(OnClick);
    }

    private void OnClick()
    {
        MyNumber++;
    }
}
