using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC
{
    public class ConnectionString
    {
        // Si Default Connection es verdadero, las bases de datos son las productivas, en caso de ser falso
        // las bases de datos son las de prueba.
        private static string sMedic           = Properties.Settings.Default.DefaultConnection? "PRO$MPY": "MPY";
        private static string sMedicAlimentos  = Properties.Settings.Default.DefaultConnection? "PRO$MPYALIMENTOS": "MPYALIMENTOS";
        private static string sMedicConta      = Properties.Settings.Default.DefaultConnection? "PRO$MPYCONTA": "MPYCONTA";
        private static string sMedicOpera      = Properties.Settings.Default.DefaultConnection? "PRO$MPYOPERA": "MPYOPERA";
        private static string sMedicCsjdb      = Properties.Settings.Default.DefaultConnection? "PRO$MPYCSJDB": "MPYCSJDB";

        public static string DbMPY = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}"
                                                    , Properties.Settings.Default.DbServer
                                                    , Properties.Settings.Default.DbUser
                                                    , Properties.Settings.Default.DbPassword
                                                    , sMedic);

        public static string DbMPYAlimentos = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}"
                                                             , Properties.Settings.Default.DbServer
                                                             , Properties.Settings.Default.DbUser
                                                             , Properties.Settings.Default.DbPassword
                                                             , sMedicAlimentos);

        public static string DbMPYConta = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}"
                                                         , Properties.Settings.Default.DbServer
                                                         , Properties.Settings.Default.DbUser
                                                         , Properties.Settings.Default.DbPassword
                                                         , sMedicConta);

        public static string DbMPYOpera = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}"
                                                         , Properties.Settings.Default.DbServer
                                                         , Properties.Settings.Default.DbUser
                                                         , Properties.Settings.Default.DbPassword
                                                         , sMedicOpera);

        public static string DbMPYSJDB = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}"
                                                         , Properties.Settings.Default.DbServer
                                                         , Properties.Settings.Default.DbUser
                                                         , Properties.Settings.Default.DbPassword
                                                         , sMedicCsjdb);

        public static string FolderConnection = Properties.Settings.Default.DefaultConnection ? Properties.Settings.Default.ProMainFolder : Properties.Settings.Default.MainFolder;


        private static string sError;

        /// <summary>
        /// Al realizar una prueba de conexión al servidor, si este es fallido,
        /// la función obtiene los detalles del error de conexión
        /// </summary>
        /// <returns></returns>
        public static string GetError()
        {
            return sError;
        }

        /// <summary>
        /// Realiza una prueba de conexión hacia una base de datos
        /// </summary>
        /// <param name="DbServer">Nombre del servidor</param>
        /// <param name="DbUser">Usuario para acceder al servidor</param>
        /// <param name="DbPassword">Conytraseña para acceder al servidor</param>
        /// <param name="DbName">Nombre de la base de datos</param>
        /// <returns></returns>
        public static bool Connect(string DbServer, string DbUser, string DbPassword, string DbName)
        {
            try
            {
                string ConnectionString = string.Format(@"Data Source={0};Initial Catalog={3};User ID={1};Password={2}", DbServer, DbUser, DbPassword, DbName);
                using (SqlConnection _SqlConnection = new SqlConnection(ConnectionString))
                {
                    _SqlConnection.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return false;
            }
        }
    }
}
