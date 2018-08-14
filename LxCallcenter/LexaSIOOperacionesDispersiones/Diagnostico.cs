using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public class Diagnostico
    {

        List<LogicaCC.LexaSIOContaLogica.Diagnostico> lComentarios;
        public void CrearDiagnostico(string sCliente)
        {
            //CREAMOS FUENTES PERSONALIZADAS
            Font fontEncabezado  = FontFactory.GetFont("Arial", 12, Font.BOLD);
            fontEncabezado.Color = BaseColor.BLACK;

            Font fontCuerpo  = FontFactory.GetFont("Segoe UI", 11, Font.NORMAL);
            fontCuerpo.Color = BaseColor.BLACK;

            // FUENTES PARA LA TABLA
            Font fontEncabezadoTabla = FontFactory.GetFont("Arial", 9, Font.NORMAL);
            fontEncabezadoTabla.Color = BaseColor.GRAY;
            Font fontPregunta = FontFactory.GetFont("Arial", 9, Font.NORMAL);
            fontPregunta.Color = BaseColor.DARK_GRAY;

            //Full path to the Unicode Arial file
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font fontVerde = new Font(bf, 9, Font.NORMAL) { Color = BaseColor.GREEN };

            Font fontRojo = new Font(bf, 9, Font.NORMAL) { Color = BaseColor.RED };

            Font fontFirma  = FontFactory.GetFont("Arial", 12, Font.UNDERLINE | Font.BOLD);
            fontFirma.Color = BaseColor.BLACK;

            Font fontPiePagina  = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 9, Font.ITALIC);
            fontPiePagina.Color = BaseColor.LIGHT_GRAY;

            //ASIGNAMOS LA RUTA DONDE SE CREARA EL ARCHIVO PDF
            string outputFile = string.Format(@"\\192.169.143.34\MiPyme_Files\Documentos\Diagnosticos\{0}.pdf", sCliente);

            //CREAMOS CONFIGURACIONES PARA EL ARCHIVO CREADO.
            using (FileStream _fileStream = new FileStream(outputFile, FileMode.Append, FileAccess.Write, FileShare.None))
            {
                //CREAMOS UN NUEVO DOCUMENTO PDF, ASIGNANDO EL TAMAÑO DE LA HOJA EN LEGAL Y EN HORIZONTAL
                using (Document _document = new Document(PageSize.LETTER, 90F, 90f, 40f, 0f))
                {
                    //ASIGNAMOS EL FILESTREAM AL DOCUMENTO USANDO EL PDFWRITER DE ITEXTSHARP
                    using (PdfWriter _pdfWriter = PdfWriter.GetInstance(_document, _fileStream))
                    {
                        //ABRIMOS EL DUCUMENTO PARA ESCRIBIRLO
                        _document.Open();

                        //IMAGEN
                        //var img         = Properties.Resources.LogoMiPyme;
                        //var _logo       = Image.GetInstance(img, BaseColor.WHITE);
                        //_logo.Alignment = Element.ALIGN_LEFT;
                        //_logo.ScalePercent(30f);
                        //_document.Add(_logo);

                        //ENCABEZADO
                        Paragraph _paragraphTitulo1 = new Paragraph() { Font = fontEncabezado, Alignment = Element.ALIGN_CENTER };
                        _paragraphTitulo1.SetLeading(30f, 1.2f);
                        _paragraphTitulo1.Add("DIAGNÓSTICO");
                        _document.Add(_paragraphTitulo1);


                        Paragraph _paragraphTitulo2 = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_LEFT };
                        _paragraphTitulo2.SetLeading(10f, 1.2f);
                        _paragraphTitulo2.Add("Cliente");
                        _document.Add(_paragraphTitulo2);

                        Paragraph _paragraphTitulo3 = new Paragraph() { Font = fontEncabezado, Alignment = Element.ALIGN_LEFT };
                        _paragraphTitulo3.SetLeading(1f, 1.2f);
                        _paragraphTitulo3.Add(sCliente);
                        _document.Add(_paragraphTitulo3);

                        Paragraph _paragraphTitulo4 = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_LEFT };
                        _paragraphTitulo4.SetLeading(7f, 1.2f);
                        _paragraphTitulo4.Add("Elaboro");
                        _document.Add(_paragraphTitulo4);

                        LogicaCC.LexaSIOContaLogica.Diagnostico elaborador = new LogicaCC.LexaSIOContaLogica.Diagnostico().Elaborador(sCliente);
                        string sElaborador = elaborador.sElaborador;
                        Paragraph _paragraphTitulo5 = new Paragraph() { Font = fontEncabezado, Alignment = Element.ALIGN_LEFT };
                        _paragraphTitulo5.SetLeading(1f, 1.2f);
                        _paragraphTitulo5.Add(sElaborador);
                        _document.Add(_paragraphTitulo5);

                        //CUERPO
                        string cuerpo = "CHECK LIST DE DIAGNÓSTICO";
                        Paragraph _paragraphCuerpo = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_JUSTIFIED };
                        _paragraphCuerpo.SetLeading(30f, 0.1f);
                        _paragraphCuerpo.Add(cuerpo);
                        _document.Add(_paragraphCuerpo);


                        PdfPTable table = new PdfPTable(7);
                        //table.DefaultCell.Border = 0;

                        //PdfPCell cell = new PdfPCell(new Phrase("Header spanning 3 columns"));
                        //cell.Colspan = 3;
                        //cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        //table.AddCell(cell);
                        //table.TotalWidth = 100;
                        //table.DefaultCell.FixedHeight = 100;
                        ////fix the absolute width of the table
                        //table.LockedWidth = true;

                        //relative col widths in proportions - 1/3 and 2/3
                        float[] widths = new float[] { 20f
                                                     , 7f
                                                     , 7f
                                                     , 7f
                                                     , 7f
                                                     , 7f
                                                     , 7f };
                        table.SetWidths(widths);
                        //table.HorizontalAlignment = 0;
                        ////leave a gap before and after the table
                        table.SpacingBefore = 20f;
                        table.SpacingAfter  = 30f;

                        PdfPCell Pregunta = new PdfPCell(new Phrase("", fontEncabezadoTabla));
                        Pregunta.UseVariableBorders = true;
                        Pregunta.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        Pregunta.BorderWidthLeft    = 0f;
                        Pregunta.BorderWidthRight   = 0f;
                        Pregunta.BorderWidthTop     = 0f;
                        Pregunta.BorderWidthBottom  = 0.5f;
                        table.AddCell(Pregunta);
                        PdfPCell EF = new PdfPCell(new Phrase("ENERO-FEBRERO", fontEncabezadoTabla));
                        EF.UseVariableBorders = true;
                        EF.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        EF.BorderWidthLeft    = 0f;
                        EF.BorderWidthRight   = 0f;
                        EF.BorderWidthTop     = 0f;
                        EF.BorderWidthBottom  = 0.5f;
                        table.AddCell(EF);
                        PdfPCell MA = new PdfPCell(new Phrase("MARZO-ABRIL", fontEncabezadoTabla));
                        MA.UseVariableBorders = true;
                        MA.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        MA.BorderWidthLeft    = 0f;
                        MA.BorderWidthRight   = 0f;
                        MA.BorderWidthTop     = 0f;
                        MA.BorderWidthBottom  = 0.5f;
                        table.AddCell(MA);
                        PdfPCell MJ = new PdfPCell(new Phrase("MAYO-JUNIO", fontEncabezadoTabla));
                        MJ.UseVariableBorders = true;
                        MJ.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        MJ.BorderWidthLeft    = 0f;
                        MJ.BorderWidthRight   = 0f;
                        MJ.BorderWidthTop     = 0f;
                        MJ.BorderWidthBottom  = 0.5f;
                        table.AddCell(MJ);
                        PdfPCell JA = new PdfPCell(new Phrase("JULIO-AGOSTO", fontEncabezadoTabla));
                        JA.UseVariableBorders = true;
                        JA.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        JA.BorderWidthLeft    = 0f;
                        JA.BorderWidthRight   = 0f;
                        JA.BorderWidthTop     = 0f;
                        JA.BorderWidthBottom  = 0.5f;
                        table.AddCell(JA);
                        PdfPCell SO = new PdfPCell(new Phrase("SEPTIEMBRE-OCTUBRE", fontEncabezadoTabla));
                        SO.UseVariableBorders = true;
                        SO.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        SO.BorderWidthLeft    = 0f;
                        SO.BorderWidthRight   = 0f;
                        SO.BorderWidthTop     = 0f;
                        SO.BorderWidthBottom  = 0.5f;
                        table.AddCell(SO);
                        PdfPCell ND = new PdfPCell(new Phrase("NOVIEMBRE-DICIEMBRE", fontEncabezadoTabla));
                        ND.UseVariableBorders = true;
                        ND.BorderColorBottom  = BaseColor.LIGHT_GRAY;
                        ND.BorderWidthLeft    = 0f;
                        ND.BorderWidthRight   = 0f;
                        ND.BorderWidthTop     = 0f;
                        ND.BorderWidthBottom  = 0.5f;
                        table.AddCell(ND);

                        //using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.LXCCConnectionString))
                        using (SqlConnection conn = new SqlConnection(LogicaCC.ConnectionString.DbMPY))
                        {
                            SqlCommand cmd = new SqlCommand("MPYCCSPS_DIAGNOSTICO_PREGUNTAS", conn) { CommandType = CommandType.StoredProcedure };
                            cmd.Parameters.Add("@Cliente", SqlDbType.NVarChar, 50).Value = sCliente;
                            try
                            {
                                conn.Open();
                                using (SqlDataReader rdr = cmd.ExecuteReader())
                                {
                                    while (rdr.Read())
                                    {
                                        PdfPCell CellPreguntas = new PdfPCell(new Phrase(rdr[0].ToString(), fontPregunta));
                                        CellPreguntas.BackgroundColor = BaseColor.BLACK;
                                        CellPreguntas.BorderColorBottom = BaseColor.LIGHT_GRAY;
                                        CellPreguntas.BorderWidthLeft   = 0f;
                                        CellPreguntas.BorderWidthRight  = 0f;
                                        CellPreguntas.BorderWidthTop    = 0f;
                                        CellPreguntas.BorderWidthBottom = 0.5f;
                                        table.AddCell(CellPreguntas);

                                        PdfPCell REF = new PdfPCell(int.Parse(rdr[1].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        REF.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        REF.BorderWidthLeft     = 0f;
                                        REF.BorderWidthRight    = 0f;
                                        REF.BorderWidthTop      = 0f;
                                        REF.BorderWidthBottom   = 0.5f;
                                        REF.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(REF);

                                        PdfPCell RMA = new PdfPCell(int.Parse(rdr[2].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        RMA.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        RMA.BorderWidthLeft     = 0f;
                                        RMA.BorderWidthRight    = 0f;
                                        RMA.BorderWidthTop      = 0f;
                                        RMA.BorderWidthBottom   = 0.5f;
                                        RMA.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(RMA);

                                        PdfPCell RMJ = new PdfPCell(int.Parse(rdr[3].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        RMJ.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        RMJ.BorderWidthLeft     = 0f;
                                        RMJ.BorderWidthRight    = 0f;
                                        RMJ.BorderWidthTop      = 0f;
                                        RMJ.BorderWidthBottom   = 0.5f;
                                        RMJ.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(RMJ);

                                        PdfPCell RJA = new PdfPCell(int.Parse(rdr[4].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        RJA.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        RJA.BorderWidthLeft     = 0f;
                                        RJA.BorderWidthRight    = 0f;
                                        RJA.BorderWidthTop      = 0f;
                                        RJA.BorderWidthBottom   = 0.5f;
                                        RJA.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(RJA);

                                        PdfPCell RSO = new PdfPCell(int.Parse(rdr[5].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        RSO.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        RSO.BorderWidthLeft     = 0f;
                                        RSO.BorderWidthRight    = 0f;
                                        RSO.BorderWidthTop      = 0f;
                                        RSO.BorderWidthBottom   = 0.5f;
                                        RSO.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(RSO);

                                        PdfPCell RND = new PdfPCell(int.Parse(rdr[6].ToString()) > 0 ? new Phrase("✓", fontVerde) : new Phrase("✕", fontRojo));
                                        RND.BorderColorBottom   = BaseColor.LIGHT_GRAY;
                                        RND.BorderWidthLeft     = 0f;
                                        RND.BorderWidthRight    = 0f;
                                        RND.BorderWidthTop      = 0f;
                                        RND.BorderWidthBottom   = 0.5f;
                                        RND.HorizontalAlignment = Element.ALIGN_CENTER;
                                        table.AddCell(RND);
                                    }
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        _document.Add(table);

                        // COMENTARIOS
                        Paragraph _paragraphComentarios = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_JUSTIFIED };
                        _paragraphComentarios.SetLeading(15f, 0.1f);
                        _paragraphComentarios.Add("COMENTARIOS DEL DIAGNÓSTICO");
                        _document.Add(_paragraphComentarios);

                        string separador = "------------------------------------------------------------------------------------------------------------------------------------------------";
                        LogicaCC.LexaSIOContaLogica.Diagnostico comentario = new LogicaCC.LexaSIOContaLogica.Diagnostico();
                        lComentarios = comentario.lComentarios(sCliente);
                        foreach (var c in lComentarios)
                        {
                            
                            string pregunta                 = c.sComentario;
                            Paragraph _paragraphPregunta    = new Paragraph() { Font = fontEncabezadoTabla, Alignment = Element.ALIGN_JUSTIFIED };
                            _paragraphPregunta.SetLeading(20f, 0.1f);
                            _paragraphPregunta.Add(pregunta);
                            _document.Add(_paragraphPregunta);

                            string respuesta                = c.sComentarioRespuesa;
                            Paragraph _paragraphRespuesta   = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_JUSTIFIED };
                            _paragraphRespuesta.SetLeading(15f, 0.1f);
                            _paragraphRespuesta.Add(respuesta);
                            _document.Add(_paragraphRespuesta);

                            Paragraph _paragraphSeparador   = new Paragraph() { Font = fontPiePagina, Alignment = Element.ALIGN_CENTER };
                            _paragraphSeparador.Add(separador);
                            _document.Add(_paragraphSeparador);
                        }

                        // COMENTARIOS FINALES DEL DIAGNÓSTICO Y SOLUCIONES RECOMENDADAS (PROPUESTAS)
                        lComentarios = comentario.lComentarioFinal(sCliente);
                        foreach (var c in lComentarios)
                        {
                            string comentarioTitulo                 = c.sComentario;
                            Paragraph _paragraphComentarioTitulo    = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_JUSTIFIED };
                            _paragraphComentarioTitulo.SetLeading(30f, 0.1f);
                            _paragraphComentarioTitulo.Add(comentarioTitulo);
                            _document.Add(_paragraphComentarioTitulo);

                            string comentarioRespuesta              = c.sComentarioFinal;
                            Paragraph _paragraphComentarioRespuesta = new Paragraph() { Font = fontCuerpo, Alignment = Element.ALIGN_JUSTIFIED };
                            _paragraphComentarioRespuesta.SetLeading(15f, 0.1f);
                            _paragraphComentarioRespuesta.Add(comentarioRespuesta);
                            _document.Add(_paragraphComentarioRespuesta);

                            Paragraph _paragraphSeparadorF = new Paragraph() { Font = fontPiePagina, Alignment = Element.ALIGN_CENTER };
                            _paragraphSeparadorF.Add(separador);
                            _document.Add(_paragraphSeparadorF);
                        }

                        //CERRAMOS EL DOCUMENTO
                        _document.Close();
                    }
                }
            }

        }


    }
}
