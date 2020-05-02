using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RollBLL
/// </summary>
public class RollBLL
{
    public RollBLL()
    {
        
    }

    public static List<RolDTO> MostrarTodosRoles()
    {
        List<RolDTO> listarRoles = new List<RolDTO>();
        RolDSTableAdapters.ROLESTableAdapter adaptador = new RolDSTableAdapters.ROLESTableAdapter();
        RolDS.ROLESDataTable tabla = adaptador.MostrarRoles();
        foreach (RolDS.ROLESRow filas in tabla)
        {
            listarRoles.Add(filaDTORol(filas));
        }
        return listarRoles;

    }

    private static RolDTO filaDTORol(RolDS.ROLESRow filas)
    {
        RolDTO objRol = new RolDTO();
        objRol.COD_ROL = filas.COD_ROL;
        objRol.NOM_ROL = filas.NOM_ROL;
        return objRol;
    }

    public static RolDTO MostrarRolesID(string cod_rol) {
        RolDSTableAdapters.ROLESTableAdapter adaptador = new RolDSTableAdapters.ROLESTableAdapter();
        RolDS.ROLESDataTable tabla = adaptador.MostrarRolID(cod_rol);
        if(tabla.Rows.Count==0)
        {
            return null;

        }
        return filaDTORol(tabla[0]);

    }
    public void InsertarRol(string CodRol, string NomRol) {
        RolDSTableAdapters.ROLESTableAdapter adaptador = new RolDSTableAdapters.ROLESTableAdapter();
        adaptador.Insert(CodRol, NomRol);
    }

    public void BorrarRol(string CodRol)
    {
        RolDSTableAdapters.ROLESTableAdapter adaptador = new RolDSTableAdapters.ROLESTableAdapter();
        adaptador.Delete(CodRol);
    }
    public void ActualizarRol(string CodRol, string nombreRol)
    {
        RolDSTableAdapters.ROLESTableAdapter adaptador = new RolDSTableAdapters.ROLESTableAdapter();
        adaptador.Update(CodRol, nombreRol, CodRol);
     }
}