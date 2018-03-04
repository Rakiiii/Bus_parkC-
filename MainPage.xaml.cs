using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Bus_park
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //добовляем новый автобус
        //TODO написать метод добовления автобуса в базу данных

        private void Add_Bus(object sender, RoutedEventArgs e)
        {

        }

        //меняем положение автобуса
        //TODO написать метод изменения поля в базе данных

        private void Change_Bus(object sender, RoutedEventArgs e)
        {

        }

        //Выводим информацию об автобусах
        //TODO метод перехода на другую страницу сновым меню способа вбора вывода
        //TODO написать метод вывода в текстовом виде
        //TODO написать метод озвучки

        private void Show_Info (object sender , RoutedEventArgs e)
        {

        }
    }
}
