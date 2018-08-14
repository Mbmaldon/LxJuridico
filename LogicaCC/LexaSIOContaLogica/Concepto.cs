using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOContaLogica
{
    public class Concepto
    {
        public decimal   iIdConcepto            { get; set; }
        public string    sConcepto              { get; set; }
        public decimal   dMonto                 { get; set; }
		public decimal	 dImporteAnterior		{ get; set; }
		public decimal	 dImporteFaltante		{ get; set; }
		public decimal	 dImporteAdeudoActual	{ get; set; }

		public decimal   dFactorActualizacion   { get; set; }
        public decimal   dImporteActualizacion  { get; set; }
        public decimal   dPorcentajeRecargos    { get; set; }
        public decimal   dImporteRecargos       { get; set; }
        public decimal   dTotalPagar            { get; set; }

        public Concepto()
        {
            this.iIdConcepto  = 0;
            this.sConcepto    = string.Empty;
            this.dMonto       = 0;
        }

        /// <summary>
        /// Método Público que regresa una lista de conceptos para agregar en una declaración
        /// </summary>
        /// <returns></returns>
        public List<Concepto> listaConceptos()
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Concepto> lista = new List<Concepto>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_Concepto", _SqlConnection) { CommandType = CommandType.StoredProcedure };

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS NUESTRA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if(_sqlDataReader.HasRows)
                    {
                        while(_sqlDataReader.Read())
                        {
                            //CREAMOS UN NUEVO OBJETO CONCEPTO Y LO AGREGAMOS A LA LISTA
                            Concepto concepto = new Concepto()
                            {
                                iIdConcepto  = int.Parse(_sqlDataReader["IdConcepto"].ToString()),
                                sConcepto    = _sqlDataReader["Concepto"].ToString()
                            };
                            lista.Add(concepto);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;
                }
                return lista;
            }
        }

        /// <summary>
        /// Método Público que regresa una lista de conceptos pertencientes
        /// a una declaración para realizar claculos en la calculadora de recargos y actualizaciones
        /// </summary>
        /// <param name="idDeclaracion">ID de la declaración</param>
        /// <returns></returns>
        public List<Concepto> listaConceptosCalculadora(int idDeclaracion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPY))
            {
                List<Concepto> lista = new List<Concepto>();
                SqlCommand _SqlCommand = new SqlCommand("OFSPS_Informacion_DeclaracionImportes", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                // PASAMOS COMO PARAMETRO A LA CONSULTA, EL ID DE LA DECLARACIÓN
                _SqlCommand.Parameters.AddWithValue("@idDeclaracion", idDeclaracion);

                try
                {
                    //ABRIMOS NUESTRA CONEXIÓN
                    _SqlConnection.Open();
                    //EJECUTAMOS LA CONSULTA
                    SqlDataReader _sqlDataReader = _SqlCommand.ExecuteReader();
                    if(_sqlDataReader.HasRows)
                    {
                        while (_sqlDataReader.Read())
                        {
                            //CREAMOS UN NUEVO OBJETO CONCEPTO Y LO AGREGAMOS A LA LISTA
                            Concepto concepto = new Concepto()
                            {
                                sConcepto   = _sqlDataReader["Concepto"].ToString(),
                                dMonto      = decimal.Parse(_sqlDataReader["Monto"].ToString())
                            };
                            lista.Add(concepto);
                        }
                    }
                }
                catch (Exception)
                {
                    lista = null;                
                }
                return lista;
            }
        }
    }
}
