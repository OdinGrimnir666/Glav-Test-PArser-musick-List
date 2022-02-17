
using Avalonia.Controls;
using Avalonia.Interactivity;
using PArse_Musik_list_Liba_Net_Standar_2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace Glav_Test_PArser_musick_List.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

         string Url;
         public string url { get => Url; set=>Url=value; }
         private ParseMusic infoPlylist= new ParseMusic(@"https://spinitron.com/KXLU/pl/15248856/Sam-T-02-03-2022");

        public ParseMusic InfoPlylist { get => infoPlylist; set =>infoPlylist=value; }

        public List<Music> Plylist
        {
            get
            {
                return InfoPlylist.Model.Music;
            }
            
        }


        public void ButtonClick()
        {
             
             InfoPlylist = new ParseMusic(Url);
             
        }

        public string ShownValue
        {
            set
            {
                url = value;
            }
        }


        public string Greeting => "Welcome to Avalonia!";
    }
}
