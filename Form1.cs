using Aspose.Cells;
using Aspose.Cells.Drawing;
using Aspose.Cells.Tables;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Excel;


//using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Data;
using System.Windows.Forms;
using Cell = Aspose.Cells.Cell;
using Path = System.IO.Path;
using Row = Aspose.Cells.Row;
using TableStyleType = Aspose.Cells.Tables.TableStyleType;
using Workbook = Aspose.Cells.Workbook;
using Worksheet = Aspose.Cells.Worksheet;

namespace ReporteImpresoras
{
    public partial class VentanaPrincipal : Form
    {
        public string rutaExcelByN;
        int totalBNUsers = 0;

        //Tablas que guardan los registros a mostrar en las hojas de excel
        DataTable tablaDN1 = null;
        DataTable tablaDN2 = null;
        DataTable tablaTI = null;
        DataTable tablaRH = null;
        DataTable tablaAuditoria = null;
        DataTable tablaComercio = null;
        DataTable tablaContraloria = null;
        DataTable tablaDirG = null;
        DataTable tablaLegal = null;
        DataTable tablaPlaneacion = null;
        DataTable tablaSOX = null;
        DataTable totalesBN = null;

        //lista de nombres de usuarios y total de impresiones separados por area
        List<string> listaAreas = new List<string>();
        List<int> listaTotalesBN = new List<int>();

        List<string> listaDN1 = new List<string>();
        List<int> ListaTotalDN1 = new List<int>();

        List<string> listaDN2 = new List<string>();
        List<int> listatotalDN2 = new List<int>();

        List<string> listaTI = new List<string>();
        List<int> listatotalTI = new List<int>();

        List<string> listaRH = new List<string>();
        List<int> listatotalRH = new List<int>();

        List<string> listaAuditoria = new List<string>();
        List<int> listatotalAud = new List<int>();

        List<string> listaComercio = new List<string>();
        List<int> listatotalComer = new List<int>();

        List<string> listaContraloria = new List<string>();
        List<int> listatotalContra = new List<int>();

        List<string> listaDirG = new List<string>();
        List<int> listaTotalDirG = new List<int>();

        List<string> listaLegal = new List<string>();
        List<int> listatotalLegal = new List<int>();

        List<string> listaPlaneacion = new List<string>();
        List<int> listatotalPlaneacion = new List<int>();

        List<string> listaSOX = new List<string>();
        List<int> listatotalSOX = new List<int>();

        //contadores de numero de usuarios encontrados por cada area
        int conDN1 = 0;
        int conDN2 = 0;
        int conTI = 0;
        int conRH = 0;
        int conAudit = 0;
        int conComer = 0;
        int conContra = 0;
        int conDir = 0;
        int conLegal = 0;
        int conPlanea = 0;
        int conSOX = 0;

        //Contadores de total de impresiones por cada area
        int totalDN1 = 0;
        int totalDN2 = 0;
        int totalTI = 0;
        int totalRH = 0;
        int totalAuditoria = 0;
        int totalComercio = 0;
        int totalContraloria = 0;
        int totalDirG = 0;
        int totalLegal = 0;
        int totalPlaneacion = 0;
        int totalSOX = 0;
        public VentanaPrincipal()
        {
            InitializeComponent();
            cargaAnioMes();
            //Resultados_Load();
            //dataGridView1.DataSource = leerExcel();
        }

        private void cargaAnioMes()
        {
            int contAnios = -1;
            int AnioInic = 2015;
            DateTime dtNow = DateTime.Now;
            int intAnio = Convert.ToInt32(dtNow.ToString("yyyy"));
            int intMes = Convert.ToInt32(dtNow.ToString("MM"));
            for (int i = AnioInic; i <= intAnio; i++)
            {
                cmbAnios.Items.Add(i.ToString());
                contAnios++;
            }
            if (intMes != 1) 
            {
                cmbMeses.SelectedIndex = intMes - 2;
                cmbAnios.SelectedIndex = contAnios;
            }
            else
            {
                cmbMeses.SelectedIndex = 11;
                cmbAnios.SelectedIndex = contAnios-1;
            }


        }//RH, contraloria, Direccion general (Nombre de las impresoras independientes)

        private void btnSelecBN_Click(object sender, EventArgs e)
        {
            DateTime date1;
            string date2;
            string rutaCSV_Ex;
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm";

            //Seleccionar reporte csv o excel
            if (file1.ShowDialog() == DialogResult.OK)
            {
                rutaCSV_Ex = file1.FileName;
                string ext = Path.GetExtension(rutaCSV_Ex);

                if (ext == ".csv")
                {
                    //Crear la ruta donde se convierten los archivos csv a excel
                    string path = @"C:\Conversiones ReportesImp";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    //Convertir archivos csv a excel y guardarlos en la ruta creada
                    var wb = new Workbook(rutaCSV_Ex);


                    Worksheet sheet1 = wb.Worksheets[0];

                    //int index = wb.Worksheets.Add();
                    //Aspose.Cells.Worksheet sheet2 = wb.Worksheets[index];
                    //sheet2.Name = "Reporte";
                    int cols = sheet1.Cells.MaxDataColumn;
                    int inrRows = sheet1.Cells.MaxDataRow;
                    int contadorColumnas = 0;

                    Row row = sheet1.Cells.Rows[0];

                    foreach (Cell c in sheet1.Cells.Rows[0])
                    {
                        //int rows = sheet1.Cells.MaxDataColumn;
                        int columnIndex = c.Column;
                        string prue = c.StringValue;
                        /*Console.WriteLine("Columna "+ contadorColumnas+ ": " +prue);
                        if (c.StringValue == "ID trabajo cuenta")
                        {
                            Console.WriteLine("Si encuentra la columna");
                        }*/
                        if (c.StringValue == "Modo Trabajo" || c.StringValue == "Nombre Usuario" || c.StringValue == "Fecha y Hora de Comienzo" || c.StringValue == "Con. Total de Blanco y Negro" || c.StringValue == "Nombre Archivo")
                        {

                            sheet1.Cells.CopyColumn(sheet1.Cells, columnIndex, contadorColumnas);

                            contadorColumnas++;
                        }

                    }
                    sheet1.Cells.DeleteColumns(5, cols, true);
                    sheet1.AutoFitColumns(0, contadorColumnas);


                    date1 = DateTime.Now;
                    date2 = date1.ToString("yyyyMMdd_HHmm");
                    string rutaConversion = @"C:\Conversiones ReportesImp\ReporteImpB&N_" + date2 + ".xlsx";
                    wb.Save(rutaConversion);

                    //string rutaConversion2 = @"C:\Conversiones ReportesImp\ReporteImp_" + date2 + "_COPIA.xlsx";
                    //wb2.Save(rutaConversion);
                    //sheet.Cells.DeleteColumn(0);
                    //sheet.Cells.DeleteColumn(0);
                    //wb.Worksheets.RemoveAt(1);


                    rutaExcelByN = rutaConversion;

                }
                txtRutaBN.Text = rutaExcelByN;

                //leerExcel();
            }
        }

