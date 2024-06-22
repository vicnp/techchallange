﻿using LHS_DataTransfer.Usuarios.Request;
using LHS_Domain.Usuarios.Entidades;
using LHS_Domain.Usuarios.Repositorios;
using LHS_IOT.Bibliotecas;
using LHS_IOT.DBContext;

namespace LHS_Infra.Usuarios
{
    public class UsuariosRepositorio(DapperContext dapperContext) : RepositorioDapper<Usuario>(dapperContext), IUsuariosRepositorio
    {
        public PaginacaoConsulta<Usuario> ListarUsuarios(UsuarioListarRequest request)
        {
      
            string SQL = $@"select u.codusuario as CodigoUsuario,
                                  u.nome as Nome,
                                  u.email as Email,
                                  u.codcargo as CodigoCargo
                         from lhs_usuario u where 1 = 1
                        ";

            if (request.NomeUsuario != null && request.NomeUsuario.Length > 0)
                SQL += $@"
                            and u.nome like '%{request.NomeUsuario}%'";

            if (request.Email != null && request.Email.Length > 0)
                SQL += $@"
                            and u.email like '%{request.Email}%'";

            return ListarPaginado(SQL.ToString(), request.Pg, request.Qt, request.CpOrd, request.TpOrd.ToString());
        }
    }
}
