using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCC
{
    public class FTPServer
    {
        public static string regex = @"^" +                          //# Start of line
                                     @"(?<dir>[\-ld])" +             //# File size          
                                     @"(?<permission>[\-rwx]{9})" +  //# Whitespace          \n
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<filecode>\d+)" +
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<owner>\w+)" +
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<group>\w+)" +
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<size>\d+)" +
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<month>\w{3})" +            //# Month (3 letters)   \n
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<day>\d{1,2})" +            //# Day (1 or 2 digits) \n
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<timeyear>[\d:]{4,5})" +    //# Time or year        \n
                                     @"\s+" +                        //# Whitespace          \n
                                     @"(?<filename>(.*))" +          //# Filename            \n
                                     @"$";                           //# End of line

        /// <summary>
        /// Sube un archivo por FTP
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="strFileNameFTP">Nombre del archivo a descargar desde el servidor FTP</param>
        /// <param name="strFileNameLocal">Ruta local completa donde se encuentra el archivo a subir</param>
        public static void Upload(string strServer, string strUser, string strPassword, string strFileNameFTP, string strFileNameLocal)
        {
            // Crea el objeto de conexión del servidor FTP
            FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, strFileNameFTP));
            // Asigna las credenciales
            _FtpWebRequest.Credentials = new NetworkCredential(strUser, strPassword);
            // Asigna las propiedades
            _FtpWebRequest.Method       = WebRequestMethods.Ftp.UploadFile;
            _FtpWebRequest.UsePassive   = true;
            _FtpWebRequest.UseBinary    = true;
            _FtpWebRequest.KeepAlive    = true;
            // Obtiene el stream sobre el archivo local
            FileStream _FileStream = File.OpenRead(strFileNameLocal);
            byte[] buffer = new byte[_FileStream.Length];
            _FileStream.Read(buffer, 0, buffer.Length);
            // Cierra el stream FTP	
            _FileStream.Close();

            Stream _Stream = _FtpWebRequest.GetRequestStream();
            _Stream.Write(buffer, 0, buffer.Length);
            _Stream.Flush();
            _Stream.Close();
        }

        /// <summary>
        /// Verifica si existe un archivo en un directorio
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="fileName">Nombre del archivo que requiere validar</param>
        /// <returns></returns>
        public static bool CheckIfFileExistsOnServer(string strServer, string strUser, string strPassword, string fileName)
        {
            FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, fileName));
            _FtpWebRequest.Credentials   = new NetworkCredential(strUser, strPassword);
            _FtpWebRequest.Method        = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse _FtpWebResponse = (FtpWebResponse)_FtpWebRequest.GetResponse();
                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse _FtpWebResponse = (FtpWebResponse)ex.Response;
                if (_FtpWebResponse.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
            }
            return false;
        }

        /// <summary>
        /// Verifica si existe un directorio en el FTP
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="sDirectory">Directorio o carpeta que desea validar</param>
        /// <returns></returns>
        public static bool DirectoryExists(string strServer, string strUser, string strPassword, string sDirectory)
        {
            bool IsExists = true;
            try
            {
                FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}/", strServer, sDirectory));
                _FtpWebRequest.Credentials   = new NetworkCredential(strUser, strPassword);
                _FtpWebRequest.Method        = WebRequestMethods.Ftp.PrintWorkingDirectory;

                FtpWebResponse _FtpWebResponse = (FtpWebResponse)_FtpWebRequest.GetResponse();
            }
            catch (WebException ex)
            {
                IsExists = false;
            }
            return IsExists;
        }

        /// <summary>
        /// Crea un directorio en el servidor FTP
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="sDirectoryName">Directorio que desea crear</param>
        public static void CreateDirectory(string sServer, string sUser, string sPassword, string sDirectoryName)
        {
            try
            {
                WebRequest _WebRequest  = WebRequest.Create(string.Format("ftp://{0}/{1}/{2}", sServer, ConnectionString.FolderConnection, sDirectoryName));
                _WebRequest.Method      = WebRequestMethods.Ftp.MakeDirectory;
                _WebRequest.Credentials = new NetworkCredential(sUser, sPassword);

                FtpWebResponse _FtpWebResponse = (FtpWebResponse)_WebRequest.GetResponse();
            }
            catch (Exception)
            {
            } 
        }

        /// <summary>
        /// Cuenta el numero de archivos en un directorio
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="sDirectory">Directorio del que desea contar el número de archivos</param>
        /// <returns></returns>
        public static List<string> Count(string strServer, string strUser, string strPassword, string sDirectory)
        {
            List<string> strList = new List<string>();

            FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("ftp://{0}/{1}", strServer, sDirectory)));
            _FtpWebRequest.Credentials   = new NetworkCredential(strUser, strPassword);
            _FtpWebRequest.Method        = WebRequestMethods.Ftp.ListDirectory;

            //Can object of type StreamReader as given below
            StreamReader _StreamReader = new StreamReader(_FtpWebRequest.GetResponse().GetResponseStream());
            string str = _StreamReader.ReadLine();
            while (str != null)
            {
                strList.Add(str);
                str = _StreamReader.ReadLine();
            }

            return strList;
        }

        /// <summary>
        /// Renombrar un archivo en el servidor FTP
        /// </summary>
        /// <param name="currentFileNameAndPath"></param>
        /// <param name="newFileName"></param>
        public static void RenameFile(string strServer, string strUser, string strPassword, string strFileNameFTP, string strNewFileName)
        {
            try
            {
                /* Create an FTP Request */
                FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", strServer, strFileNameFTP));
                /* Log in to the FTP Server with the User Name and Password Provided */
                _FtpWebRequest.Credentials = new NetworkCredential(strUser, strPassword);
                /* When in doubt, use these options */
                _FtpWebRequest.UseBinary  = true;
                _FtpWebRequest.UsePassive = true;
                _FtpWebRequest.KeepAlive  = true;
                /* Specify the Type of FTP Request */
                _FtpWebRequest.Method = WebRequestMethods.Ftp.Rename;
                /* Rename the File */
                _FtpWebRequest.RenameTo = strNewFileName;
                /* Establish Return Communication with the FTP Server */
                FtpWebResponse _FtpWebResponse = (FtpWebResponse)_FtpWebRequest.GetResponse();
                /* Resource Cleanup */
                _FtpWebResponse.Close();
                _FtpWebRequest = null;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /// <summary>
        /// Cuenta el numero de archivos en un directorio
        /// </summary>
        /// <param name="strServer">Dirección del servidor FTP</param>
        /// <param name="strUser">Usuario del servidor FTP</param>
        /// <param name="strPassword">Contraseña del servidor FTP</param>
        /// <param name="sDirectoryName">Directorio del que desea contar el número de archivos</param>
        /// <returns></returns>
        public static int CountFileList(string sServer, string sUser, string sPassword, string sDirectoryName)
        {
            StringBuilder _StringBuilder = new StringBuilder();
            WebResponse _WebResponse = null;
            StreamReader _StreamReader  = null;
            try
            {
                FtpWebRequest _FtpWebRequest = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("ftp://{0}/{1}/{2}", sServer, ConnectionString.FolderConnection, sDirectoryName)));
                _FtpWebRequest.UseBinary    = true;
                _FtpWebRequest.Credentials  = new NetworkCredential(sUser, sPassword);
                _FtpWebRequest.Method       = WebRequestMethods.Ftp.ListDirectory;
                _FtpWebRequest.Proxy        = null;
                _FtpWebRequest.KeepAlive    = false;
                _FtpWebRequest.UsePassive   = false;
                _WebResponse                = _FtpWebRequest.GetResponse();
                _StreamReader = new StreamReader(_WebResponse.GetResponseStream());
                string line = _StreamReader.ReadLine();
                while (line != null)
                {
                    _StringBuilder.Append(line);
                    _StringBuilder.Append("\n");
                    line = _StreamReader.ReadLine();
                }
                // to remove the trailing '\n'
                _StringBuilder.Remove(_StringBuilder.ToString().LastIndexOf('\n'), 1);
                return _StringBuilder.ToString().Split('\n').Count();
            }
            catch (Exception ex)
            {
                if (_StreamReader != null)
                    _StreamReader.Close();

                if (_WebResponse != null)
                    _WebResponse.Close();

                return 0;
            }
        }
    }
}
