using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _44.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public List<BlogEntity> BlogEntities { get; set; }
    public List<NewsEntity> NewsEntities { get; set; }
}
public MainWindowViewModel()
{
    BlogEntities = new List<BlogEntity>()
    {

    };
    NewsEntities = new List<NewsEntity>()
    {
        new NewsEntity(){Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", PublishDate = DateTime.Now}
        new NewsEntity(){Text = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", PublishDate = DateTime.Now.AddDays(-12)}
    };
}

