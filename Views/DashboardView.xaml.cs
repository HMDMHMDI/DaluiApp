using System.Collections.ObjectModel;
using DaluiApp.Models;

namespace DaluiApp.Views;

public partial class DashboardView : ContentPage
{
    public ObservableCollection<Models.Profile> Profiless{ get; set; } 
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

    public DashboardView()
	{
        InitializeComponent();
        LoadData();
        BindingContext = this;
    }


    private void LoadData()
    {
        
        Profiless = new ObservableCollection<Models.Profile>
        {
            new Models.Profile
            {
                Name = "Hector",
                ProfileImage = "dotnet_bot",
                NoPhotos = 12
            },
            new Models.Profile
            {
                Name = "Hamed",
                ProfileImage = "dotnet_bot",
                NoPhotos = 14
            },
            new Models.Profile
            {
                Name = "Ali",
                ProfileImage = "dotnet_bot",
                NoPhotos = 15
            },
            new Models.Profile
            {
                Name = "Hector",
                ProfileImage = "dotnet_bot",
                NoPhotos = 12
            },
            new Models.Profile
            {
                Name = "Hector",
                ProfileImage = "dotnet_bot",
                NoPhotos = 12
            },
            new Models.Profile
            {
                Name = "Hector",
                ProfileImage = "dotnet_bot",
                NoPhotos = 12
            },
        };
        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath = "dotnet_bot",
                MainKeyword = "Castle",
                Keywords = new List<string>
                {
                    "Epic","Hill", "Mountain"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dotnet_bot",
                MainKeyword = "Mountain",
                Keywords = new List<string>
                {
                    "Landscape","dawn", "Mountains"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dotnet_bot",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "AI","Human", "Metal"
                }
            },

        };
    }
}
