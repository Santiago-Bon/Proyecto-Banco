using CapaEntidades;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Ver_Movimientos : Form
    {
        CN_Banco oCNBanco = new CN_Banco();
        CN_Cuenta oCN_Cuenta = new CN_Cuenta();
        CN_Movimiento oCN_Movimiento = new CN_Movimiento();
        CN_Tipo_Movimiento oCN_Tipo_Movimiento = new CN_Tipo_Movimiento();

        public Ver_Movimientos()
        {
            InitializeComponent();
        }

        private void Ver_Movimientos_Load(object sender, EventArgs e)
        {
            BuscarBanco();
            BuscarTipo_Movimiento();
            BtnExportar_Excel.Enabled = false;
            BtnExportar_PDF.Enabled = false;
        }



        #region Mis métodos

        private void BuscarBanco()
        {
            CboBanco.DataSource = oCNBanco.BuscarBanco();
            CboBanco.DisplayMember = "nombre";
            CboBanco.ValueMember = "id";
            CboBanco.SelectedIndex = -1;
        }


        private void BuscarCuenta(int idbanco)
        {
            CboCuenta.DataSource = oCN_Cuenta.BuscarCuenta(idbanco);
            CboCuenta.DisplayMember = "nombre";
            CboCuenta.ValueMember = "numero";
            CboCuenta.SelectedIndex = -1;
        }


        private void BuscarTipo_Movimiento()
        {
            CboTipo_Movimiento.DataSource = oCN_Tipo_Movimiento.BuscarTipo_Movimiento();
            CboTipo_Movimiento.DisplayMember = "nombre";
            CboTipo_Movimiento.ValueMember = "id";
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        private void VerMovimiento()
        {
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            DgvMovimientos.DataSource = oCN_Movimiento.VerMovimientos(cuenta);
        }

        private void VerMovimiento2()
        {
            CE_Banco banco = new CE_Banco();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvMovimientos.DataSource = oCN_Movimiento.VerMovimientos2(banco);
        }

        private void VerMovimiento3()
        {
            CE_Banco banco = new CE_Banco();
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvMovimientos.DataSource = oCN_Movimiento.VerMovimientos3(tpmMov,banco);
        }

        private void VerMovimiento4()
        {
            CE_Banco banco = new CE_Banco();
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvMovimientos.DataSource = oCN_Movimiento.VerMovimientos4(tpmMov, banco, cuenta);
        }

        private void VerMovimiento5()
        {
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();

            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvMovimientos.DataSource = oCN_Movimiento.VerMovimientos5(tpmMov);
        }

        private void VisualizarMovimientos()
        {
            DgvMovimientos.DataSource = oCN_Movimiento.VisualizarMovimientos();
        }

        private void Limpiar()
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
            CboTipo_Movimiento.SelectedIndex = -1;
        }        

        #endregion



        private void CboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboBanco.SelectedItem != null)
            {
                if (int.TryParse(CboBanco.SelectedValue.ToString(), out int idbanco))
                {
                    BuscarCuenta(idbanco);
                }
            }
        }


        private void BtnVer_Movimiento_Click_1(object sender, EventArgs e)
        {
            if (CboBanco.SelectedIndex == -1 &
                CboCuenta.SelectedIndex == -1 &
                CboTipo_Movimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1 &
                CboTipo_Movimiento.SelectedIndex != -1)
            {
                VerMovimiento4();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1)
            {
                VerMovimiento();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboTipo_Movimiento.SelectedIndex != -1)
            {
                VerMovimiento3();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex == -1)
            {
                VerMovimiento2();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex == -1 &
                 CboCuenta.SelectedIndex == -1)
            {
                VerMovimiento5();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un banco");
            }
        }

        private void BtnVer_Todos_Click(object sender, EventArgs e)
        {
            VisualizarMovimientos();
            BtnExportar_Excel.Enabled = true;
            BtnExportar_PDF.Enabled = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnLimpiar_Banco_Click(object sender, EventArgs e)
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
        }

        private void BtnLimpiar_Cuenta_Click(object sender, EventArgs e)
        {
            CboCuenta.SelectedIndex = -1;
        }

        private void BtnLimpiar_Tipo_Movimiento_Click(object sender, EventArgs e)
        {
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DgvMovimientos.DataSource = tabla;
            BtnExportar_Excel.Enabled = false;
            BtnExportar_PDF.Enabled = false;
        }


        //Exportar a Excel


        public void ExportarExcel(DataGridView DgvMovimientos) //Exporta a excel recibiendo el datagridview de inventario como parámetro 
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();

            exportar.Application.Workbooks.Add(true);

            int Indicecolumna = 0;

            foreach (DataGridViewColumn columns in DgvMovimientos.Columns)
            {
                Indicecolumna++;
                exportar.Cells[1, Indicecolumna] = columns.Name;
            }

            int Indicefila = 0;

            foreach (DataGridViewRow filas in DgvMovimientos.Rows)
            {
                Indicefila++;
                Indicecolumna = 0;

                foreach (DataGridViewColumn columnas in DgvMovimientos.Columns)
                {
                    Indicecolumna++;
                    exportar.Cells[Indicefila + 1, Indicecolumna] = filas.Cells[columnas.Name].Value;
                }
            }
            exportar.Visible = true;
        }


        private void BtnExportar_Excel_Click(object sender, EventArgs e)
        {
            ExportarExcel(DgvMovimientos);
        }


        //Exportar a PDF


        private void BtnExportar_PDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog(); //Se crea un objeto de tipo savefiledialog
            string ruta = string.Empty;

            guardar.Filter = "Archivo pdf (*.pdf)|*.pdf"; //Se filtra por pdf
            guardar.Title = "Guardar";

            if (guardar.ShowDialog() == DialogResult.OK) //Si la respuesta del savefiledialog abierto es igual a ok
            {
                ruta = guardar.FileName; //Se guarda la ruta en una variable

                FileStream filestream = new FileStream(ruta, FileMode.Create);
                {
                    Document documento = new Document(PageSize.A4);
                    PdfWriter pdfwriter = PdfWriter.GetInstance(documento, filestream);
                    documento.Open();

                    PdfPTable pdfptable = new PdfPTable(DgvMovimientos.Columns.Count);

                    foreach (DataGridViewColumn columnas in DgvMovimientos.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(columnas.HeaderText));
                        pdfptable.AddCell(cell);
                    }

                    if (DgvMovimientos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow fila in DgvMovimientos.Rows)
                        {
                            foreach (DataGridViewCell celdas in fila.Cells)
                            {
                                pdfptable.AddCell(celdas.Value?.ToString() ?? "");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar al pdf");
                    }
                    documento.Add(pdfptable);
                    documento.Close();
                }
            }
        }
    }
}
