using ApplicationCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.DTO
{
    public class UsuarioDTO
    {
        public UsuarioDTO() { }

        public UsuarioDTO(Usuario usuario) 
        {
            this.Id = usuario.Id;
            this.Nombre = usuario.Nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
