using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UsusariosBLL
/// </summary>
public class UsusariosBLL
{
    public UsusariosBLL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public static List<UsuarioDTO> MostrarTodosRoles()
    {
        List<UsuarioDTO> listarUsuarios = new List<UsuarioDTO>();
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        UsuariosDTS.USUARIOSDataTable tabla = adapatador.MostrarUsuarios();
        foreach (UsuariosDTS.USUARIOSRow filas in tabla)
        {
            listarUsuarios.Add(filaDTOUsuario(filas));
        }
        return listarUsuarios;

    }
 

    private static UsuarioDTO filaDTOUsuario(UsuariosDTS.USUARIOSRow filas)
    {
        UsuarioDTO objDTOUSer = new UsuarioDTO();
        objDTOUSer.COD_USER = filas.COD_USER;
        objDTOUSer.NIC_USER = filas.NIC_USER;
        objDTOUSer.PAS_USER = filas.PAS_USER;
        return objDTOUSer;
    }
    
    public static UsuarioDTO MostrarUserID(string cod_user)
    {
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        UsuariosDTS.USUARIOSDataTable tabla = adapatador.MostarUser_ID(cod_user);
        if (tabla.Rows.Count == 0)
        {
            return null;

        }
        return filaDTOUsuario(tabla[0]);

    }


    public static UsuarioDTO LoginUser(string user, string  pass)
    {
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        UsuariosDTS.USUARIOSDataTable tabla = adapatador.MOSTRARUSERLOGIN(user, pass);
        if (tabla.Rows.Count == 0)
        {
            return null;

        }
        return filaDTOUsuario(tabla[0]);

    }

    public void Insertar(string CodUser, string user, string pass) {
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        adapatador.Insert(CodUser,user, pass);
            }
    public void Borrar(string CodUser)
    {
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        adapatador.Delete(CodUser);
    }

    public void Actualizar(string CodUser, string user, string pass)
    {
        UsuariosDTSTableAdapters.USUARIOSTableAdapter adapatador = new UsuariosDTSTableAdapters.USUARIOSTableAdapter();
        adapatador.Update(CodUser, user, pass, CodUser);
    }

}