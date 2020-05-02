using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Descripción breve de hash
/// </summary>
public class hashPass
{
    public hashPass()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public  string EncriptarPr(string texto)
    {

        using (SHA1Managed encrip = new SHA1Managed())
        {
            var encript = encrip.ComputeHash(Encoding.UTF8.GetBytes(texto));
            var constructorHash = new StringBuilder(encript.Length * 2);
            foreach (byte abc in encript)
            {
                constructorHash.Append(abc.ToString("X2"));
            }
            return constructorHash.ToString();
        }

    }


}