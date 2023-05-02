using CapaEntidades;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CapaPresentacion
{
    public partial class Ver_Cuentas : Form
    {
        CN_Banco oCNBanco = new CN_Banco();
        CN_Cuenta oCN_Cuenta = new CN_Cuenta();
        CN_Tipo_Cuenta oCN_Tipo_Cuenta = new CN_Tipo_Cuenta();


        public Ver_Cuentas()
        {
            InitializeComponent();
        }

        private void Ver_Cuentas_Load(object sender, EventArgs e)
        {
            BuscarBanco();
            BuscarTipo_Cuenta();
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

        private void BuscarTipo_Cuenta()
        {
            CboTipo_Cuenta.DataSource = oCN_Tipo_Cuenta.BuscarTipo_Cuenta();
            CboTipo_Cuenta.DisplayMember = "nombre";
            CboTipo_Cuenta.ValueMember = "id";
            CboTipo_Cuenta.SelectedIndex = -1;
        }


        private void VerCuenta()
        {
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            DgvCuenta.DataSource = oCN_Cuenta.VerCuenta(cuenta);
        }

        private void VerCuenta2()
        {
            CE_Banco banco = new CE_Banco();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvCuenta.DataSource = oCN_Cuenta.VerCuenta2(banco);
        }

        private void VerCuenta3()
        {
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();
            CE_Banco banco = new CE_Banco();

            tpcCuenta.id = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvCuenta.DataSource = oCN_Cuenta.VerCuenta3(banco,tpcCuenta);
        }

        private void VerCuenta4()
        {
            CE_Cuenta cuenta = new CE_Cuenta();
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();
            CE_Banco banco = new CE_Banco();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            tpcCuenta.id = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvCuenta.DataSource = oCN_Cuenta.VerCuenta4(banco, tpcCuenta, cuenta);
        }

        private void VerCuenta5()
        {
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();

            tpcCuenta.id = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
            DgvCuenta.DataSource = oCN_Cuenta.VerCuenta5(tpcCuenta);
        }

        private void VisualizarCuenta()
        {
            DgvCuenta.DataSource = oCN_Cuenta.VisualizarCuenta();
        }

        private void Limpiar()
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
            CboTipo_Cuenta.SelectedIndex = -1;
        }

        #endregion



        private void CboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboCuenta.SelectedIndex = -1;
            if (CboBanco.SelectedItem != null)
            {
                if (int.TryParse(CboBanco.SelectedValue.ToString(), out int idbanco))
                {
                    BuscarCuenta(idbanco);
                }
            }
        }




        private void BtnVer_Cuenta_Click(object sender, EventArgs e)
        {
            if (CboBanco.SelectedIndex == -1 &
                CboCuenta.SelectedIndex == -1 &
                CboTipo_Cuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1 &
                CboTipo_Cuenta.SelectedIndex != -1)
            {
                VerCuenta4();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1)
            {
                VerCuenta();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 &
                    CboTipo_Cuenta.SelectedIndex != -1)
            {
                VerCuenta3();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex != -1 & 
                    CboCuenta.SelectedIndex == -1)
            {
                VerCuenta2();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else if (CboBanco.SelectedIndex == -1 &
                    CboCuenta.SelectedIndex == -1)
            {
                VerCuenta5();
                BtnExportar_Excel.Enabled = true;
                BtnExportar_PDF.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seleccione un banco");
            }
        }

        private void BtnVer_Todas_Click(object sender, EventArgs e)
        {
            VisualizarCuenta();
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

        private void BtnLimpiar_Tipo_Cuenta_Click(object sender, EventArgs e)
        {
            CboTipo_Cuenta.SelectedIndex = -1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DgvCuenta.DataSource = tabla;
            BtnExportar_Excel.Enabled = false;
            BtnExportar_PDF.Enabled = false;
        }


        //Exportar a Excel


        public void ExportarExcel(DataGridView DgvCuenta) //Exporta a excel recibiendo el datagridview de inventario como parámetro 
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();

            exportar.Application.Workbooks.Add(true);

            int Indicecolumna = 0;

            foreach (DataGridViewColumn columns in DgvCuenta.Columns)
            {
                Indicecolumna++;
                exportar.Cells[1, Indicecolumna] = columns.Name;
            }

            int Indicefila = 0;

            foreach (DataGridViewRow filas in DgvCuenta.Rows)
            {
                Indicefila++;
                Indicecolumna = 0;

                foreach (DataGridViewColumn columnas in DgvCuenta.Columns)
                {
                    Indicecolumna++;
                    exportar.Cells[Indicefila + 1, Indicecolumna] = filas.Cells[columnas.Name].Value;
                }
            }
            exportar.Visible = true;
        }


        private void BtnExportar_Excel_Click(object sender, EventArgs e)
        {
            ExportarExcel(DgvCuenta);
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

                    PdfPTable pdfptable = new PdfPTable(DgvCuenta.Columns.Count);

                    foreach (DataGridViewColumn columnas in DgvCuenta.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(columnas.HeaderText));
                        pdfptable.AddCell(cell);
                    }

                    if (DgvCuenta.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow fila in DgvCuenta.Rows)
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
