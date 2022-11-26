using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_ADS.general
{
    public class Cliente
    {
        private int cedula;
        private String nombres;
        private String apellidos;
        private String dir;
        private String fecha_nac;
        private String sexo;
        private String celular;


        public Cliente()
        {
            cedula = 0;
            nombres = "";
            apellidos = "";
            dir = "";
            fecha_nac = "";
            sexo = "";
            celular = "";
        }
    }
}
