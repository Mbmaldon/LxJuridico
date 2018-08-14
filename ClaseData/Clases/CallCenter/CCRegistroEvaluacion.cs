using ClaseData.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseData.Clases.CallCenter
{
    /*Función para registrar la evaluacion del servicio brindado callcenter*/
    public class CCRegistroEvaluacion
    {

        public void registroEvaluacionServicio(int idCallCenter, int sP1, int sP2, int sP3, int sP4, int sP5, int sP6, string sP7, Boolean iContacto, string sObservaciones)
        {
            DBCAJDataContext ADB = new DBCAJDataContext(LogicaCC.ConnectionString.DbMPYSJDB);
            ADB.SOLSPI_ALTA_REGISTRO_EVALUACION_SERVICIO(idCallCenter 
                                                        ,sP1
                                                        ,sP2
                                                        ,sP3
                                                        ,sP4
                                                        ,sP5
                                                        ,sP6
                                                        ,sP7
                                                        ,iContacto
                                                        ,sObservaciones);
        } 
    }
}
