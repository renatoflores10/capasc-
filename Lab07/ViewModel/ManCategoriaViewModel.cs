using Lab07.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab07.ViewModel;

namespace Lab07.ViewModel
{
    internal class ManCategoriaViewModel : ViewModelBase
    {
        #region propiedades
        int _D;
        public int ID
        {
            get { return _D; }
            set
            {
                if(_D != value)
                {
                    _D = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }
        string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if(_Descripcion != value)
                {
                    _Descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand GrabarCommand { set; get; }
        public ICommand CerrarCommand { set; get; }

        public ManCategoriaViewModel()
        {
            GrabarCommand = new RelayCommand<object>(
                o =>
                {
                    if (ID > 0)
                        new CategoriaModel().Actualizar(new Entity.Categoria
                        {
                            IdCategoria = ID,
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });
                    else
                        new CategoriaModel().Insertar(new Entity.Categoria
                        {
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });
                });

            CerrarCommand = new RelayCommand<Window>(
                param => Cerrar(param));
        }

        void Cerrar(Window window)
        {
            window.Close();
        }
    }

}
