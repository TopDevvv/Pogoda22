using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogoda2
{
    class PogodaResponse
    {
        public string Name { set; get; }
        public MainInfo Main { set; get; }
        public WaidInfo Wind { set; get; }
        public SysInfo Sys { set; get; }
        public int visibility { set; get; }
        public WeatherInfo[] Weather { set; get; }







    }
    class MainInfo
    {
        public float Temp { set; get; }
        public int pressure { set; get; }
        public int humidity { set; get; }
        public float visibility { set; get; }
       
    }
    class WaidInfo
    {
        public float speed { set; get; }
        public int Deg { set; get; }
    }
    class SysInfo
    {
        public string country { set; get; }
        public int sunrise { set; get; }
        public int sunset { set; get; }
    }
    class WindInfo
    {
        public float speed { set; get; }
        public int Deg { set; get; }
    }

    class WeatherInfo
    {
        public string description { set; get; }
        public string Icon { set; get; }
    }


}
