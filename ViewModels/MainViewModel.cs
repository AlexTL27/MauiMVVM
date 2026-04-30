using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

//Model View View-model (VMMV)

//Este es el view model, View no sabe que existe, aqui va logica de presentacion, pero lógica más pesada como de negocio, este sabria a quien pedirsela, pero
//esa lógica no va aquí


namespace MauiMVVM.ViewModels
{
    //Esta interfaz de .net, notifica a la pagina xaml. cuando algo de este script a cambiado 
    //internal class MainViewModel : INotifyPropertyChanged
    //{
    //    //El _ es estandar, indica campos privados dentro de la clase, no es obligación
    //    private int _count;
    //    public int Count 
    //    {
    //        get { return _count; }
    //        set 
    //        {
    //            _count = value;
    //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
    //        }
    //    }

    internal partial class MainViewModel : ObservableObject
    {
        //Con esto nos ahorramos todo el codigo de arriba
        // El atributo [ObservableProperty] debe aplicarse a un campo privado,
        // el generador crea la propiedad pública 'Count'.
        [ObservableProperty]
        private int count;

   
        //NO tenemos acceso a ningun botón ni nada de la página MainPage.xaml

        //Evento que notifica el cambio de alguna propiedad del view model a la interfaz (View)
        //public event PropertyChangedEventHandler? PropertyChanged;
        //Ya no se ocupa, porque no usamos a INotifyPropertyChanged



        //Este metodo igual se simplifica
        //public ICommand SumarCommand => new Command(() => 
        //{
        //    Count++;
        //}
        //);




        [RelayCommand]
        public void Sumar()
        {
            Count++;
        }
    }
}
