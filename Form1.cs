using Aspose.Cells;
using Aspose.Cells.Drawing;
using Aspose.Cells.Tables;

using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Application = System.Windows.Forms.Application;
using Cell = Aspose.Cells.Cell;
using Path = System.IO.Path;
using Row = Aspose.Cells.Row;
using String = System.String;
using TableStyleType = Aspose.Cells.Tables.TableStyleType;
using Workbook = Aspose.Cells.Workbook;
using Worksheet = Aspose.Cells.Worksheet;

namespace ReporteImpresoras
{
    public partial class VentanaPrincipal : Form
    {
        public string rutaExcelByN;
        public string rutaExcelColorActual;
        public string rutaExcelColorAnterior;
        int totalBNUsers = 0;

        public string RutaArchivosGenerados;
        DataTable tablaColorActual = null;
        DataTable tablaColorAnterior = null;

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
        List<string> listaAreas;
        List<int> listaTotalesBN;

        List<string> listaDN1;
        List<int> ListaTotalDN1;

        List<string> listaDN2;
        List<int> listatotalDN2;

        List<string> listaTI;
        List<int> listatotalTI;

        List<string> listaRH;
        List<int> listatotalRH;

        List<string> listaAuditoria;
        List<int> listatotalAud;

        List<string> listaComercio;
        List<int> listatotalComer;

        List<string> listaContraloria;
        List<int> listatotalContra;

        List<string> listaDirG;
        List<int> listaTotalDirG;

        List<string> listaLegal;
        List<int> listatotalLegal;

        List<string> listaPlaneacion;
        List<int> listatotalPlaneacion;

        List<string> listaSOX;
        List<int> listatotalSOX;


        List<int> listaTotalesColor;
        List<int> ListaTotalColorDN1;
        List<int> listatotalColorDN2;
        List<int> listatotalColorTI;
        List<int> listatotalColorRH;
        List<int> listatotalColorAud;
        List<int> listatotalColorComer;
        List<int> listatotalColorContra;
        List<int> listaTotalColorDirG;
        List<int> listatotalColorLegal;
        List<int> listatotalColorPlaneacion;
        List<int> listatotalColorSOX;

        List<int> listaTotalesGrande;
        List<int> ListaTotalGrandeDN1;
        List<int> listatotalGrandeDN2;
        List<int> listatotalGrandeTI;
        List<int> listatotalGrandeRH;
        List<int> listatotalGrandeAud;
        List<int> listatotalGrandeComer;
        List<int> listatotalGrandeContra;
        List<int> listaTotalGrandeDirG;
        List<int> listatotalGrandeLegal;
        List<int> listatotalGrandePlaneacion;
        List<int> listatotalGrandeSOX;

        List<int> listaTotalesDoble;
        List<int> ListaTotalDobleDN1;
        List<int> listatotalDobleDN2;
        List<int> listatotalDobleTI;
        List<int> listatotalDobleRH;
        List<int> listatotalDobleAud;
        List<int> listatotalDobleComer;
        List<int> listatotalDobleContra;
        List<int> listaTotalDobleDirG;
        List<int> listatotalDobleLegal;
        List<int> listatotalDoblePlaneacion;
        List<int> listatotalDobleSOX;

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

        //Contadores de total impresiones color
        int totalColorDN1 = 0;
        int totalColorDN2 = 0;
        int totalColorTI = 0;
        int totalColorRH = 0;
        int totalColorAuditoria = 0;
        int totalColorComercio = 0;
        int totalColorContraloria = 0;
        int totalColorDirG = 0;
        int totalColorLegal = 0;
        int totalColorPlaneacion = 0;
        int totalColorSOX = 0;

        int totalGrandeDN1 = 0;
        int totalGrandeDN2 = 0;
        int totalGrandeTI = 0;
        int totalGrandeRH = 0;
        int totalGrandeAuditoria = 0;
        int totalGrandeComercio = 0;
        int totalGrandeContraloria = 0;
        int totalGrandeDirG = 0;
        int totalGrandeLegal = 0;
        int totalGrandePlaneacion = 0;
        int totalGrandeSOX = 0;

        int totalDobleDN1 = 0;
        int totalDobleDN2 = 0;
        int totalDobleTI = 0;
        int totalDobleRH = 0;
        int totalDobleAuditoria = 0;
        int totalDobleComercio = 0;
        int totalDobleContraloria = 0;
        int totalDobleDirG = 0;
        int totalDobleLegal = 0;
        int totalDoblePlaneacion = 0;
        int totalDobleSOX = 0;

        //Tabla para mostrar los usuarios
        DataTable Tablausuarios = null;

        public VentanaPrincipal()
        {
            InitializeComponent();
            cargaAnioMes();
            Resultados_Load();
            //cargaTablaUsuarios();
            txtBusqueda.PlaceholderText = "Buscar Usuario";
            comboAreas.SelectedIndex = 0;
        }

        private void cargaTablaUsuarios()
        {
            Tablausuarios = leerExcel();
            dataGridView1.DataSource = Tablausuarios;
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
                cmbAnios.SelectedIndex = contAnios - 1;
            }


        }//RH, contraloria, Direccion general (Nombre de las impresoras independientes)

