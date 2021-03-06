using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {


        private ObservableCollection<Plato> comidas;

        private ObservableCollection<string> tipoComida = new ObservableCollection<string>();

        public ObservableCollection<String> TipoComida
        {
            get { return tipoComida; }
            set
            {
                tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }

        public ObservableCollection<Plato> Comidas
        {
            get { return comidas; }
            set {comidas = value;
                NotifyPropertyChanged("Comidas");
            }
        }

        public MainWindowVM()
        {
            Comidas = Plato.GetSamples(@"C:\Users\alumno\Desktop\ut5_actv1_recursos\FotosPlatos");
            CargarComida();


        }

        public MainWindowVM(ObservableCollection<Plato> comidas, ObservableCollection<String> tipoComida)
        {
            Comidas = comidas;
            

        }

        public void CargarComida()
        {
            tipoComida.Add("China");
            tipoComida.Add("Americana");
            tipoComida.Add("Mejicana");
        }

        public void QuitarPlatoSeleccionado()
        {
            QuitarPlatoSeleccionado = null;
        }


        public event PropertyChangedEventHandler PropertyChanged;


        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
