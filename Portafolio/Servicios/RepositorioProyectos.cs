using Portafolio.Models;

namespace Portafolio.Servicios
{
    public class RepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO {
                    Titulo = "Amazon",
                    Descripcion = "Descripción del proyecto 1",
                    Link = "https://www.amazon.com/-/es/",
                    ImagenURL = "/images/Amazon.png"

                },
                new ProyectoDTO {
                    Titulo = "Youtube",
                    Descripcion = "Descripción del proyecto 2",
                    Link = "https://www.youtube.com/",
                    ImagenURL = "/images/Youtube.png"
                },
                new ProyectoDTO {
                    Titulo = "CSS",
                    Descripcion = "Descripción del proyecto 3",
                    Link = "https://www.slayingthedragon.io/dashboard/css/introduction",
                    ImagenURL = "/images/CSS.png"
                }
            };
        }
    }
}
