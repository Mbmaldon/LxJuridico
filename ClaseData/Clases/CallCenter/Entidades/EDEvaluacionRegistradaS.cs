using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter.Entidades
{
    /*Entidad para vaciar la información de la evaluación aceptada registrada por el coordinador */
    public class EDEvaluacionRegistradaS
    {
		public string sP1               { get; set; }
        public string sP2               { get; set; }
		public string sP3               { get; set; }
		public string sP4               { get; set; }
		public string sP5               { get; set; }
        public string sP6               { get; set; }
		public string sComentarios      { get; set; }
        public string sFechaRegistro    { get; set; }

        public EDEvaluacionRegistradaS(string sP1, string sP2, string sP3, string sP4, string sP5, string sP6
                                        , string sComentarios, string sFechaRegistro)
        {
            this.sP1 = sP1;
            this.sP2 = sP2;
            this.sP3 = sP3;
            this.sP4 = sP4;
            this.sP5 = sP5;
            this.sP6 = sP6;
            this.sComentarios = sComentarios;
            this.sFechaRegistro = sFechaRegistro;
        }
}
}
