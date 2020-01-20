using ApplicationCore.Data.Entities;
using ApplicationCore.Data.Repository;
using ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Business
{
    public class UsuarioBO
    {
        public List<UsuarioDTO> GetUsuarios()
        {
            var usuarios = UsuarioDA.GetUsuarios();
            var dto = new List<UsuarioDTO>();

            foreach (var item in usuarios)
            {
                dto.Add(new UsuarioDTO(item));
            }

            return dto;
        }
    }
}
