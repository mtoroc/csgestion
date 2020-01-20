using ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSGestion.Models.ViewModels
{
    public class UsuarioListViewModel
    {
        public List<UsuarioDTO> ListaUsuarioDTO { get; set; } = new List<UsuarioDTO>();
        public List<UsuarioViewModel> ListaUsuarioViewModel { get; set; } = new List<UsuarioViewModel>();
    }
}
