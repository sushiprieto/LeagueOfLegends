using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Filters;
using RecExamen2.Models;

namespace RecExamen2.Models
{
    public class clsListado
    {

        private Uri uri;

        public clsListado()
        {
            uri = new Uri("http://localhost:2461/api/personajes");
        }

        /// <summary>
        ///  Metodo que recoge todos los campeones
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<clsCampeon>> getPersonajes(String textoaBuscar = null)
        {
            ObservableCollection<clsCampeon> lista = new ObservableCollection<clsCampeon>();
            HttpBaseProtocolFilter filtro = new HttpBaseProtocolFilter();
            filtro.CacheControl.ReadBehavior = HttpCacheReadBehavior.MostRecent;
            filtro.CacheControl.WriteBehavior = HttpCacheWriteBehavior.NoCache;
            HttpClient mihttpClient = new HttpClient(filtro);

            try
            {
                string respuesta = await mihttpClient.GetStringAsync(uri);
                mihttpClient.Dispose();
                lista = JsonConvert.DeserializeObject<ObservableCollection<clsCampeon>>(respuesta);

                foreach (clsCampeon pers in lista)
                {
                    pers.foto = getFoto(pers.nombre);
                    pers.skins = getSkins(pers.nombre);
                }


            }
            catch (Exception)
            {

            }

            return lista;
        }

        /// <summary>
        /// Metodo que recoje las fotos de perfil
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public string getFoto(string nombre)
        {          

            string res = "../Assets/Imagenes/" + nombre + ".png";
                
            return res;

        }

        /// <summary>
        /// Metodo que carga las skins de los campeones
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public ObservableCollection<Uri> getSkins(string nombre)
        {
            ObservableCollection<Uri> skins = new ObservableCollection<Uri>();

            switch (nombre)
            {
                case "Aatrox":
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case "Ahri":
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "Akali":
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "Alistar":
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_5.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case "Amumu":
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case "Anivia":

                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_0.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_1.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_2.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_3.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_4.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_5.jpg", UriKind.RelativeOrAbsolute));
                    skins.Add(new Uri("ms-appx://RecExamen2/Assets/Imagenes/" + nombre + "_6.jpg", UriKind.RelativeOrAbsolute));

                    break;

            }

            return skins;
        }

    }
}