        private async void btnSelecBN_Click(object sender, EventArgs e)
        {
            DateTime date1;
            string date2;
            string rutaCSV_Ex;
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm";
            //VentanaCarga vCarga = new VentanaCarga();   

            //Seleccionar reporte csv o excel
            if (file1.ShowDialog() == DialogResult.OK)
            {
                //vCarga.Show();
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
                    //vCarga.Close();

                }
                txtRutaBN.Text = rutaExcelByN;

                //leerExcel();
            }
        }

        private void btnGenerarRepor_Click(object sender, EventArgs e)
        {
            VentanaCarga vCarga = new VentanaCarga();

            //Se valida que este seleccionado al menos uno de los reportes para generar el excel
            if (txtRutaBN.Text.Equals("") && txtColorActual.Text.Equals("") && txtColorActual.Text.Equals(""))
            {
                MessageBox.Show("Necesita seleccionar al menos uno de los archivos para generar un reporte");
            }
            else
            {
                //Se valida que este seleccionado el archivo para b&N
                if (!txtRutaBN.Text.Equals(""))
                {
                    FolderBrowserDialog folderDlgCompartida = new FolderBrowserDialog();
                    if (folderDlgCompartida.ShowDialog() == DialogResult.OK)
                    {
                        RutaArchivosGenerados = folderDlgCompartida.SelectedPath;

                        /*vCarga.Show();
                        Task otask = new Task(GenerarExcel);//
                        otask.Start();
                        await otask;//
                        vCarga.Close();*/

                        GenerarReporteByN();
                    }
                }

                //Se valida que esten seleccionados los archivos de mes anterior y actual
                if (!txtColorActual.Text.Equals("") || !txtColorActual.Text.Equals(""))
                {
                    if (txtColorActual.Text.Equals("") || txtColorActual.Text.Equals(""))
                    {
                        MessageBox.Show("Se necesita el reporta del mes anterior y el actual para generar el reporte de color");
                    }
                    else if (!txtColorActual.Text.Equals("") || !txtColorActual.Text.Equals(""))
                    {
                        FolderBrowserDialog folderDlgCompartida2 = new FolderBrowserDialog();
                        if (folderDlgCompartida2.ShowDialog() == DialogResult.OK)
                        {
                            RutaArchivosGenerados = folderDlgCompartida2.SelectedPath;
                            GeneralExcelColor();
                        }
                    }
                }
            }
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
                string sqlCon = "select e.Correo, e.Nombre, e.Puesto, e.area_idarea as ID_Area, a.nombre as Area  from empleado e, area a where e.Area_idArea = a.idArea;";
                MySqlDataAdapter com = new MySqlDataAdapter(sqlCon, sqlConexion);// where Area_idarea = 3
                com.Fill(tbl1);
                dataGridView1.DataSource = tbl1;
                Tablausuarios = tbl1;
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
                Console.WriteLine("ERROR: " + ex);
                MessageBox.Show("No se logró hacer conexión a la base, inténtelo más tarde");
            }
            return sqlConexion;
        }

        public DataTable leerExcel()
        {
            string rutaprueba = rutaExcelByN;//ReporteImpB&N_20240513_1750.xlsx";
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

                //Inicializamos las lista para almacenar los totales de cada usuario por area
                listaAreas = new List<string>();
                listaTotalesBN = new List<int>();

                listaDN1 = new List<string>();
                ListaTotalDN1 = new List<int>();

                listaDN2 = new List<string>();
                listatotalDN2 = new List<int>();

                listaTI = new List<string>();
                listatotalTI = new List<int>();

                listaRH = new List<string>();
                listatotalRH = new List<int>();

                listaAuditoria = new List<string>();
                listatotalAud = new List<int>();

                listaComercio = new List<string>();
                listatotalComer = new List<int>();

                listaContraloria = new List<string>();
                listatotalContra = new List<int>();

                listaDirG = new List<string>();
                listaTotalDirG = new List<int>();

                listaLegal = new List<string>();
                listatotalLegal = new List<int>();

                listaPlaneacion = new List<string>();
                listatotalPlaneacion = new List<int>();

                listaSOX = new List<string>();
                listatotalSOX = new List<int>();

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
                            System.String ColumnName = (string)c.Value;
                            if (contCols != 3)
                            {
                                dt.Columns.Add(ColumnName, typeof(string));
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
                        if (ws.Cells[i, 0].Value.ToString() != "Escanear a E-mail" && mesSelec == mes && anioSelec == año && ConTotal != 0)//&& ws.Cells[i, 1].Value.ToString() == "raguilar"
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
                                if (!listaDN1.Contains(nombreUsuario1))
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


        private void GenerarReporteByN()
        {
            try
            {
                //Obtenemos el año y mes seleccionado por el usuario
                string GetMes = cmbMeses.Text;
                int GetAnio = Convert.ToInt32(cmbAnios.Text);
                DataTable dt = leerExcel();

                //Variables para almacenar las impresoras independientes
                int ImpRH = 0;
                int ImpDirG = 0;
                int ImpContra = 0;

                ImportTableOptions importOptions1 = new ImportTableOptions();//Opciones para importar la tabla al excel

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


                //Validamos que los txt de impresoras independientes no esten vacios para agregarles el valor
                if (!txtRH.Text.Equals(""))
                {
                    ImpRH = Convert.ToInt32(txtRH.Text);
                }
                if (!txtDirGral.Text.Equals(""))
                {
                    ImpDirG = Convert.ToInt32(txtDirGral.Text);
                }
                if (!txtContraloria.Text.Equals(""))
                {
                    ImpContra = Convert.ToInt32(txtContraloria.Text);
                }

                //añadimos la tabla de impresoras independientes
                /*DataTable ImpIndep = new DataTable();
                ImpIndep.Columns.Add("Independientes", typeof(String));
                ImpIndep.Columns.Add("Total", typeof(Int32));

                DataRow row1 = ImpIndep.NewRow();
                row1[0] = "RH";
                row1[0] = ImpRH;
                ImpIndep.Rows.Add(row1);
                DataRow row2 = ImpIndep.NewRow();
                row2[0] = "Dir. Gral.";
                row2[0] = ImpDirG;
                ImpIndep.Rows.Add(row2);
                DataRow row3 = ImpIndep.NewRow();
                row3[0] = "Contraloria";
                row3[0] = ImpContra;
                ImpIndep.Rows.Add(row3);*/

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
                //Cell cell1 = hojaTotal.Cells[1, 17];
                //cell1.PutValue("Prueba1");
                //hojaTotal.Cells[1, 17].Value = 3;

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
                    int chartIndex2 = hojaDN1.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 35, 19);
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
                    int chartIndex3 = hojaDN2.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 4, 35, 19);
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

                //Guardamos los archivos generados
                DateTime date1 = DateTime.Now;
                String date2 = date1.ToString("yyyyMMdd_HHmm");
                string archivoP = RutaArchivosGenerados + @"\Reporte_B&N_" + date2 + ".xlsx";
                //string archivoP = @"C:\\Conversiones ReportesImp\\prueba32.xlsx";
                libro1.Save(archivoP);

                MessageBox.Show("Archivo Guardado correctamente");

                //Eliminar hoja de evaluacion
                /*FileStream fstream = new FileStream(archivoP, FileMode.Open);
                Workbook wb = new Workbook(fstream);
                wb.Worksheets.RemoveAt("DN1");
                //Worksheet hojaOculta = libro1.Worksheets[1];
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
        }

        private void GeneralExcelColor()
        {
            try
            {
                string GetMes = cmbMeses.Text;
                int GetAnio = Convert.ToInt32(cmbAnios.Text);
                DataTable dt = leerExcelColor();

                ImportTableOptions importOptions1 = new ImportTableOptions();//Opciones para importar la tabla al excel

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
                ListObject listObject2 = hojaTotal.ListObjects[hojaTotal.ListObjects.Add(0, 0, 12, 4, true)];
                listObject2.TableStyleType = TableStyleType.TableStyleMedium10;
                //hojaTotal.Cells[1, 17].Value = "Prueba 1";

                hojaTotal.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (totalBNUsers != 0)
                {
                    //agregar grafico de barras
                    int chartIndex = hojaTotal.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);//25, 15
                    Aspose.Cells.Charts.Chart chart = hojaTotal.Charts[chartIndex];
                    chart.SetChartDataRange("A1:E12", true);
                }

                hojaDN1.Cells.ImportData(tablaDN1, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject3 = hojaDN1.ListObjects[hojaDN1.ListObjects.Add(0, 0, conDN1 + 1, 4, true)];
                listObject3.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDN1.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDN1 != 0)
                {
                    //agregar grafico de barras
                    int chartIndex2 = hojaDN1.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 35, 24);
                    Aspose.Cells.Charts.Chart chart2 = hojaDN1.Charts[chartIndex2];
                    String rango2 = "A1:E" + (conDN1 + 1);
                    chart2.SetChartDataRange(rango2, true);
                }


                hojaDN2.Cells.ImportData(tablaDN2, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject4 = hojaDN2.ListObjects[hojaDN2.ListObjects.Add(0, 0, conDN2 + 1, 4, true)];
                listObject4.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDN2.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDN2 != 0)
                {
                    //agregar grafico de barras
                    int chartIndex3 = hojaDN2.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 35, 24);
                    Aspose.Cells.Charts.Chart chart3 = hojaDN2.Charts[chartIndex3];
                    String rango3 = "A1:E" + (conDN2 + 1);
                    chart3.SetChartDataRange(rango3, true);
                }


                hojaTI.Cells.ImportData(tablaTI, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject5 = hojaTI.ListObjects[hojaTI.ListObjects.Add(0, 0, conTI + 1, 4, true)];
                listObject5.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaTI.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conTI != 0)
                {
                    //agregar grafico de barras
                    int chartIndex5 = hojaTI.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart5 = hojaTI.Charts[chartIndex5];
                    String rango4 = "A1:E" + (conTI + 1);
                    chart5.SetChartDataRange(rango4, true);
                }


                hojaRH.Cells.ImportData(tablaRH, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject6 = hojaRH.ListObjects[hojaRH.ListObjects.Add(0, 0, conRH + 1, 4, true)];
                listObject6.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaRH.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conRH != 0)
                {
                    //agregar grafico de barras
                    int chartIndex6 = hojaRH.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart6 = hojaRH.Charts[chartIndex6];
                    String rango6 = "A1:E" + (conRH + 1);
                    chart6.SetChartDataRange(rango6, true);
                }


                hojaAuditoria.Cells.ImportData(tablaAuditoria, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject7 = hojaAuditoria.ListObjects[hojaAuditoria.ListObjects.Add(0, 0, conAudit + 1, 4, true)];
                listObject7.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaAuditoria.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conAudit != 0)
                {
                    //agregar grafico de barras
                    int chartIndex7 = hojaAuditoria.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart7 = hojaAuditoria.Charts[chartIndex7];
                    String rango7 = "A1:E" + (conAudit + 1);
                    chart7.SetChartDataRange(rango7, true);
                }


                hojaComercio.Cells.ImportData(tablaComercio, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject8 = hojaComercio.ListObjects[hojaComercio.ListObjects.Add(0, 0, conComer + 1, 4, true)];
                listObject8.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaComercio.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conComer != 0)
                {
                    //agregar grafico de barras
                    int chartIndex8 = hojaComercio.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart8 = hojaComercio.Charts[chartIndex8];
                    String rango8 = "A1:E" + (conComer + 1);
                    chart8.SetChartDataRange(rango8, true);
                }


                hojaContraloria.Cells.ImportData(tablaContraloria, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject9 = hojaContraloria.ListObjects[hojaContraloria.ListObjects.Add(0, 0, conContra + 1, 4, true)];
                listObject9.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaContraloria.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conContra != 0)
                {
                    //agregar grafico de barras
                    int chartIndex9 = hojaContraloria.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart9 = hojaContraloria.Charts[chartIndex9];
                    String rango9 = "A1:E" + (conContra + 1);
                    chart9.SetChartDataRange(rango9, true);
                }


                hojaDirG.Cells.ImportData(tablaDirG, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject10 = hojaDirG.ListObjects[hojaDirG.ListObjects.Add(0, 0, conDir + 1, 4, true)];
                listObject10.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaDirG.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conDir != 0)
                {
                    //agregar grafico de barras
                    int chartIndex10 = hojaDirG.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart10 = hojaDirG.Charts[chartIndex10];
                    String rango10 = "A1:E" + (conDir + 1);
                    chart10.SetChartDataRange(rango10, true);
                }


                hojaLegal.Cells.ImportData(tablaLegal, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject11 = hojaLegal.ListObjects[hojaLegal.ListObjects.Add(0, 0, conLegal + 1, 4, true)];
                listObject11.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaLegal.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conLegal != 0)
                {
                    //agregar grafico de barras
                    int chartIndex11 = hojaLegal.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart11 = hojaLegal.Charts[chartIndex11];
                    String rango11 = "A1:E" + (conLegal + 1);
                    chart11.SetChartDataRange(rango11, true);
                }


                hojaPlaneacion.Cells.ImportData(tablaPlaneacion, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject12 = hojaPlaneacion.ListObjects[hojaPlaneacion.ListObjects.Add(0, 0, conPlanea + 1, 4, true)];
                listObject12.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaPlaneacion.AutoFitColumns();
                //validamos que haya registros en el área para crear la gráfica de barras en el excel
                if (conPlanea != 0)
                {
                    //agregar grafico de barras
                    int chartIndex12 = hojaPlaneacion.Charts.Add(Aspose.Cells.Charts.ChartType.Column, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart12 = hojaPlaneacion.Charts[chartIndex12];
                    String rango12 = "A1:E" + (conPlanea + 1);
                    chart12.SetChartDataRange(rango12, true);
                }


                hojaSox.Cells.ImportData(tablaSOX, 0, 0, importOptions1);
                //dar formato de tabla a los totales
                ListObject listObject13 = hojaSox.ListObjects[hojaSox.ListObjects.Add(0, 0, conSOX + 1, 4, true)];
                listObject13.TableStyleType = TableStyleType.TableStyleMedium10;
                hojaSox.AutoFitColumns();
                //validamos que haya registros el área para crear la gráfica de barras en el excel
                if (conSOX != 0)
                {
                    //agregar grafico de barras
                    int chartIndex13 = hojaSox.Charts.Add(Aspose.Cells.Charts.ChartType.Bar, 1, 6, 25, 20);
                    Aspose.Cells.Charts.Chart chart13 = hojaSox.Charts[chartIndex13];
                    String rango13 = "A1:E" + (conSOX + 1);
                    chart13.SetChartDataRange(rango13, true);
                }

                //Guardamos los archivos generados
                DateTime date1 = DateTime.Now;
                String date2 = date1.ToString("yyyyMMdd_HHmm");
                string archivoP = RutaArchivosGenerados + @"\Reporte_Color_" + date2 + ".xlsx";
                //string archivoP = @"C:\\Conversiones ReportesImp\\prueba32.xlsx";
                libro1.Save(archivoP);

                MessageBox.Show("Archivo Guardado correctamente");

                //Eliminar hoja de evaluacion
                /*FileStream fstream = new FileStream(archivoP, FileMode.Open);
                Workbook wb = new Workbook(fstream);
                wb.Worksheets.RemoveAt("DN1");
                //Worksheet hojaOculta = libro1.Worksheets[1];
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
        }

        public DataTable leerExcelColor()
        {
            string rutaprueba = rutaExcelColorActual;//ReporteImpB&N_20240513_1750.xlsx";
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

                //Inicializamos las lista para almacenar los totales de cada usuario por area
                listaAreas = new List<string>();
                listaTotalesBN = new List<int>();

                listaDN1 = new List<string>();
                ListaTotalDN1 = new List<int>();

                listaDN2 = new List<string>();
                listatotalDN2 = new List<int>();

                listaTI = new List<string>();
                listatotalTI = new List<int>();

                listaRH = new List<string>();
                listatotalRH = new List<int>();

                listaAuditoria = new List<string>();
                listatotalAud = new List<int>();

                listaComercio = new List<string>();
                listatotalComer = new List<int>();

                listaContraloria = new List<string>();
                listatotalContra = new List<int>();

                listaDirG = new List<string>();
                listaTotalDirG = new List<int>();

                listaLegal = new List<string>();
                listatotalLegal = new List<int>();

                listaPlaneacion = new List<string>();
                listatotalPlaneacion = new List<int>();

                listaSOX = new List<string>();
                listatotalSOX = new List<int>();

                //Inicializamos las listas para obtener los totales de cada columna por usuario y area
                listaTotalesColor = new List<int>();
                ListaTotalColorDN1 = new List<int>();
                listatotalColorDN2 = new List<int>();
                listatotalColorTI = new List<int>();
                listatotalColorRH = new List<int>();
                listatotalColorAud = new List<int>();
                listatotalColorComer = new List<int>();
                listatotalColorContra = new List<int>();
                listaTotalColorDirG = new List<int>();
                listatotalColorLegal = new List<int>();
                listatotalColorPlaneacion = new List<int>();
                listatotalColorSOX = new List<int>();

                listaTotalesGrande = new List<int>();
                ListaTotalGrandeDN1 = new List<int>();
                listatotalGrandeDN2 = new List<int>();
                listatotalGrandeTI = new List<int>();
                listatotalGrandeRH = new List<int>();
                listatotalGrandeAud = new List<int>();
                listatotalGrandeComer = new List<int>();
                listatotalGrandeContra = new List<int>();
                listaTotalGrandeDirG = new List<int>();
                listatotalGrandeLegal = new List<int>();
                listatotalGrandePlaneacion = new List<int>();
                listatotalGrandeSOX = new List<int>();

                listaTotalesDoble = new List<int>();
                ListaTotalDobleDN1 = new List<int>();
                listatotalDobleDN2 = new List<int>();
                listatotalDobleTI = new List<int>();
                listatotalDobleRH = new List<int>();
                listatotalDobleAud = new List<int>();
                listatotalDobleComer = new List<int>();
                listatotalDobleContra = new List<int>();
                listaTotalDobleDirG = new List<int>();
                listatotalDobleLegal = new List<int>();
                listatotalDoblePlaneacion = new List<int>();
                listatotalDobleSOX = new List<int>();

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

                totalColorDN1 = 0;
                totalColorDN2 = 0;
                totalColorTI = 0;
                totalColorRH = 0;
                totalColorAuditoria = 0;
                totalColorComercio = 0;
                totalColorContraloria = 0;
                totalColorDirG = 0;
                totalColorLegal = 0;
                totalColorPlaneacion = 0;
                totalColorSOX = 0;

                totalGrandeDN1 = 0;
                totalGrandeDN2 = 0;
                totalGrandeTI = 0;
                totalGrandeRH = 0;
                totalGrandeAuditoria = 0;
                totalGrandeComercio = 0;
                totalGrandeContraloria = 0;
                totalGrandeDirG = 0;
                totalGrandeLegal = 0;
                totalGrandePlaneacion = 0;
                totalGrandeSOX = 0;

                totalDobleDN1 = 0;
                totalDobleDN2 = 0;
                totalDobleTI = 0;
                totalDobleRH = 0;
                totalDobleAuditoria = 0;
                totalDobleComercio = 0;
                totalDobleContraloria = 0;
                totalDobleDirG = 0;
                totalDobleLegal = 0;
                totalDoblePlaneacion = 0;
                totalDobleSOX = 0;

                List<int> listaColumnasValidas = new List<int>();

                int sumarFilaAnterior = 0;

                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        //row = dt.NewRow();
                        contCols = 0;
                        foreach (Cell c in ws.Cells.Rows[i])
                        {
                            //Se añade las nuevas columnas con los titulos del excel leido y se valida que contengas los campos requeridos
                            String ColumnName = (string)c.Value;

                            if (ColumnName.Equals("Nombre de usuario")
                            || ColumnName.Equals("Copiar + Imprimir_Total_Negro")
                            || ColumnName.Equals("Copiar + Imprimir_Total_A todo color")
                            || ColumnName.Equals("Copiar + Imprimir_Tamaño grande_A todo color")
                            || ColumnName.Equals("Copiar + Imprimir_Impresión 2 caras"))
                            {
                                if (contCols != 0)
                                {
                                    dt.Columns.Add(ColumnName, typeof(Int32));
                                    listaColumnasValidas.Add(contCols);

                                }
                                else
                                {
                                    dt.Columns.Add(ColumnName, typeof(string));
                                    listaColumnasValidas.Add(contCols);
                                }
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
                        string nombreUsuario1 = ws.Cells[i, 0].Value.ToString();

                        int a = Convert.ToInt32(ws.Cells[i, 5].Value);
                        int b = Convert.ToInt32(ws.Cells[i, 7].Value);
                        int c = Convert.ToInt32(ws.Cells[i, 8].Value);
                        int d = Convert.ToInt32(ws.Cells[i, 17].Value);

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
                        int columnasAgregadas = 0;

                        string colNombre = ws.Cells[i, 0].Value.ToString();//se obtiene la celda con el nombre del usuario

                        //Se añade cada columna a la fila
                        List<int> valoresResta = new List<int>();

                        //recorremos la tabla del mes anterior para guardar las celdas y restarlas al mes actual
                        int columnasResta = 0;
                        int contarFilaAnterior = 0;
                        foreach (DataRow row1 in tablaColorAnterior.Rows)
                        {
                            //string nombre = row1[i,0].ToString();//Revisar la seleccion de
                            string nombre = tablaColorAnterior.Rows[contarFilaAnterior][0].ToString();//Revisar la seleccion de
                                                                                                      //string nombre = tablaColorAnterior.Rows[contarFilaAnterior][0].ToString();

                            if (nombre == colNombre)
                            {
                                foreach (DataColumn colResta in tablaColorAnterior.Columns)
                                {
                                    if (columnasResta != 0)
                                    {
                                        int resta = Convert.ToInt32(row1[columnasResta]);
                                        valoresResta.Add(resta);

                                    }
                                    columnasResta++;
                                }

                            }
                            contarFilaAnterior++;
                        }


                        foreach (Cell e in ws.Cells.Rows[i])
                        {

                            //Se añade las nuevas columnas con los titulos del excel leido y se valida que contengas los campos requeridos

                            if (listaColumnasValidas.Contains(contCols) && contCols != 0)
                            {
                                int col1 = Convert.ToInt32(ws.Cells[i, contCols].Value);
                                int index = columnasAgregadas - 1;

                                //Validamos que el usuario tenga registros del mes pasado para restar al actual, de lo contrario solo se agrega normal
                                if (valoresResta.Count > 0)
                                {
                                    //Se resta 
                                    int totalResta = col1 - valoresResta[index];
                                    row[columnasAgregadas] = totalResta;
                                }
                                else
                                {
                                    row[columnasAgregadas] = col1;
                                }
                                columnasAgregadas++;
                            }
                            else if (listaColumnasValidas.Contains(contCols) && contCols == 0)
                            {
                                //Agregamos el nombre del usuario a la tabla
                                row[columnasAgregadas] = colNombre;
                                columnasAgregadas++;
                            }

                            contCols++;
                        }


                        sqlConexion.Close();//Se cierra la conexion a mysql

                        row[5] = area;//Se agrega el area del usuario en la columna 5

                        int totalBN = (Int32)row[1];
                        int totalColor = (Int32)row[2];
                        int totalGrande = (Int32)row[3];
                        int totalDoble = (Int32)row[4];

                        if (totalBN != 0 || totalColor != 0 || totalGrande != 0 || totalDoble != 0)
                        {
                            dt.Rows.Add(row);
                            totalBNUsers++;

                            int totalUsuario = 0;
                            //Se suman los totales de impresiones respecto a cada area para la hoja de totales para la hoja total
                            if (area == "DN1")
                            {
                                totalDN1 += totalBN;
                                totalColorDN1 += totalColor;
                                totalGrandeDN1 += totalGrande;
                                totalDobleDN1 += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaDN1.Contains(nombreUsuario1))
                                {
                                    listaDN1.Add(nombreUsuario1);
                                    ListaTotalDN1.Add(totalBN);
                                    ListaTotalColorDN1.Add(totalColor);
                                    ListaTotalGrandeDN1.Add(totalGrande);
                                    ListaTotalDobleDN1.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaDN1.IndexOf(nombreUsuario1);
                                    int suma = ListaTotalDN1[index];
                                    ListaTotalDN1[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "DN2")
                            {
                                totalDN2 += totalBN;
                                totalColorDN2 += totalColor;
                                totalGrandeDN2 += totalGrande;
                                totalDobleDN2 += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaDN2.Contains(nombreUsuario1))
                                {
                                    listaDN2.Add(nombreUsuario1);
                                    listatotalDN2.Add(totalBN);
                                    listatotalColorDN2.Add(totalColor);
                                    listatotalGrandeDN2.Add(totalGrande);
                                    listatotalDobleDN2.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaDN2.IndexOf(nombreUsuario1);
                                    int suma = listatotalDN2[index];
                                    listatotalDN2[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "TI")
                            {
                                totalTI += totalBN;
                                totalColorTI += totalColor;
                                totalGrandeTI += totalGrande;
                                totalDobleTI += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaTI.Contains(nombreUsuario1))
                                {
                                    listaTI.Add(nombreUsuario1);
                                    listatotalTI.Add(totalBN);
                                    listatotalColorTI.Add(totalColor);
                                    listatotalGrandeTI.Add(totalGrande);
                                    listatotalDobleTI.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaTI.IndexOf(nombreUsuario1);
                                    int suma = listatotalTI[index];
                                    listatotalTI[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "RH")
                            {
                                totalRH += totalBN;
                                totalColorRH += totalColor;
                                totalGrandeRH += totalGrande;
                                totalDobleRH += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaRH.Contains(nombreUsuario1))
                                {
                                    listaRH.Add(nombreUsuario1);
                                    listatotalRH.Add(totalBN);
                                    listatotalColorRH.Add(totalColor);
                                    listatotalGrandeRH.Add(totalGrande);
                                    listatotalDobleRH.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaRH.IndexOf(nombreUsuario1);
                                    int suma = listatotalRH[index];
                                    listatotalRH[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "AUDITORIA")
                            {
                                totalAuditoria += totalBN;
                                totalColorAuditoria += totalColor;
                                totalGrandeAuditoria += totalGrande;
                                totalDobleAuditoria += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaAuditoria.Contains(nombreUsuario1))
                                {
                                    listaAuditoria.Add(nombreUsuario1);
                                    listatotalAud.Add(totalBN);
                                    listatotalColorAud.Add(totalColor);
                                    listatotalGrandeAud.Add(totalGrande);
                                    listatotalDobleAud.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaAuditoria.IndexOf(nombreUsuario1);
                                    int suma = listatotalAud[index];
                                    listatotalAud[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "COMERCIO")
                            {
                                totalComercio += totalBN;
                                totalColorComercio += totalColor;
                                totalGrandeComercio += totalGrande;
                                totalDobleComercio += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaComercio.Contains(nombreUsuario1))
                                {
                                    listaComercio.Add(nombreUsuario1);
                                    listatotalComer.Add(totalBN);
                                    listatotalColorComer.Add(totalColor);
                                    listatotalGrandeComer.Add(totalGrande);
                                    listatotalDobleComer.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaComercio.IndexOf(nombreUsuario1);
                                    int suma = listatotalComer[index];
                                    listatotalComer[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "CONTRALORIA")
                            {
                                totalContraloria += totalBN;
                                totalColorContraloria += totalColor;
                                totalGrandeContraloria += totalGrande;
                                totalDobleContraloria += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaContraloria.Contains(nombreUsuario1))
                                {
                                    listaContraloria.Add(nombreUsuario1);
                                    listatotalContra.Add(totalBN);
                                    listatotalColorContra.Add(totalColor);
                                    listatotalGrandeContra.Add(totalGrande);
                                    listatotalDobleContra.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaContraloria.IndexOf(nombreUsuario1);
                                    int suma = listatotalContra[index];
                                    listatotalContra[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "DIR.GRAL.")
                            {
                                totalDirG += totalBN;
                                totalColorDirG += totalColor;
                                totalGrandeDirG += totalGrande;
                                totalDobleDirG += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaDirG.Contains(nombreUsuario1))
                                {
                                    listaDirG.Add(nombreUsuario1);
                                    listaTotalDirG.Add(totalBN);
                                    listaTotalColorDirG.Add(totalColor);
                                    listaTotalGrandeDirG.Add(totalGrande);
                                    listaTotalDobleDirG.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaDirG.IndexOf(nombreUsuario1);
                                    int suma = listaTotalDirG[index];
                                    listaTotalDirG[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "LEGAL")
                            {
                                totalLegal += totalBN;
                                totalColorLegal += totalColor;
                                totalGrandeLegal += totalGrande;
                                totalDobleLegal += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaLegal.Contains(nombreUsuario1))
                                {
                                    listaLegal.Add(nombreUsuario1);
                                    listatotalLegal.Add(totalBN);
                                    listatotalColorLegal.Add(totalColor);
                                    listatotalGrandeLegal.Add(totalGrande);
                                    listatotalDobleLegal.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaLegal.IndexOf(nombreUsuario1);
                                    int suma = listatotalLegal[index];
                                    listatotalLegal[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "PLANEACION")
                            {
                                totalPlaneacion += totalBN;
                                totalColorPlaneacion += totalColor;
                                totalGrande += totalGrande;
                                totalDoble += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaPlaneacion.Contains(nombreUsuario1))
                                {
                                    listaPlaneacion.Add(nombreUsuario1);
                                    listatotalPlaneacion.Add(totalBN);
                                    listatotalColorPlaneacion.Add(totalColor);
                                    listatotalGrandePlaneacion.Add(totalGrande);
                                    listatotalDoblePlaneacion.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaPlaneacion.IndexOf(nombreUsuario1);
                                    int suma = listatotalPlaneacion[index];
                                    listatotalPlaneacion[index] = suma + ConTotal;*/
                                }
                            }
                            else if (area == "SOX")
                            {
                                totalSOX += totalBN;
                                totalColorSOX += totalColor;
                                totalGrandeSOX += totalGrande;
                                totalDobleSOX += totalDoble;

                                //agregamos el total de por usuario
                                if (!listaSOX.Contains(nombreUsuario1))
                                {
                                    listaSOX.Add(nombreUsuario1);
                                    listatotalSOX.Add(totalBN);
                                    listatotalColorSOX.Add(totalColor);
                                    listatotalGrandeSOX.Add(totalGrande);
                                    listatotalDobleSOX.Add(totalDoble);
                                }
                                else
                                {
                                    /*int index = listaSOX.IndexOf(nombreUsuario1);
                                    int suma = listatotalSOX[index];
                                    listatotalSOX[index] = suma + ConTotal;*/
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

                listaTotalesColor.Add(totalColorDN1);
                listaTotalesColor.Add(totalColorDN2);
                listaTotalesColor.Add(totalColorTI);
                listaTotalesColor.Add(totalColorRH);
                listaTotalesColor.Add(totalColorAuditoria);
                listaTotalesColor.Add(totalColorComercio);
                listaTotalesColor.Add(totalColorContraloria);
                listaTotalesColor.Add(totalColorDirG);
                listaTotalesColor.Add(totalColorLegal);
                listaTotalesColor.Add(totalColorPlaneacion);
                listaTotalesColor.Add(totalColorSOX);

                listaTotalesGrande.Add(totalGrandeDN1);
                listaTotalesGrande.Add(totalGrandeDN2);
                listaTotalesGrande.Add(totalGrandeTI);
                listaTotalesGrande.Add(totalGrandeRH);
                listaTotalesGrande.Add(totalGrandeAuditoria);
                listaTotalesGrande.Add(totalGrandeComercio);
                listaTotalesGrande.Add(totalGrandeContraloria);
                listaTotalesGrande.Add(totalGrandeDirG);
                listaTotalesGrande.Add(totalGrandeLegal);
                listaTotalesGrande.Add(totalGrandePlaneacion);
                listaTotalesGrande.Add(totalGrandeSOX);

                listaTotalesDoble.Add(totalDobleDN1);
                listaTotalesDoble.Add(totalDobleDN2);
                listaTotalesDoble.Add(totalDobleTI);
                listaTotalesDoble.Add(totalDobleRH);
                listaTotalesDoble.Add(totalDobleAuditoria);
                listaTotalesDoble.Add(totalDobleComercio);
                listaTotalesDoble.Add(totalDobleContraloria);
                listaTotalesDoble.Add(totalDobleDirG);
                listaTotalesDoble.Add(totalDobleLegal);
                listaTotalesDoble.Add(totalDoblePlaneacion);
                listaTotalesDoble.Add(totalDobleSOX);

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
                totalesBN.Columns.Add("Total Color", typeof(Int32));
                totalesBN.Columns.Add("Total Tabloide", typeof(Int32));
                totalesBN.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaDN1.Columns.Add("Usuario", typeof(String));
                tablaDN1.Columns.Add("Total B&N", typeof(Int32));
                tablaDN1.Columns.Add("Total Color", typeof(Int32));
                tablaDN1.Columns.Add("Total Tabloide", typeof(Int32));
                tablaDN1.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaDN2.Columns.Add("Usuario", typeof(String));
                tablaDN2.Columns.Add("Total B&N", typeof(Int32));
                tablaDN2.Columns.Add("Total Color", typeof(Int32));
                tablaDN2.Columns.Add("Total Tabloide", typeof(Int32));
                tablaDN2.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaTI.Columns.Add("Usuario", typeof(String));
                tablaTI.Columns.Add("Total B&N", typeof(Int32));
                tablaTI.Columns.Add("Total Color", typeof(Int32));
                tablaTI.Columns.Add("Total Tabloide", typeof(Int32));
                tablaTI.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaRH.Columns.Add("Usuario", typeof(String));
                tablaRH.Columns.Add("Total B&N", typeof(Int32));
                tablaRH.Columns.Add("Total Color", typeof(Int32));
                tablaRH.Columns.Add("Total Tabloide", typeof(Int32));
                tablaRH.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaAuditoria.Columns.Add("Usuario", typeof(String));
                tablaAuditoria.Columns.Add("Total B&N", typeof(Int32));
                tablaAuditoria.Columns.Add("Total Color", typeof(Int32));
                tablaAuditoria.Columns.Add("Total Tabloide", typeof(Int32));
                tablaAuditoria.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaComercio.Columns.Add("Usuario", typeof(String));
                tablaComercio.Columns.Add("Total B&N", typeof(Int32));
                tablaComercio.Columns.Add("Total Color", typeof(Int32));
                tablaComercio.Columns.Add("Total Tabloide", typeof(Int32));
                tablaComercio.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaContraloria.Columns.Add("Usuario", typeof(String));
                tablaContraloria.Columns.Add("Total B&N", typeof(Int32));
                tablaContraloria.Columns.Add("Total Color", typeof(Int32));
                tablaContraloria.Columns.Add("Total Tabloide", typeof(Int32));
                tablaContraloria.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaDirG.Columns.Add("Usuario", typeof(String));
                tablaDirG.Columns.Add("Total B&N", typeof(Int32));
                tablaDirG.Columns.Add("Total Color", typeof(Int32));
                tablaDirG.Columns.Add("Total Tabloide", typeof(Int32));
                tablaDirG.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaLegal.Columns.Add("Usuario", typeof(String));
                tablaLegal.Columns.Add("Total B&N", typeof(Int32));
                tablaLegal.Columns.Add("Total Color", typeof(Int32));
                tablaLegal.Columns.Add("Total Tabloide", typeof(Int32));
                tablaLegal.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaPlaneacion.Columns.Add("Usuario", typeof(String));
                tablaPlaneacion.Columns.Add("Total B&N", typeof(Int32));
                tablaPlaneacion.Columns.Add("Total Color", typeof(Int32));
                tablaPlaneacion.Columns.Add("Total Tabloide", typeof(Int32));
                tablaPlaneacion.Columns.Add("Total 2 Caras", typeof(Int32));

                tablaSOX.Columns.Add("Usuario", typeof(String));
                tablaSOX.Columns.Add("Total B&N", typeof(Int32));
                tablaSOX.Columns.Add("Total Color", typeof(Int32));
                tablaSOX.Columns.Add("Total Tabloide", typeof(Int32));
                tablaSOX.Columns.Add("Total 2 Caras", typeof(Int32));



                DataRow filaTotal;
                DataRow filadn1;
                int recorreLista = 0;

                int TotalAreasBN = 0;
                int TotalAreasColor = 0;
                int TotalAreasGrande = 0;
                int TotalAreasDoble = 0;

                //Se agregan los datos de las filas para cada una de las tablas
                for (int i = 0; i < 11; i++)
                {
                    string area = listaAreas[i];
                    int total1 = listaTotalesBN[i];//
                    int total2 = listaTotalesColor[i];
                    int total3 = listaTotalesGrande[i];
                    int total4 = listaTotalesDoble[i];

                    filaTotal = totalesBN.NewRow();
                    filaTotal[0] = area;
                    filaTotal[1] = total1;//
                    filaTotal[2] = total2;
                    filaTotal[3] = total3;
                    filaTotal[4] = total4;

                    //Se suma el total de cada columna por areas por cada usuario 
                    TotalAreasBN += total1;
                    TotalAreasColor += total2;
                    TotalAreasGrande += total3;
                    TotalAreasDoble += total4;

                    totalesBN.Rows.Add(filaTotal);
                }
                filaTotal = totalesBN.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = TotalAreasBN;
                filaTotal[2] = TotalAreasColor;
                filaTotal[3] = TotalAreasGrande;
                filaTotal[4] = TotalAreasDoble;
                totalesBN.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDN1; i++)
                {
                    string nombre = listaDN1[i];
                    int total = ListaTotalDN1[i];
                    int total2 = ListaTotalColorDN1[i];
                    int total3 = ListaTotalGrandeDN1[i];
                    int total4 = ListaTotalDobleDN1[i];

                    filadn1 = tablaDN1.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaDN1.Rows.Add(filadn1);
                }
                filaTotal = tablaDN1.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDN1;
                filaTotal[2] = totalColorDN1;
                filaTotal[3] = totalGrandeDN1;
                filaTotal[4] = totalDobleDN1;
                tablaDN1.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDN2; i++)
                {
                    string nombre = listaDN2[i];
                    int total = listatotalDN2[i];
                    int total2 = listatotalColorDN2[i];
                    int total3 = listatotalGrandeDN2[i];
                    int total4 = listatotalDobleDN2[i];

                    filadn1 = tablaDN2.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaDN2.Rows.Add(filadn1);
                }
                filaTotal = tablaDN2.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDN2;
                filaTotal[2] = totalColorDN2;
                filaTotal[3] = totalGrandeDN2;
                filaTotal[4] = totalDobleDN2;
                tablaDN2.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conTI; i++)
                {
                    string nombre = listaTI[i];
                    int total = listatotalTI[i];
                    int total2 = listatotalColorTI[i];
                    int total3 = listatotalGrandeTI[i];
                    int total4 = listatotalDobleTI[i];

                    filadn1 = tablaTI.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaTI.Rows.Add(filadn1);
                }
                filaTotal = tablaTI.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalTI;
                filaTotal[2] = totalColorTI;
                filaTotal[3] = totalGrandeTI;
                filaTotal[4] = totalDobleTI;
                tablaTI.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conRH; i++)
                {
                    string nombre = listaRH[i];
                    int total = listatotalRH[i];
                    int total2 = listatotalColorRH[i];
                    int total3 = listatotalGrandeRH[i];
                    int total4 = listatotalDobleRH[i];

                    filadn1 = tablaRH.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaRH.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaRH.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalRH;
                filaTotal[2] = totalColorRH;
                filaTotal[3] = totalGrandeRH;
                filaTotal[4] = totalDobleRH;
                tablaRH.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conAudit; i++)
                {
                    string nombre = listaAuditoria[i];
                    int total = listatotalAud[i];
                    int total2 = listatotalColorAud[i];
                    int total3 = listatotalGrandeAud[i];
                    int total4 = listatotalDobleAud[i];

                    filadn1 = tablaAuditoria.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaAuditoria.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaAuditoria.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalAuditoria;
                filaTotal[2] = totalColorAuditoria;
                filaTotal[3] = totalGrandeAuditoria;
                filaTotal[4] = totalDobleAuditoria;
                tablaAuditoria.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conComer; i++)
                {
                    string nombre = listaComercio[i];
                    int total = listatotalComer[i];
                    int total2 = listatotalColorComer[i];
                    int total3 = listatotalGrandeComer[i];
                    int total4 = listatotalDobleComer[i];

                    filadn1 = tablaComercio.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaComercio.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaComercio.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalComercio;
                filaTotal[2] = totalColorComercio;
                filaTotal[3] = totalGrandeComercio;
                filaTotal[4] = totalDobleComercio;
                tablaComercio.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conContra; i++)
                {
                    string nombre = listaContraloria[i];
                    int total = listatotalContra[i];
                    int total2 = listatotalColorContra[i];
                    int total3 = listatotalGrandeContra[i];
                    int total4 = listatotalDobleContra[i];

                    filadn1 = tablaContraloria.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaContraloria.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaContraloria.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalContraloria;
                filaTotal[2] = totalColorContraloria;
                filaTotal[3] = totalGrandeContraloria;
                filaTotal[4] = totalDobleContraloria;
                tablaContraloria.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conDir; i++)
                {
                    string nombre = listaDirG[i];
                    int total = listaTotalDirG[i];
                    int total2 = listaTotalColorDirG[i];
                    int total3 = listaTotalGrandeDirG[i];
                    int total4 = listaTotalDobleDirG[i];

                    filadn1 = tablaDirG.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaDirG.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaDirG.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalDirG;
                filaTotal[2] = totalColorDirG;
                filaTotal[3] = totalGrandeDirG;
                filaTotal[4] = totalDobleDirG;
                tablaDirG.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conLegal; i++)
                {
                    string nombre = listaLegal[i];
                    int total = listatotalLegal[i];
                    int total2 = listatotalColorLegal[i];
                    int total3 = listatotalGrandeLegal[i];
                    int total4 = listatotalDobleLegal[i];

                    filadn1 = tablaLegal.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaLegal.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaLegal.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalLegal;
                filaTotal[2] = totalColorLegal;
                filaTotal[3] = totalGrandeLegal;
                filaTotal[4] = totalDobleLegal;
                tablaLegal.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conPlanea; i++)
                {
                    string nombre = listaPlaneacion[i];
                    int total = listatotalPlaneacion[i];
                    int total2 = listatotalColorPlaneacion[i];
                    int total3 = listatotalGrandePlaneacion[i];
                    int total4 = listatotalDoblePlaneacion[i];

                    filadn1 = tablaPlaneacion.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaPlaneacion.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaPlaneacion.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalPlaneacion;
                filaTotal[2] = totalColorPlaneacion;
                filaTotal[3] = totalGrandePlaneacion;
                filaTotal[4] = totalDoblePlaneacion;
                tablaPlaneacion.Rows.Add(filaTotal);

                //cargar tabla 
                for (int i = 0; i < conSOX; i++)
                {
                    string nombre = listaSOX[i];
                    int total = listatotalSOX[i];
                    int total2 = listatotalColorSOX[i];
                    int total3 = listatotalGrandeSOX[i];
                    int total4 = listatotalDobleSOX[i];

                    filadn1 = tablaSOX.NewRow();
                    filadn1[0] = nombre;
                    filadn1[1] = total;
                    filadn1[2] = total2;
                    filadn1[3] = total3;
                    filadn1[4] = total4;

                    tablaSOX.Rows.Add(filadn1);
                    //recorreLista++; 
                }
                filaTotal = tablaSOX.NewRow();
                filaTotal[0] = "TOTAL:";
                filaTotal[1] = totalSOX;
                filaTotal[2] = totalColorSOX;
                filaTotal[3] = totalGrandeSOX;
                filaTotal[4] = totalDobleSOX;
                tablaSOX.Rows.Add(filaTotal);


                fstream.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        public DataTable leerExcelColorAnterior()
        {
            string rutaprueba = rutaExcelColorAnterior;//ReporteImpB&N_20240513_1750.xlsx";
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
                totalBNUsers = 0;
                totalesBN = new DataTable();//Se inicializa la tabla totalBN

                List<int> listaColumnasValidas = new List<int>();

                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        //row = dt.NewRow();
                        contCols = 0;
                        foreach (Cell c in ws.Cells.Rows[i])
                        {
                            //Se añade las nuevas columnas con los titulos del excel leido y se valida que contengas los campos requeridos
                            String ColumnName = (string)c.Value;

                            if (ColumnName.Equals("Nombre de usuario")
                            || ColumnName.Equals("Copiar + Imprimir_Total_Negro")
                            || ColumnName.Equals("Copiar + Imprimir_Total_A todo color")
                            || ColumnName.Equals("Copiar + Imprimir_Tamaño grande_A todo color")
                            || ColumnName.Equals("Copiar + Imprimir_Impresión 2 caras"))
                            {
                                if (contCols != 0)
                                {
                                    dt.Columns.Add(ColumnName, typeof(Int32));
                                    listaColumnasValidas.Add(contCols);

                                }
                                else
                                {
                                    dt.Columns.Add(ColumnName, typeof(string));
                                    listaColumnasValidas.Add(contCols);
                                }
                            }


                            contCols++;
                        }
                    }
                    else
                    {
                        string nombreUsuario1 = ws.Cells[i, 1].Value.ToString();
                        int ConTotal = 0;

                        int a = Convert.ToInt32(ws.Cells[i, 5].Value);
                        int b = Convert.ToInt32(ws.Cells[i, 7].Value);
                        int c = Convert.ToInt32(ws.Cells[i, 8].Value);
                        int d = Convert.ToInt32(ws.Cells[i, 17].Value);


                        //validamos que las columnas no esten en 0 antes de agregarlas
                        if (a != 0 || b != 0 || c != 0 || d != 0)
                        {
                            //Hacemos cunsulta del area de cada usuario para añadirlo a la tabla
                            string nombreUsuario = ws.Cells[i, 1].Value.ToString();

                            //Creacion de fila por cada registro y lo añadimos a la tabla dt
                            row = dt.NewRow();
                            contCols = 0;
                            int columnasAgregadas = 0;

                            //Se añade cada columna a la fila
                            foreach (Cell e in ws.Cells.Rows[i])
                            {
                                //Se añade las nuevas columnas con los titulos del excel leido y se valida que contengas los campos requeridos
                                //String ColumnName = Convert.ToString(c.Value);
                                if (listaColumnasValidas.Contains(contCols) && contCols != 0)
                                {
                                    int col1 = Convert.ToInt32(ws.Cells[i, contCols].Value);
                                    row[columnasAgregadas] = col1;
                                    columnasAgregadas++;
                                }
                                else if (listaColumnasValidas.Contains(contCols) && contCols == 0)
                                {
                                    string col1 = ws.Cells[i, contCols].Value.ToString();
                                    row[columnasAgregadas] = col1;
                                    columnasAgregadas++;
                                }

                                contCols++;
                            }
                            dt.Rows.Add(row);


                        }

                    }


                }

                fstream.Close();

            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int filasSeleccionadas = dataGridView1.SelectedRows.Count;
            if (filasSeleccionadas == 0)
            {
                MessageBox.Show("Debe Seleccionar primero una fila");
            }
            else if (filasSeleccionadas == 1)
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;

                string correo = row[0].Cells[0].Value.ToString();
                string nombre = row[0].Cells[1].Value.ToString();
                string puesto = row[0].Cells[2].Value.ToString();
                string id_area = row[0].Cells[3].Value.ToString();


                EditaUsuario editScreed = new EditaUsuario(correo, nombre, puesto, id_area);
                editScreed.ShowDialog();
                if (editScreed.validaActualizacion)
                {
                    Resultados_Load();
                }
            }
            else
            {
                MessageBox.Show("Solo debe seleccionar una fila");
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasSeleccionadas = dataGridView1.SelectedRows.Count;
            if (filasSeleccionadas == 0)
            {
                MessageBox.Show("Debe Seleccionar primero una fila");
            }
            else if (filasSeleccionadas == 1)
            {
                DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
                string correo = row[0].Cells[0].Value.ToString();//Obtenemos el valor del correo en la fila seleccionada
                var dialogResult = MessageBox.Show("Seguro que deseas eliminar al usuario: " + correo, "Eliminar", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    MySqlConnection sqlConexion;
                    sqlConexion = getConection();
                    try
                    {
                        //Se aplica el delete en la base de datos
                        sqlConexion.Open();
                        string sqlCon = "delete from empleado where Correo = '" + correo + "';";
                        MySqlCommand com = new MySqlCommand(sqlCon, sqlConexion);
                        com.ExecuteNonQuery();

                        MessageBox.Show("Usuario Eliminado Correctamente");
                        Resultados_Load();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No se pudo eliminar el registro, intente mas tarde", "ERROR");
                    }
                    sqlConexion.Close();
                }

            }
            else
            {
                MessageBox.Show("Solo debe seleccionar una fila");
            }
        }

        private void BusquedaUsuario()
        {
            DataTable tablaBusqueda = new DataTable();
            DataRow fila;

            tablaBusqueda.Columns.Add("Correo", typeof(string));
            tablaBusqueda.Columns.Add("Nombre", typeof(string));
            tablaBusqueda.Columns.Add("Puesto", typeof(string));
            tablaBusqueda.Columns.Add("ID_Area", typeof(Int32));
            tablaBusqueda.Columns.Add("Area", typeof(string));

            int contFilas = 0;

            foreach (DataRow rows in Tablausuarios.Rows)
            {
                //obtenemos el valor de la entrada de busqueda y el valor de cada una de las columnas en la fila recorrida
                string strEntrada = txtBusqueda.Text.ToUpper();
                string columna1 = rows[0].ToString().ToUpper();
                string columna2 = rows[1].ToString().ToUpper();
                string columna3 = rows[2].ToString().ToUpper();
                string columna4 = rows[3].ToString().ToUpper();
                string columna5 = rows[4].ToString().ToUpper();

                //validamos que alguna columna contenga datos de la entrada de busqueda
                bool a = columna1.Contains(strEntrada);
                bool b = columna2.Contains(strEntrada);
                bool c = columna3.Contains(strEntrada);
                bool d = columna4.Contains(strEntrada);
                bool e = columna5.Contains(strEntrada);


                if (a || b || c || d || e)
                {
                    //Se agrega la fila a la nueva tabla de busqueda en caso de que contenga la entrada de busqueda
                    fila = tablaBusqueda.NewRow();
                    int contCols = 0;
                    foreach (DataColumn col in Tablausuarios.Columns)
                    {
                        fila[contCols] = rows[col];
                        contCols++;
                    }

                    tablaBusqueda.Rows.Add(fila);

                }
                contFilas++;
            }
            dataGridView1.DataSource = tablaBusqueda;
        }

        private void picBusqueda_Click(object sender, EventArgs e)
        {
            BusquedaUsuario();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (!txtBusqueda.Equals(""))
            {
                BusquedaUsuario();
            }
            else
            {
                Resultados_Load();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            if (!txtCorreo.Text.Equals("") && !txtNombre.Text.Equals("") && !txtPuesto.Text.Equals(""))
            {
                string cmbarea = comboAreas.Text;
                string id_area = cmbarea.Substring(0, 1);

                var dialogResult = MessageBox.Show("Se dará de alta al usuario: " + txtCorreo.Text, "Registro", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    MySqlConnection sqlConexion;
                    sqlConexion = getConection();
                    try
                    {
                        //Se aplica el delete en la base de datos
                        sqlConexion.Open();
                        string sqlCon = "insert into empleado (Correo, Nombre, Puesto, Area_idArea)" +
                            " values ('" + txtCorreo.Text + "','" + txtNombre.Text + "','" + txtPuesto.Text + "'," + id_area + ");";
                        MySqlCommand com = new MySqlCommand(sqlCon, sqlConexion);
                        com.ExecuteNonQuery();

                        MessageBox.Show("Usuario Registrado Correctamente");
                        Resultados_Load();
                        txtCorreo.Text = "";
                        txtNombre.Text = "";
                        txtPuesto.Text = "";
                        comboAreas.SelectedIndex = 0;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo hacer el registro, el usuario con ese correo ya existe", "ERROR");
                    }
                    sqlConexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

        private void btnSelecColor_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            //Seleccionar reporte csv o excel
            if (file1.ShowDialog() == DialogResult.OK)
            {
                rutaExcelColorActual = file1.FileName;
                txtColorActual.Text = rutaExcelColorActual;

            }
        }

        private void btnSlcColorAnt_Click(object sender, EventArgs e)
        {
            OpenFileDialog file1 = new OpenFileDialog();
            file1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            //Seleccionar reporte csv o excel
            if (file1.ShowDialog() == DialogResult.OK)
            {
                rutaExcelColorAnterior = file1.FileName;
                txtColorAnterior.Text = rutaExcelColorAnterior;
                tablaColorAnterior = leerExcelColorAnterior();
            }

        }

        //Validar que solo se escriban numeros en los text de impresoras independientes

        private void txtContraloria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDirGral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminarBN_Click(object sender, EventArgs e)
        {
            if (txtRutaBN.Text.Equals(""))
            {
                MessageBox.Show("Aun no se selecciona el archivo");
            }
            else
            {
                txtRutaBN.Text = "";
            }
        }

        private void btnEliminarColAct_Click(object sender, EventArgs e)
        {
            if (txtColorActual.Text.Equals(""))
            {
                MessageBox.Show("Aun no se selecciona el archivo");
            }
            else
            {
                txtColorActual.Text = "";
            }
        }

        private void btnEliminarColAnt_Click(object sender, EventArgs e)
        {
            if (txtColorAnterior.Text.Equals(""))
            {
                MessageBox.Show("Aun no se selecciona el archivo");
            }
            else
            {
                txtColorAnterior.Text = "";
            }
        }
    }
}

