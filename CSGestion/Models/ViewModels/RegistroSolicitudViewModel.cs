using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSGestion.Models.ViewModels
{
    public class RegistroSolicitudViewModel
    {
        [Required(ErrorMessage = "Seleccione un sector")]
        public int IdSector { get; set; }

        [Required(ErrorMessage = "Ingrese hora de inicio")]
        public string FechaHoraInicio { get; set; }

        [Required(ErrorMessage = "Ingrese hora de finalización")]
        public string FechaHoraFin { get; set; }

        [Display(Name = "Rut solicitante *")]
        [Required(ErrorMessage = "Ingrese el rut del solicitante")]
        public string RutSolicitante { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del solicitante")]
        public string NombreSolicitante { get; set; }

        [Required(ErrorMessage = "Ingrese casa o departamento")]
        public string CasaDepto { get; set; }

        public string Ubicacion { get; set; }


        public SelectList SectorList
        {
            get
            {
                var d = new List<Dummy>();
                d.Add(new Dummy { Clave = 1, Valor = "Salón de eventos A" });
                d.Add(new Dummy { Clave = 2, Valor = "Salón de eventos B" });

                return new SelectList(d, "Clave", "Valor");
            }
        }


        public SelectList UbicacionList
        {
            get
            {
                var d = new List<Dummy>();
                d.Add(new Dummy { Clave = 1, Valor = "Torre Mahuida" });
                d.Add(new Dummy { Clave = 2, Valor = "Torre B" });

                return new SelectList(d, "Clave", "Valor");
            }
        }


        public class Dummy
        {
            public int Clave { get; set; }
            public string Valor { get; set; }
        }

    }
}
