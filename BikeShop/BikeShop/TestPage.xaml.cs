﻿using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace BikeShop
{
    /// <summary>
    /// TestPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TestPage : Page
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void Init()
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                /*Car car = new Car();
                car.Speed = i * 10;
                cars.Add(car);*/

                cars.Add(new Car()
                {
                    Speed = i * 10,
                    Color = Color.FromRgb((byte)(255/(i+1)), (byte)255 / (i + 1)), (byte)255 / (i + 1)))
                });
            }
            this.DataContext = cars;
        }
        
    }


}
