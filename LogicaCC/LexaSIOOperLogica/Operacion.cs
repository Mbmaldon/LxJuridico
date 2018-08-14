using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LogicaCC.LexaSIOOperLogica
{
    public class Operacion
    {
        public int      iIdOperacion                { get; set; }
        public int      iIdOperacionComisionista    { get; set; }
        public int      iIdVendedor                 { get; set; }
        public int      iPagado                     { get; set; }
        public decimal  dImporte                    { get; set; }
        public DateTime dFechaPago                  { get; set; }
        public DateTime dFechaFactura               { get; set; }
        public int      iNoSemana                   { get; set; }
        public string   sComentario                 { get; set; }

        public Operacion()
        {
            iIdOperacion             = 0;
            iIdOperacionComisionista = 0;
            iIdVendedor              = 0;
            iPagado                  = 0;
            dImporte                 = 0;
            dFechaPago               = DateTime.Now;
        }

        public bool bPagarFactura(Operacion operacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPU_Pagar_Factura", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdOperacion", operacion.iIdOperacion);
                _SqlCommand.Parameters.AddWithValue("@IdVendedor", operacion.iIdVendedor);
                _SqlCommand.Parameters.AddWithValue("@FechaFactura", operacion.dFechaFactura);
                _SqlCommand.Parameters.AddWithValue("@FechaDeposito", operacion.dFechaPago);
                _SqlCommand.Parameters.AddWithValue("@NoSemana", operacion.iNoSemana);

                var parameterReturn = _SqlCommand.Parameters.Add("@Status", SqlDbType.Int);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    var result = parameterReturn.Value;
                    if (int.Parse(result.ToString()) == 1)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool bCancelarFactura(Operacion operacion)
        {
            using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString.DbMPYOpera))
            {
                SqlCommand _SqlCommand = new SqlCommand("LSOSPU_Cancelar_Factura ", _SqlConnection) { CommandType = CommandType.StoredProcedure };
                _SqlCommand.Parameters.AddWithValue("@IdOperacion", operacion.iIdOperacion);
                _SqlCommand.Parameters.AddWithValue("@Comentario", operacion.sComentario);

                var parameterReturn = _SqlCommand.Parameters.AddWithValue("@Status", SqlDbType.Int);
                parameterReturn.Direction = ParameterDirection.ReturnValue;

                try
                {
                    _SqlConnection.Open();
                    _SqlCommand.ExecuteNonQuery();
                    var result = parameterReturn.Value;
                    if (int.Parse(result.ToString()) == 1)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
