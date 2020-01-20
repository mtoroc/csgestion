using ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSGestion.Models.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel() { }

        public UsuarioViewModel(UsuarioDTO usuarioDTO)
        {
            this.Id = usuarioDTO.Id;
            this.Nombre = usuarioDTO.Nombre;
        }

        public int Id { get; set; }

        [Display(Name = "Nombre *")]
        [Required(ErrorMessage = "Nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
