using BlogMVVMThree.Models;

using System;
using System.Collections.Generic;

namespace BlogMVVMThree.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<BlogEntity> BlogEntities { get; set; }

        public List<NewsEntity> NewsEntities { get; set; }

        public MainWindowViewModel()
        {
            BlogEntities = new List<BlogEntity>()
      {
        new BlogEntity() {ImagePath = "happy.png", Article = "Article 1", Text = "Ut nisl quam, sodales sit amet lectus eget, suscipit imperdiet lectus. Sed luctus risus id bibendum aliquam. Pellentesque ut dui vitae sapien dictum vestibulum. Ut risus elit, sodales placerat dui vitae, feugiat mattis mi. Cras dapibus dapibus sagittis. Nulla metus sem, lobortis sed tincidunt id, rutrum id tellus. Quisque iaculis, elit at interdum fermentum, leo risus sollicitudin arcu, id ultricies quam ipsum vel dui. Fusce consequat molestie sem nec gravida. Vivamus venenatis risus tristique laoreet faucibus. Nullam pharetra varius nisl sit amet iaculis. Maecenas blandit rhoncus quam at porta. Mauris ullamcorper scelerisque dapibus. Nullam quis metus quis nulla efficitur lacinia. Nullam eu diam mi. Etiam faucibus quam quis augue luctus auctor. Morbi consectetur tellus non nibh venenatis aliquam. Cras nec pretium nibh. Proin eu ullamcorper magna. Nam non urna ut nulla tempor ullamcorper ut sed risus. Donec interdum pharetra sem, vitae dignissim velit vehicula at. Fusce nec malesuada enim, sed congue lorem.", Tags = new List<string> {"tag1", "tag2", "tag3"} } ,
        new BlogEntity() {ImagePath = "basa.png", Article = "Article 2", Text = "Vivamus eros turpis, sagittis non pharetra eu, pretium id ligula. Etiam blandit lectus a est lobortis accumsan at ac est. Donec pulvinar enim consectetur sapien condimentum rhoncus ac ac nunc. Suspendisse laoreet vestibulum nibh, sit amet auctor lacus tempus quis. In nec metus sit amet dui pulvinar scelerisque. Maecenas sed ultricies leo. Sed gravida, ligula a congue imperdiet, elit nunc dapibus urna, at tempor massa ipsum ac eros. Nam fringilla erat lorem, sit amet condimentum turpis posuere eu. Curabitur nec dolor tristique, rutrum sem vel, tincidunt tortor. Vestibulum aliquet, ligula eget porttitor pharetra, ligula est pharetra eros, nec porttitor purus turpis quis odio. Integer tincidunt malesuada velit at vestibulum. Donec nec elementum ex, nec bibendum sem. Praesent et mi eu augue faucibus commodo. Donec vestibulum elit enim, sit amet finibus felis aliquam at. Nullam vehicula consequat nisi, ut rutrum risus dapibus vitae. Curabitur placerat lacus diam, vel efficitur nibh venenatis eu.", Tags = new List<string> {"tag4", "tag5", "tag6"} }
      };

            NewsEntities = new List<NewsEntity>()
      {
        new NewsEntity() {Text = "News 1: Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas ultricies enim nec congue congue. Cras maximus massa quam. Vestibulum et nibh nibh. Curabitur in nisl leo. Proin quis lectus venenatis, mattis nunc et, iaculis nisl. Suspendisse venenatis condimentum neque, id fermentum velit imperdiet sit amet. Mauris id orci erat. In hac habitasse platea dictumst. Phasellus eros nulla, accumsan et vulputate vitae, viverra id leo." , PublishDate = DateTime.Now},
        new NewsEntity() {Text = "News 2: Nam ut dui eget nulla vehicula cursus. Nam nisi mi, placerat a convallis non, tincidunt sit amet metus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Cras non blandit ante, a ultrices nisl. Maecenas facilisis aliquet vestibulum. Duis efficitur mattis eros, eu pellentesque ipsum. Etiam pellentesque tincidunt euismod. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In non fringilla justo. Nam ullamcorper ante eget tellus blandit, vitae hendrerit eros laoreet." , PublishDate = DateTime.Now.AddDays(-3)}
      };
        }
    }
}