        private void btnGenerarRepor_Click(object sender, EventArgs e)
        {
            GenerarExcel();        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resultados_Load()
        {
            string strConection = "datasource=172.25.115.134 ; port=3306; username=root; password=n0m3l0; database=oma;";
            MySqlConnection sqlConexion = null;
            DataTable tbl1 = new DataTable();
            try
            {
                sqlConexion = new MySqlConnection(strConection);

                sqlConexion.Open();
                Console.WriteLine("ÉXITO");
                string sqlCon = "select Correo, Nombre, Puesto, area_idarea as ID_Area from empleado;";
                MySqlDataAdapter com = new MySqlDataAdapter(sqlCon, sqlConexion);// where Area_idarea = 3
                com.Fill(tbl1);
                dataGridView1.DataSource = tbl1;
                sqlConexion.Close();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
                MessageBox.Show("No se logró hacer conexión a la base, inténtelo más tarde");
            }
        }

        private MySqlConnection getConection()
        {
            //Tamaño del form 1063, 969

            //Creacion de la conexion a la base 
            string strConection = "datasource=172.25.115.134 ; port=3306; username=root; password=n0m3l0; database=oma;";
            MySqlConnection sqlConexion = null;
            try
            {
                sqlConexion = new MySqlConnection(strConection);

                /*sqlConexion.Open();
                Console.WriteLine("ÉXITO");
                DataTable tbl = new DataTable();
                string sqlCon = "select Correo, Nombre, Puesto, area_idarea from empleado;";
                MySqlDataAdapter com = new MySqlDataAdapter(sqlCon, sqlConexion);// where Area_idarea = 3
                com.Fill(tbl);
                dataGridView1.DataSource = tbl;
                sqlConexion.Close();*/
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("ERROR: "+ ex);
                MessageBox.Show("No se logró hacer conexión a la base, inténtelo más tarde");    
            }
            return sqlConexion;
        }

        public DataTable leerExcel()
        {
            string rutaprueba = @"C:\Conversiones ReportesImp\ReporteImpB&N_20240513_1750.xlsx";//ReporteImpB&N_20240513_1750.xlsx";
            DataTable dt = new DataTable();
            try
            {
                //Abrimos el archivo de excel que se genero desde la impresora b&n
                FileStream fstream = new FileStream(rutaprueba, FileMode.Open);
                Workbook wb = new Workbook(fstream);
                Worksheet ws = wb.Worksheets[0];//worksheet.Cells[i, j].Value

                int rows = ws.Cells.MaxDataRow;
                int cols = ws.Cells.MaxDataColumn;
                int contCols = 0;

                //var 
                DataRow row;
                DataColumn column;
                MySqlConnection sqlConexion;
                sqlConexion = getConection();
                totalBNUsers = 0;   
                totalesBN = new DataTable();//Se inicializa la tabla totalBN

                tablaDN1 = new DataTable();
                tablaDN2 = new DataTable();
                tablaTI = new DataTable();
                tablaRH = new DataTable();
                tablaAuditoria = new DataTable();
                tablaComercio = new DataTable();
                tablaContraloria = new DataTable();
                tablaDirG = new DataTable();
                tablaLegal = new DataTable();
                tablaPlaneacion = new DataTable();
                tablaSOX = new DataTable();

                totalDN1 = 0;
                totalDN2 = 0;
                totalTI = 0;
                totalRH = 0;
                totalAuditoria = 0;
                totalComercio = 0;
                totalContraloria = 0;
                totalDirG = 0;
                totalLegal = 0;
                totalPlaneacion = 0;
                totalSOX = 0;

                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        //row = dt.NewRow();
                        contCols = 0;
                        foreach (Cell c in ws.Cells.Rows[i])
                        {
                            //Se añade las nuevas columnas con los titulos del excel leido
                            String ColumnName = (string)c.Value;
                            if (contCols != 3)
                            {
                                dt.Columns.Add(ColumnName, typeof(String));
                            }
                            else
                            {
                                dt.Columns.Add(ColumnName, typeof(Int32));
                            }
                            

                            contCols++;
                        }
                        column = new DataColumn();
                        column.DataType = Type.GetType("System.String");
                        column.ColumnName = "Direccion";
                        dt.Columns.Add(column);
                        //dt.Rows.Add(row);
                    }
                    else
                    {
                        //Obtenemos la celda de hojas imprimidas para validar que no este en 0
                        int ConTotal = Convert.ToInt32(ws.Cells[i, 3].Value);
                        string nombreUsuario1 = ws.Cells[i, 1].Value.ToString();

                        //Obtenemos el año y mes de cada fila recorrida
                        string strFecha = ws.Cells[i, 2].Value.ToString();
                        string año = strFecha.Substring(0, 4);
                        //el artur estuvo aqui xd
                        int mes = Convert.ToInt32(strFecha.Substring(5, 2));
                        int hora = Convert.ToInt32(strFecha.Substring(11, 2));

                        //obtenemos el valor del mes y año seleccionados
                        int mesSelec = (cmbMeses.SelectedIndex) + 1;//Se suma 1 ya que el index empieza a partir de 0
                        int proir = cmbAnios.SelectedIndex;
                        string anioSelec = Convert.ToString(cmbAnios.SelectedItem);
                        
                        //filtramos solo las celdas con el mes y año especificado
                        if (ws.Cells[i, 0].Value.ToString() != "Escanear a E-mail" && mesSelec == mes && anioSelec == año  && ConTotal != 0)//&& ws.Cells[i, 1].Value.ToString() == "raguilar"
                        {
                            //Hacemos cunsulta del area de cada usuario para añadirlo a la tabla
                            string nombreUsuario = ws.Cells[i, 1].Value.ToString();
                            sqlConexion.Open();
                            string sqlCon = "select a.nombre from empleado e, area a where e.Area_idArea = a.idArea and e.correo like '" + nombreUsuario + "%';";
                            MySqlCommand com = new MySqlCommand(sqlCon, sqlConexion);
                            var reader = com.ExecuteReader();
                            string area = "";
                            while (reader.Read())
                            {
                                area = reader["nombre"].ToString();
                            }//

                            //Creacion de fila por cada registro y lo añadimos a la tabla dt
                            row = dt.NewRow();
                            contCols = 0;
                            //Se añade cada columna a la fila
                            foreach (Cell c in ws.Cells.Rows[i])
                            {
                                row[contCols] = c.Value;
                                contCols++;
                            }
                            row[5] = area;//Se agrega el area del usuario en la columna 5
                            dt.Rows.Add(row);
                            totalBNUsers++;
                            sqlConexion.Close();//Se cierra la conexion a mysql


                            int totalUsuario = 0;
                            //Se suman los totales de impresiones respecto a cada area para la hoja de totales para la hoja total
                            if (area == "DN1") 
                            {
                                totalDN1 += ConTotal;

                                //agregamos el total de por usuario
                                if(!listaDN1.Contains(nombreUsuario1))
                                {
                                    listaDN1.Add(nombreUsuario1); 
                                    ListaTotalDN1.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaDN1.IndexOf(nombreUsuario1);
                                    int suma = ListaTotalDN1[index];
                                    ListaTotalDN1[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "DN2")
                            {
                                totalDN2 += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaDN2.Contains(nombreUsuario1))
                                {
                                    listaDN2.Add(nombreUsuario1);
                                    listatotalDN2.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaDN2.IndexOf(nombreUsuario1);
                                    int suma = listatotalDN2[index];
                                    listatotalDN2[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "TI")
                            {
                                totalTI += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaTI.Contains(nombreUsuario1))
                                {
                                    listaTI.Add(nombreUsuario1);
                                    listatotalTI.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaTI.IndexOf(nombreUsuario1);
                                    int suma = listatotalTI[index];
                                    listatotalTI[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "RH")
                            {
                                totalRH += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaRH.Contains(nombreUsuario1))
                                {
                                    listaRH.Add(nombreUsuario1);
                                    listatotalRH.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaRH.IndexOf(nombreUsuario1);
                                    int suma = listatotalRH[index];
                                    listatotalRH[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "AUDITORIA")
                            {
                                totalAuditoria += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaAuditoria.Contains(nombreUsuario1))
                                {
                                    listaAuditoria.Add(nombreUsuario1);
                                    listatotalAud.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaAuditoria.IndexOf(nombreUsuario1);
                                    int suma = listatotalAud[index];
                                    listatotalAud[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "COMERCIO")
                            {
                                totalComercio += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaComercio.Contains(nombreUsuario1))
                                {
                                    listaComercio.Add(nombreUsuario1);
                                    listatotalComer.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaComercio.IndexOf(nombreUsuario1);
                                    int suma = listatotalComer[index];
                                    listatotalComer[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "CONTRALORIA")
                            {
                                totalContraloria += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaContraloria.Contains(nombreUsuario1))
                                {
                                    listaContraloria.Add(nombreUsuario1);
                                    listatotalContra.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaContraloria.IndexOf(nombreUsuario1);
                                    int suma = listatotalContra[index];
                                    listatotalContra[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "DIR.GRAL.")
                            {
                                totalDirG += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaDirG.Contains(nombreUsuario1))
                                {
                                    listaDirG.Add(nombreUsuario1);
                                    listaTotalDirG.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaDirG.IndexOf(nombreUsuario1);
                                    int suma = listaTotalDirG[index];
                                    listaTotalDirG[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "LEGAL")
                            {
                                totalLegal += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaLegal.Contains(nombreUsuario1))
                                {
                                    listaLegal.Add(nombreUsuario1);
                                    listatotalLegal.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaLegal.IndexOf(nombreUsuario1);
                                    int suma = listatotalLegal[index];
                                    listatotalLegal[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "PLANEACION")
                            {
                                totalPlaneacion += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaPlaneacion.Contains(nombreUsuario1))
                                {
                                    listaPlaneacion.Add(nombreUsuario1);
                                    listatotalPlaneacion.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaPlaneacion.IndexOf(nombreUsuario1);
                                    int suma = listatotalPlaneacion[index];
                                    listatotalPlaneacion[index] = suma + ConTotal;
                                }
                            }
                            else if (area == "SOX")
                            {
                                totalSOX += ConTotal;

                                //agregamos el total de por usuario
                                if (!listaSOX.Contains(nombreUsuario1))
                                {
                                    listaSOX.Add(nombreUsuario1);
                                    listatotalSOX.Add(ConTotal);
                                }
                                else
                                {
                                    int index = listaSOX.IndexOf(nombreUsuario1);
                                    int suma = listatotalSOX[index];
                                    listatotalSOX[index] = suma + ConTotal;
                                }
                            }

                        }
                        
                    }
                    
                    
                }

                conDN1 = listaDN1.Count;
                conDN2 = listaDN2.Count;
                conTI = listaTI.Count;
                conRH = listaRH.Count;
                conAudit = listaAuditoria.Count;
                conComer = listaComercio.Count;
                conContra = listaContraloria.Count;
                conDir = listaDirG.Count;
                conLegal = listaLegal.Count;
                conPlanea = listaPlaneacion.Count;
                conSOX = listaSOX.Count;

                //se agregan los totales a la lista totalesBN
                listaTotalesBN.Add(totalDN1);
                listaTotalesBN.Add(totalDN2);
                listaTotalesBN.Add(totalTI);
                listaTotalesBN.Add(totalRH);
                listaTotalesBN.Add(totalAuditoria);
                listaTotalesBN.Add(totalComercio);
                listaTotalesBN.Add(totalContraloria);
                listaTotalesBN.Add(totalDirG);
                listaTotalesBN.Add(totalLegal);
                listaTotalesBN.Add(totalPlaneacion);
                listaTotalesBN.Add(totalSOX);

                //Se agregan las areas a la lista areas
                listaAreas.Add("DN1");
                listaAreas.Add("DN2");
                listaAreas.Add("TI");
                listaAreas.Add("RH");
                listaAreas.Add("AUDITORIA");
                listaAreas.Add("COMERCIO");
                listaAreas.Add("CONTRALORIA");
                listaAreas.Add("DIR GRAL");
                listaAreas.Add("LEGAL");
                listaAreas.Add("PLANEACION");
                listaAreas.Add("SOX");


                //Llenamos la table de totalesBN
                //se agregan las columnas
                totalesBN.Columns.Add("Area", typeof(String));
                totalesBN.Columns.Add("Total B&N", typeof(Int32));

                tablaDN1.Columns.Add("Usuario", typeof(String));
                tablaDN1.Columns.Add("Total", typeof(Int32));

                tablaDN2.Columns.Add("Usuario", typeof(String));
                tablaDN2.Columns.Add("Total", typeof(Int32));

                tablaTI.Columns.Add("Usuario", typeof(String));
                tablaTI.Columns.Add("Total", typeof(Int32));

                tablaRH.Columns.Add("Usuario", typeof(String));
                tablaRH.Columns.Add("Total", typeof(Int32));

                tablaAuditoria.Columns.Add("Usuario", typeof(String));
                tablaAuditoria.Columns.Add("Total", typeof(Int32));

                tablaComercio.Columns.Add("Usuario", typeof(String));
                tablaComercio.Columns.Add("Total", typeof(Int32));

                tablaContraloria.Columns.Add("Usuario", typeof(String));
                tablaContraloria.Columns.Add("Total", typeof(Int32));

                tablaDirG.Columns.Add("Usuario", typeof(String));
                tablaDirG.Columns.Add("Total", typeof(Int32));

                tablaLegal.Columns.Add("Usuario", typeof(String));
                tablaLegal.Columns.Add("Total", typeof(Int32));

                tablaPlaneacion.Columns.Add("Usuario", typeof(String));
                tablaPlaneacion.Columns.Add("Total", typeof(Int32));

                tablaSOX.Columns.Add("Usuario", typeof(String));
                tablaSOX.Columns.Add("Total", typeof(Int32));


                DataRow filaTotal;
                DataRow filadn1;
                int recorreLista = 0;

                int TotalAreas = 0;

                //Se agregan los datos de las filas para cada una de las tablas
                for (int i = 0; i < 11; i++)
                {
                    string area = listaAreas[i];
                    int total = listaTotalesBN[i];

                    filaTotal = totalesBN.NewRow();
                    filaTotal[0] = area;
                    filaTotal[1] = total;
                    TotalAreas += total;

                    totalesBN.Rows.Add(filaTotal);  
                }
                filaTotal = totalesBN.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = TotalAreas;
                totalesBN.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDN1; i++)
                {
                    string nombre = listaDN1[i];
                    int total = ListaTotalDN1[i];

                    filadn1 = tablaDN1.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaDN1.Rows.Add(filadn1);
                }
                filaTotal = tablaDN1.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDN1;
                tablaDN1.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDN2; i++)
                {
                    string nombre = listaDN2[i];
                    int total = listatotalDN2[i];

                    filadn1 = tablaDN2.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaDN2.Rows.Add(filadn1);
                }
                filaTotal = tablaDN2.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDN2;
                tablaDN2.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conTI; i++)
                {
                    string nombre = listaTI[i];
                    int total = listatotalTI[i];

                    filadn1 = tablaTI.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaTI.Rows.Add(filadn1);
                }
                filaTotal = tablaTI.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalTI;
                tablaTI.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conRH; i++)
                {
                    string nombre = listaRH[i];
                    int total = listatotalRH[i];

                    filadn1 = tablaRH.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaRH.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaRH.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalRH;
                tablaRH.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conAudit; i++)
                {
                    string nombre = listaAuditoria[i];
                    int total = listatotalAud[i];

                    filadn1 = tablaAuditoria.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaAuditoria.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaAuditoria.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalAuditoria;
                tablaAuditoria.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conComer; i++)
                {
                    string nombre = listaComercio[i];
                    int total = listatotalComer[i];

                    filadn1 = tablaComercio.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaComercio.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaComercio.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalComercio;
                tablaComercio.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conContra; i++)
                {
                    string nombre = listaContraloria[i];
                    int total = listatotalContra[i];

                    filadn1 = tablaContraloria.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaContraloria.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaContraloria.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalContraloria;
                tablaContraloria.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDir; i++)
                {
                    string nombre = listaDirG[i];
                    int total = listaTotalDirG[i];

                    filadn1 = tablaDirG.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaDirG.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaDirG.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDirG;
                tablaDirG.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conLegal; i++)
                {
                    string nombre = listaLegal[i];
                    int total = listatotalLegal[i];

                    filadn1 = tablaLegal.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaLegal.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaLegal.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalLegal;
                tablaLegal.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conPlanea; i++)
                {
                    string nombre = listaPlaneacion[i];
                    int total = listatotalPlaneacion[i];

                    filadn1 = tablaPlaneacion.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaPlaneacion.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaPlaneacion.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalPlaneacion;
                tablaPlaneacion.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conSOX; i++)
                {
                    string nombre = listaSOX[i];
                    int total = listatotalSOX[i];

                    filadn1 = tablaSOX.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;

                    tablaSOX.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaSOX.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalSOX;
                tablaSOX.Rows.Add(filaTotal);


                fstream.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }


        private void GenerarExcel()
        {
            try
            {
                string GetMes = cmbMeses.Text;
                int GetAnio = Convert.ToInt32(cmbAnios.Text);
                DataTable dt = leerExcel();

                ImportTableOptions importOptions1 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions2 = new ImportTableOptions();//Opciones para importar la tabla al excel

                ImportTableOptions importOptions3 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions4 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions5 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions6 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions7 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions8 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions9 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions10 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions11 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions12 = new ImportTableOptions();//Opciones para importar la tabla al excel
                ImportTableOptions importOptions13 = new ImportTableOptions();//Opciones para importar la tabla al excel





                var libro1 = new Workbook();//Creamos un nuevo libro de excel
                Worksheet hojaGeneral = libro1.Worksheets[0];//Se agrega primera hoja(General)
                hojaGeneral.Name = "General";

                //Creacion de las hojas correspondientes para cada area
                Worksheet hojaTotal = libro1.Worksheets.Add("Total");

                Worksheet hojaDN1 = libro1.Worksheets.Add("DN1");
                Worksheet hojaDN2 = libro1.Worksheets.Add("DN2");
                Worksheet hojaTI = libro1.Worksheets.Add("TI");
                Worksheet hojaRH = libro1.Worksheets.Add("RH");
                Worksheet hojaAuditoria = libro1.Worksheets.Add("AUDITORIA");
                Worksheet hojaComercio = libro1.Worksheets.Add("COMERCIO");
                Worksheet hojaContraloria = libro1.Worksheets.Add("CONTRALORIA");
                Worksheet hojaDirG = libro1.Worksheets.Add("DIR. GRAL.");
                Worksheet hojaLegal = libro1.Worksheets.Add("LEGAL");
                Worksheet hojaPlaneacion = libro1.Worksheets.Add("PLANEACION");
                Worksheet hojaSox = libro1.Worksheets.Add("SOX");
                /*Worksheet hojaDN1 = libro1.Worksheets.Add("DN1");
                Worksheet hojaDN2 = libro1.Worksheets.Add("DN2");
                Worksheet hojaTI = libro1.Worksheets.Add("TI");
                Worksheet hojaRH = libro1.Worksheets.Add("RH");
                Worksheet hojaAuditoria = libro1.Worksheets.Add("AUDITORIA");
                Worksheet hojaComercio = libro1.Worksheets.Add("COMERCIO");
                Worksheet hojaContraloria = libro1.Worksheets.Add("CONTRALORIA");
                Worksheet hojaDirG = libro1.Worksheets.Add("DIR GRAL");
                Worksheet hojaLegal = libro1.Worksheets.Add("LEGAL");
                Worksheet HojaPlaneacion = libro1.Worksheets.Add("PLANECAION");
                Worksheet hojaSOX = libro1.Worksheets.Add("SOX");*/

                //añadimos los datos a la hoja General
                hojaGeneral.Cells.ImportData(dt, 0, 0, importOptions1);
                hojaGeneral.AutoFitColumns();
                //Dar formato de tabla a los resultados
                ListObject listObject = hojaGeneral.ListObjects[hojaGeneral.ListObjects.Add(0, 0, totalBNUsers + 1, 5, true)];
                listObject.TableStyleType = TableStyleType.TableStyleMedium10;


                hojaTotal.Cells.ImportData(totalesBN, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject2 = hojaTotal.ListObjects[hojaTotal.ListObjects.Add(0, 0, 12, 1, true)];
                listObject2.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaTotal.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (totalBNUsers != 0)
                {
                    //agregar grafico de barras
                    int chartIndex = hojaTotal.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);//25, 15
                    Aspose.Cells.Charts.Chart chart = hojaTotal.Charts[chartIndex];
                    chart.SetChartDataRange("A1:B12", false);
                }

                hojaDN1.Cells.ImportData(tablaDN1, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject3 = hojaDN1.ListObjects[hojaDN1.ListObjects.Add(0, 0, conDN1 + 1, 1, true)];
                listObject3.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDN1.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDN1 != 0)
                {
                    //agregar grafico de barras
                    int chartIndex2 = hojaDN1.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 30, 20);
                    Aspose.Cells.Charts.Chart chart2 = hojaDN1.Charts[chartIndex2];
                    String rango2 = "A1:B" + (conDN1 + 1);
                    chart2.SetChartDataRange(rango2, false);
                }
                

                hojaDN2.Cells.ImportData(tablaDN2, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject4 = hojaDN2.ListObjects[hojaDN2.ListObjects.Add(0, 0, conDN2 + 1, 1, true)];
                listObject4.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDN2.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDN2 != 0)
                {
                    //agregar grafico de barras
                    int chartIndex3 = hojaDN2.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 30, 20);
                    Aspose.Cells.Charts.Chart chart3 = hojaDN2.Charts[chartIndex3];
                    String rango3 = "A1:B" + (conDN2 + 1);
                    chart3.SetChartDataRange(rango3, false);
                }
                

                hojaTI.Cells.ImportData(tablaTI, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject5 = hojaTI.ListObjects[hojaTI.ListObjects.Add(0, 0, conTI + 1, 1, true)];
                listObject5.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaTI.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conTI != 0)
                {
                    //agregar grafico de barras
                    int chartIndex5 = hojaTI.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart5 = hojaTI.Charts[chartIndex5];
                    String rango4 = "A1:B" + (conTI + 1);
                    chart5.SetChartDataRange(rango4, false);
                }
                

                hojaRH.Cells.ImportData(tablaRH, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject6 = hojaRH.ListObjects[hojaRH.ListObjects.Add(0, 0, conRH + 1, 1, true)];
                listObject6.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaRH.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conRH != 0)
                {
                    //agregar grafico de barras
                    int chartIndex6 = hojaRH.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart6 = hojaRH.Charts[chartIndex6];
                    String rango6 = "A1:B" + (conRH + 1);
                    chart6.SetChartDataRange(rango6, false);
                }
                

                hojaAuditoria.Cells.ImportData(tablaAuditoria, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject7 = hojaAuditoria.ListObjects[hojaAuditoria.ListObjects.Add(0, 0, conAudit + 1, 1, true)];
                listObject7.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaAuditoria.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conAudit != 0)
                {
                    //agregar grafico de barras
                    int chartIndex7 = hojaAuditoria.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart7 = hojaAuditoria.Charts[chartIndex7];
                    String rango7 = "A1:B" + (conAudit + 1);
                    chart7.SetChartDataRange(rango7, false);
                }
                

                hojaComercio.Cells.ImportData(tablaComercio, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject8 = hojaComercio.ListObjects[hojaComercio.ListObjects.Add(0, 0, conComer + 1, 1, true)];
                listObject8.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaComercio.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conComer != 0)
                {
                    //agregar grafico de barras
                    int chartIndex8 = hojaComercio.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart8 = hojaComercio.Charts[chartIndex8];
                    String rango8 = "A1:B" + (conComer + 1);
                    chart8.SetChartDataRange(rango8, false);
                }
                

                hojaContraloria.Cells.ImportData(tablaContraloria, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject9 = hojaContraloria.ListObjects[hojaContraloria.ListObjects.Add(0, 0, conContra + 1, 1, true)];
                listObject9.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaContraloria.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conContra != 0)
                {
                    //agregar grafico de barras
                    int chartIndex9 = hojaContraloria.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart9 = hojaContraloria.Charts[chartIndex9];
                    String rango9 = "A1:B" + (conContra + 1);
                    chart9.SetChartDataRange(rango9, false);
                }
                

                hojaDirG.Cells.ImportData(tablaDirG, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject10 = hojaDirG.ListObjects[hojaDirG.ListObjects.Add(0, 0, conDir + 1, 1, true)];
                listObject10.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDirG.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDir != 0)
                {
                    //agregar grafico de barras
                    int chartIndex10 = hojaDirG.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart10 = hojaDirG.Charts[chartIndex10];
                    String rango10 = "A1:B" + (conDir + 1);
                    chart10.SetChartDataRange(rango10, false);
                }
                

                hojaLegal.Cells.ImportData(tablaLegal, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject11 = hojaLegal.ListObjects[hojaLegal.ListObjects.Add(0, 0, conLegal + 1, 1, true)];
                listObject11.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaLegal.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conLegal != 0)
                {
                    //agregar grafico de barras
                    int chartIndex11 = hojaLegal.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart11 = hojaLegal.Charts[chartIndex11];
                    String rango11 = "A1:B" + (conLegal + 1);
                    chart11.SetChartDataRange(rango11, false);
                }
                

                hojaPlaneacion.Cells.ImportData(tablaPlaneacion, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject12 = hojaPlaneacion.ListObjects[hojaPlaneacion.ListObjects.Add(0, 0, conPlanea + 1, 1, true)];
                listObject12.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaPlaneacion.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conPlanea != 0)
                {
                    //agregar grafico de barras
                    int chartIndex12 = hojaPlaneacion.Charts.Add(Aspose.Cells.Charts.ChartType.Bar, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart12 = hojaPlaneacion.Charts[chartIndex12];
                    String rango12 = "A1:B" + (conPlanea + 1);
                    chart12.SetChartDataRange(rango12, false);
                }


                hojaSox.Cells.ImportData(tablaSOX, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject13 = hojaSox.ListObjects[hojaSox.ListObjects.Add(0, 0, conSOX + 1, 1, true)];
                listObject13.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaSox.AutoFitColumns();
                //validamos que haya registros el área para crear la gráfica de barras en el excel
                if (conSOX != 0)
                {
                    //agregar grafico de barras
                    int chartIndex13 = hojaSox.Charts.Add(Aspose.Cells.Charts.ChartType.Bar, 1, 4, 25, 15);
                    Aspose.Cells.Charts.Chart chart13 = hojaSox.Charts[chartIndex13];
                    String rango13 = "A1:B" + (conSOX + 1);
                    chart13.SetChartDataRange(rango13, false);
                }


                string archivoP = @"C:\\Conversiones ReportesImp\\prueba28.xlsx";
                libro1.Save(archivoP);

                MessageBox.Show("Archivo Guardado correctamente");


                /*FileStream fstream = new FileStream(archivoP, FileMode.Open);
                Workbook wb = new Workbook(fstream);
                wb.Worksheets.RemoveAt(1);
                wb.SaveToStream();
                fstream.Close();*/


                /*MySqlConnection sqlConexion = getConection(); //Se inicializa la conexion a la base
                try
                {
                    sqlConexion.Open();
                    //conexion.Text = "Conectados!!";
                    sqlConexion.Close();
                }
                catch (System.Exception ex)
                {
                    //conexion.Text = ex.Message;
                }*/
            }
            catch (Exception ex)
            {

                throw;
            }
            /*try
            {
                mesdb = (String)jComboBox1.getSelectedItem();
                mes = (String)jComboBox1.getSelectedItem();
                int aniodb = Integer.parseInt((String)jSpinner1.getValue());
                String rutaArchivo = ruta + "\\Reporte de Impresión BlancoNegro - " + mesdb + " " + aniodb + ".xlsx";
                XSSFWorkbook libro = new XSSFWorkbook();
                XSSFSheet hoja1 = libro.createSheet("General");
                Connection con = null;
                Boolean i1 = false;
                Boolean i2 = false;
                Boolean i3 = false;
                Boolean i4 = false;
                Boolean i5 = false;
                String sURL = "jdbc:mysql://172.25.115.133:3306/oma";
                con = (Connection)DriverManager.getConnection(sURL, "ti", "MSOMti2019");
                int longitud1 = data1.length + (data2.length - 1) + (data3.length - 1);
                int longitud2 = (data2.length - 1) + (data3.length - 1);
                int longitud3 = (data3.length - 1);
                int longitud4 = data1.length;
                int longitud5 = data1.length + (data2.length - 1);
                String datosgenerales[][] = new String[longitud1 + 5][6];
                PreparedStatement st = con.prepareStatement("SELECT nombre FROM area");
                ResultSet rst = st.executeQuery();
                while (rst.next())
                {
                    String name = rst.getString("nombre");
                    areasbn.add(new Area(name, 0));
                }
                for (int i = 0; i < longitud4; i++)
                {
                    if (i == 0)
                    {
                        datosgenerales[i][0] = data1[i][0];
                        datosgenerales[i][1] = data1[i][1];
                        datosgenerales[i][2] = "Direccion";
                        datosgenerales[i][3] = data1[i][2];
                        datosgenerales[i][4] = data1[i][3];
                        datosgenerales[i][5] = data1[i][4];
                    }
                    else
                    {
                        PreparedStatement stmt = con.prepareStatement("SELECT area_idarea FROM empleado WHERE correo like '"
                                + data1[i][1] + "%'");
                        ResultSet rs = stmt.executeQuery();
                        int idarea = 0;
                        while (rs.next())
                        {
                            idarea = rs.getInt("area_idarea");
                        }
                        stmt = con.prepareStatement("SELECT nombre FROM area WHERE idarea =  " + idarea);
                        rs = stmt.executeQuery();
                        String nombre = "";
                        while (rs.next())
                        {
                            nombre = rs.getString("nombre");
                            datosgenerales[i][0] = data1[i][0];
                            datosgenerales[i][1] = data1[i][1];
                            datosgenerales[i][2] = nombre;
                            datosgenerales[i][3] = data1[i][2];
                            datosgenerales[i][4] = data1[i][3];
                            datosgenerales[i][5] = data1[i][4];
                            Area aux = areasbn.get(idarea - 1);
                            aux.setImpcobn(aux.getImpcobn() + Integer.parseInt(data1[i][3]));
                            ArrayList<Empleado> emp = aux.getEmp();
                            boolean repetido = false;
                            Empleado em = new Empleado(data1[i][1], Integer.parseInt(data1[i][3]));
                            for (int j = 0; j < emp.size(); j++)
                            {
                                Empleado auxi = emp.get(j);
                                if (em.getNombre().equals(auxi.getNombre()))
                                {
                                    auxi.setImpbn(auxi.getImpbn() + em.getImpbn());
                                    emp.set(j, auxi);
                                    repetido = true;
                                }
                            }
                            if (repetido == false)
                            {
                                emp.add(em);
                            }
                            aux.setEmp(emp);
                            areasbn.set(idarea - 1, aux);
                        }
                    }
                }
                for (int i = 1; i < data2.length; i++)
                {
                    PreparedStatement stmt = con.prepareStatement("SELECT area_idarea FROM empleado WHERE correo like '"
                            + data2[i][1] + "%'");
                    ResultSet rs = stmt.executeQuery();
                    int idarea = 0;
                    while (rs.next())
                    {
                        idarea = rs.getInt("area_idarea");
                    }
                    stmt = con.prepareStatement("SELECT nombre FROM area WHERE idarea =  " + idarea);
                    rs = stmt.executeQuery();
                    String nombre = "";
                    while (rs.next())
                    {
                        nombre = rs.getString("nombre");
                        datosgenerales[longitud4 - 1 + i][0] = data2[i][0];
                        datosgenerales[longitud4 - 1 + i][1] = data2[i][1];
                        datosgenerales[longitud4 - 1 + i][2] = nombre;
                        datosgenerales[longitud4 - 1 + i][3] = data2[i][2];
                        datosgenerales[longitud4 - 1 + i][4] = data2[i][3];
                        datosgenerales[longitud4 - 1 + i][5] = data2[i][4];
                        Area aux = areasbn.get(idarea - 1);
                        aux.setImpcobn(aux.getImpcobn() + Integer.parseInt(data2[i][3]));
                        ArrayList<Empleado> emp = aux.getEmp();
                        boolean repetido = false;
                        Empleado em = new Empleado(data2[i][1], Integer.parseInt(data2[i][3]));
                        for (int j = 0; j < emp.size(); j++)
                        {
                            Empleado auxi = emp.get(j);
                            if (em.getNombre().equals(auxi.getNombre()))
                            {
                                auxi.setImpbn(auxi.getImpbn() + em.getImpbn());
                                emp.set(j, auxi);
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            emp.add(em);
                        }
                        aux.setEmp(emp);
                        areasbn.set(idarea - 1, aux);
                    }
                }
                for (int i = 1; i < data3.length; i++)
                {
                    PreparedStatement stmt = con.prepareStatement("SELECT area_idarea FROM empleado WHERE correo like '"
                            + data3[i][1] + "%'");
                    ResultSet rs = stmt.executeQuery();
                    int idarea = 0;
                    while (rs.next())
                    {
                        idarea = rs.getInt("area_idarea");
                    }
                    stmt = con.prepareStatement("SELECT nombre FROM area WHERE idarea =  " + idarea);
                    rs = stmt.executeQuery();
                    String nombre = "";
                    while (rs.next())
                    {
                        nombre = rs.getString("nombre");
                        datosgenerales[longitud5 - 1 + i][0] = data3[i][0];
                        datosgenerales[longitud5 - 1 + i][1] = data3[i][1];
                        datosgenerales[longitud5 - 1 + i][2] = nombre;
                        datosgenerales[longitud5 - 1 + i][3] = data3[i][2];
                        datosgenerales[longitud5 - 1 + i][4] = data3[i][3];
                        datosgenerales[longitud5 - 1 + i][5] = data3[i][4];
                        Area aux = areasbn.get(idarea - 1);
                        aux.setImpcobn(aux.getImpcobn() + Integer.parseInt(data3[i][3]));
                        ArrayList<Empleado> emp = aux.getEmp();
                        boolean repetido = false;
                        Empleado em = new Empleado(data3[i][1], Integer.parseInt(data3[i][3]));
                        for (int j = 0; j < emp.size(); j++)
                        {
                            Empleado auxi = emp.get(j);
                            if (em.getNombre().equals(auxi.getNombre()))
                            {
                                auxi.setImpbn(auxi.getImpbn() + em.getImpbn());
                                emp.set(j, auxi);
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            emp.add(em);
                        }
                        aux.setEmp(emp);
                        areasbn.set(idarea - 1, aux);
                    }
                }
                int v1 = (int)jSpinner2.getValue();
                int v2 = (int)jSpinner3.getValue();
                int v3 = (int)jSpinner4.getValue();
                int v4 = (int)jSpinner5.getValue();
                int v5 = (int)jSpinner6.getValue();
                System.out.println(v1 + "," + v2 + "," + v3 + "," + v4 + "," + v5);
                datosgenerales[longitud1][0] = "Imprimir";
                datosgenerales[longitud1][1] = "lrosas";
                datosgenerales[longitud1][2] = "CONTRALORIA";
                datosgenerales[longitud1][3] = mes;
                datosgenerales[longitud1][4] = String.valueOf((int)jSpinner2.getValue());
                datosgenerales[longitud1][5] = "Impresora Contraloria 1";
                datosgenerales[longitud1 + 1][0] = "Imprimir";
                datosgenerales[longitud1 + 1][1] = "aarguelles";
                datosgenerales[longitud1 + 1][2] = "CONTRALORIA";
                datosgenerales[longitud1 + 1][3] = mes;
                datosgenerales[longitud1 + 1][4] = String.valueOf((int)jSpinner3.getValue());
                datosgenerales[longitud1 + 1][5] = "Impresora Contraloria 2";
                datosgenerales[longitud1 + 2][0] = "Imprimir";
                datosgenerales[longitud1 + 2][1] = "cguzman";
                datosgenerales[longitud1 + 2][2] = "RH";
                datosgenerales[longitud1 + 2][3] = mes;
                datosgenerales[longitud1 + 2][4] = String.valueOf((int)jSpinner4.getValue());
                datosgenerales[longitud1 + 2][5] = "Impresora Recursos Humanos";
                datosgenerales[longitud1 + 3][0] = "Imprimir";
                datosgenerales[longitud1 + 3][1] = "gcampos";
                datosgenerales[longitud1 + 3][2] = "DIR. GRAL.";
                datosgenerales[longitud1 + 3][3] = mes;
                datosgenerales[longitud1 + 3][4] = String.valueOf((int)jSpinner5.getValue());
                datosgenerales[longitud1 + 3][5] = "Impresora DireccionGeneral";
                datosgenerales[longitud1 + 4][0] = "Imprimir";
                datosgenerales[longitud1 + 4][1] = "mpantoja";
                datosgenerales[longitud1 + 4][2] = "AUDITORIA";
                datosgenerales[longitud1 + 4][3] = mes;
                datosgenerales[longitud1 + 4][4] = String.valueOf((int)jSpinner6.getValue());
                datosgenerales[longitud1 + 4][5] = "Impresora Auditoria";
                for (int i = 0; i < datosgenerales.length; i++)
                {
                    XSSFRow row = hoja1.createRow(i);//se crea las filas
                    for (int j = 0; j < 6; j++)
                    {
                        XSSFCell cell = row.createCell(j);//se crea las celdas para la contenido, junto con la posición
                        cell.setCellValue(datosgenerales[i][j]); //se añade el contenido
                    }
                }
                File file;
                file = new File(rutaArchivo);
                FileOutputStream fileOuS = new FileOutputStream(file);
                for (int j = 0; j < areasbn.size(); j++)
                {
                    ArrayList<Empleado> auxiliar = areasbn.get(j).getEmp();
                    String conte[][] = new String[auxiliar.size()][1];
                    Area areaux = areasbn.get(j);
                    for (int i = 0; i < auxiliar.size(); i++)
                    {
                        conte[i][0] = auxiliar.get(i).getNombre();
                        if (conte[i][0].equals("lrosas"))
                        {
                            int suma = auxiliar.get(i).getImpbn() + (int)jSpinner2.getValue();
                            auxiliar.get(i).setImpbn(suma);
                            i1 = true;
                            areaux.setEmp(auxiliar);
                            areaux.setImpcobn(areaux.getImpcobn() + v1);
                        }
                        if (conte[i][0].equals("aarguelles"))
                        {
                            System.out.println("arguelles encontrado");
                            int suma = auxiliar.get(i).getImpbn() + (int)jSpinner3.getValue();
                            auxiliar.get(i).setImpbn(suma);
                            i2 = true;
                            areaux.setEmp(auxiliar);
                            areaux.setImpcobn(areaux.getImpcobn() + v2);
                        }
                        if (conte[i][0].equals("cguzman"))
                        {
                            int suma = auxiliar.get(i).getImpbn() + (int)jSpinner4.getValue();
                            auxiliar.get(i).setImpbn(suma);
                            i3 = true;
                            areaux.setEmp(auxiliar);
                            areaux.setImpcobn(areaux.getImpcobn() + v3);
                        }
                        if (conte[i][0].equals("gcampos"))
                        {
                            int suma = auxiliar.get(i).getImpbn() + (int)jSpinner5.getValue();
                            auxiliar.get(i).setImpbn(suma);
                            i4 = true;
                            areaux.setEmp(auxiliar);
                            areaux.setImpcobn(areaux.getImpcobn() + v4);
                        }
                        if (conte[i][0].equals("mpantoja"))
                        {
                            int suma = auxiliar.get(i).getImpbn() + (int)jSpinner6.getValue();
                            auxiliar.get(i).setImpbn(suma);
                            i5 = true;
                            areaux.setEmp(auxiliar);
                            areaux.setImpcobn(areaux.getImpcobn() + v5);
                        }
                    }
                    if (i1 == false && j == 6)
                    {
                        System.out.println("j " + j);
                        Empleado em = new Empleado("lrosas", (int)jSpinner2.getValue());
                        auxiliar.add(em);
                        i1 = true;
                        areaux.setEmp(auxiliar);
                        areaux.setImpcobn(areaux.getImpcobn() + v1);
                    }
                    if (i2 == false && j == 6)
                    {
                        Empleado em = new Empleado("aarguelles", (int)jSpinner3.getValue());
                        auxiliar.add(em);
                        i2 = true;
                        areaux.setEmp(auxiliar);
                        areaux.setImpcobn(areaux.getImpcobn() + v2);
                    }
                    if (i3 == false && j == 3)
                    {
                        Empleado em = new Empleado("cguzman", (int)jSpinner4.getValue());
                        auxiliar.add(em);
                        i3 = true;
                        areaux.setEmp(auxiliar);
                        areaux.setImpcobn(areaux.getImpcobn() + v3);
                    }
                    if (i4 == false && j == 7)
                    {
                        Empleado em = new Empleado("gcampos", (int)jSpinner5.getValue());
                        auxiliar.add(em);
                        i4 = true;
                        areaux.setEmp(auxiliar);
                        areaux.setImpcobn(areaux.getImpcobn() + v4);
                    }
                    if (i5 == false && j == 4)
                    {
                        Empleado em = new Empleado("mpantoja", (int)jSpinner6.getValue());
                        auxiliar.add(em);
                        i5 = true;
                        areaux.setEmp(auxiliar);
                        areaux.setImpcobn(areaux.getImpcobn() + v5);
                    }
                    areasbn.set(j, areaux);
                }
                XSSFSheet hoja = libro.createSheet("Total");
                String contenid[][] = new String[15][2];
                String contegraf[][] = new String[12][2];
                java.util.Date fecha = new java.util.Date();
                contenid[0][0] = "Este manual se genero:";
                contenid[0][1] = String.valueOf(fecha);
                contenid[1][0] = "Area";
                contenid[1][1] = "Total Blanco/Negro";
                int impbn = 0;
                int impindependiente = (int)jSpinner2.getValue() + (int)jSpinner3.getValue() + (int)jSpinner4.getValue()
                        + (int)jSpinner5.getValue() + (int)jSpinner6.getValue();
                for (int i = 2; i < 14; i++)
                {
                    contenid[i][0] = areasbn.get(i - 2).getNombre();
                    impbn += areasbn.get(i - 2).getImpcobn();
                    contenid[i][1] = String.valueOf(areasbn.get(i - 2).getImpcobn());
                    contegraf[i - 2][0] = contenid[i][0];
                    contegraf[i - 2][1] = contenid[i][1];
                }
                contenid[14][0] = "Total general";
                contenid[14][1] = String.valueOf(impbn + impindependiente);
                for (int i = 0; i < contenid.length; i++)
                {
                    XSSFRow row = hoja.createRow(i);//se crea las filas
                    for (int j = 0; j < 2; j++)
                    {
                        XSSFCell cell = row.createCell(j);//se crea las celdas para la contenido, junto con la posición
                        cell.setCellValue(contenid[i][j]); //se añade el contenido
                    }
                }
                final BufferedImage buffer1 = generarGraficaBNTotal(contegraf).createBufferedImage(1200, 800);
                ByteArrayOutputStream img_bytes1 = new ByteArrayOutputStream();
                ImageIO.write(buffer1, "png", img_bytes1);
                img_bytes1.flush();
                XSSFClientAnchor anchor1 = new XSSFClientAnchor(0, 0, 0, 0, (short)6, 0, (short)21, 20);
                int index1 = libro.addPicture(img_bytes1.toByteArray(), XSSFWorkbook.PICTURE_TYPE_PNG);
                XSSFSheet sheet1 = libro.getSheet("Total");
                XSSFDrawing patriarch1 = sheet1.createDrawingPatriarch();
                patriarch1.createPicture(anchor1, index1);
                for (int i = 0; i < areasbn.size(); i++)
                {
                    XSSFSheet hojaarea = libro.createSheet(areasbn.get(i).getNombre());
                    ArrayList<Empleado> auxiliar = areasbn.get(i).getEmp();
                    String conte[][] = new String[auxiliar.size() + 2][2];
                    String contegrafa[][] = new String[auxiliar.size()][2];
                    conte[0][0] = "Area";
                    conte[0][1] = "Total B/N";
                    for (int j = 1; j < auxiliar.size() + 1; j++)
                    {
                        conte[j][0] = auxiliar.get(j - 1).getNombre();
                        conte[j][1] = String.valueOf(auxiliar.get(j - 1).getImpbn());
                        contegrafa[j - 1][0] = conte[j][0];
                        contegrafa[j - 1][1] = conte[j][1];
                    }
                    conte[auxiliar.size() + 1][0] = "Total general";
                    conte[auxiliar.size() + 1][1] = String.valueOf(areasbn.get(i).getImpcobn());
                    for (int k = 0; k < conte.length; k++)
                    {
                        XSSFRow row = hojaarea.createRow(k);//se crea las filas
                        for (int j = 0; j < 2; j++)
                        {
                            XSSFCell cell = row.createCell(j);//se crea las celdas para la contenido, junto con la posición
                            cell.setCellValue(conte[k][j]); //se añade el contenido
                        }
                    }
                    final BufferedImage buffer = generarGraficaContenidoBN(contegrafa).createBufferedImage(1200, 800);
                    ByteArrayOutputStream img_bytes = new ByteArrayOutputStream();
                    ImageIO.write(buffer, "png", img_bytes);
                    img_bytes.flush();
                    XSSFClientAnchor anchor = new XSSFClientAnchor(0, 0, 0, 0, (short)6, 0, (short)20, 20);
                    int index = libro.addPicture(img_bytes.toByteArray(), XSSFWorkbook.PICTURE_TYPE_PNG);
                    XSSFSheet sheet = libro.getSheet(areasbn.get(i).getNombre());
                    XSSFDrawing patriarch = sheet.createDrawingPatriarch();
                    patriarch.createPicture(anchor, index);
                }
                if (file.exists())
                {// si el archivo existe se elimina
                    file.delete();
                    System.out.println("Archivo eliminado");
                }
                libro.write(fileOuS);
                fileOuS.flush();
                fileOuS.close();
                JOptionPane.showMessageDialog(null, "Archivo Reporte BN Creado");
                System.out.println("Archivo ReporteBN Creado");
            }
            catch (Exception e)
            {

                e.printStackTrace();
            }*/
        }
    }
}
