using ApplicationCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ApplicationCore.Data.Repository
{
    public class UsuarioDA
    {
        internal static List<Usuario> GetUsuarios()
        {
            var u = new Usuario { Id = -1 };

            var sql = $@"SELECT * 
                    FROM usuario_temp 
                    WHERE id > {u.Id}";

            var result = DapperRepository<Usuario>.GetList(sql);

            return result;
        }

    }
}
