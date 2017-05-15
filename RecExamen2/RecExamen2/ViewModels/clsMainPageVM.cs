using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RecExamen2.Models;

namespace RecExamen2.ViewModels
{
    public class clsMainPageVM : clsVMBase
    {

        #region Atributos

        private ObservableCollection<clsCampeon> _listaCampeones;
        private clsCampeon _campeonSeleccionado;
        //private Uri _imagenSeleccionada;

        #endregion

        #region Constructores

        public clsMainPageVM()
        {
            obtenerCampeones();

        }

        #endregion

        #region Getters setters

        /// <summary>
        /// GET/SET Lista de clsCampeon
        /// </summary>
        public ObservableCollection<clsCampeon> ListaCampeones
        {
            get
            {
                return _listaCampeones;
            }

            set
            {
                _listaCampeones = value;
                NotifyPropertyChanged("ListaCampeones");

            }
        }

        /// <summary>
        /// GET/SET Campeon
        /// </summary>
        public clsCampeon CampeonSeleccionado
        {
            get
            {
                return _campeonSeleccionado;
            }

            set
            {
                _campeonSeleccionado = value;
                NotifyPropertyChanged("CampeonSeleccionado");

            }
        }

        /// <summary>
        /// GET/SET ImagenSeleccionada
        /// </summary>
        //public Uri Imagenseleccionada
        //{
        //    get
        //    {
        //        return _imagenSeleccionada;
        //    }

        //    set
        //    {
        //        _imagenSeleccionada = value;
        //        NotifyPropertyChanged("Imagenseleccionada");
        //    }
        //}

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que rellena el listado de campeones
        /// </summary>
        private async void obtenerCampeones()
        {

            clsListado listado = new clsListado();
            ListaCampeones = await listado.getPersonajes();
            CampeonSeleccionado = ListaCampeones[0];
            NotifyPropertyChanged("listaPersonajes");

        }

        #endregion

    }
}
