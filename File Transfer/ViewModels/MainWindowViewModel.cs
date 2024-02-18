using File_Transfer.Services;
using System.Windows.Input;

namespace File_Transfer.ViewModels;

public class MainWindowViewModel:NotificationService
{
    private string? fromPath;

    public string FromPath { get => fromPath!; set { fromPath = value;OnPropertyChanged(); } }

    private string? toPath;

    public string ToPath { get => toPath!; set { toPath = value; OnPropertyChanged(); } }


    public ICommand FromBtnCommand { get; set; }
    public ICommand ToBtnCommand { get; set; }





}
