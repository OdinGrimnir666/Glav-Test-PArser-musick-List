
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using PArse_Musik_list_Liba_Net_Standar_2._0;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Glav_Test_PArser_musick_List.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

         string Url="";
         public string url { get => Url; set { Url = value; } }




        public  ParseMusic infoPlylist=new ParseMusic();


        public ParseMusic InfoPlylist { get => infoPlylist; set { infoPlylist = value; } }




        public PLylist Plylistinfo
        {
            get
            {
                return infoPlylist.Model;
            }
        }


        public ObservableCollection<Music> Plylist
        {
            get
            {
                return InfoPlylist.Model.Music;
            }
            
        }


        public void OnButtonClick()
        {

            InfoPlylist.url = url;
             infoPlylist.Initilizator();


        }
      

        public string ShownValue
        { 
            set
          {
                url = value.Trim();
            }
        }


        public string Greeting => "Welcome to Avalonia!";
    }
}
