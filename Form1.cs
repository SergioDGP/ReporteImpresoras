using Aspose.Cells;
using Aspose.Cells.Drawing;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2016.Excel;


//using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Cell = Aspose.Cells.Cell;
using Path = System.IO.Path;
using Row = Aspose.Cells.Row;
using Workbook = Aspose.Cells.Workbook;
using Worksheet = Aspose.Cells.Worksheet;

namespace ReporteImpresoras
{
    public partial class VentanaPrincipal : Form
    {
        public string rutaExcelByN;
        public VentanaPrincipal()
        {
            InitializeComponent();
            cargaAnioMes();
            //Resultados_Load();
            leerExcel();
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

                leerExcel();
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
            string rutaprueba = @"C:\Conversiones ReportesImp\ReporteImpB&N_20240513_1750.xlsx";
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

                for (int i = 0; i < rows; i++)
                {
                    if (i == 0)
                    {
                        //row = dt.NewRow();
                        contCols = 0;
                        foreach (Cell c in ws.Cells.Rows[i])
                        {
                            //row[contCols] = c.Value;
                            column = new DataColumn();
                            column.DataType = Type.GetType("System.String");
                            column.ColumnName = (string)c.Value;
                            dt.Columns.Add(column);

                            contCols++;
                        }
                        //dt.Rows.Add(row);
                    }
                    else 
                    {
                        if (ws.Cells[i, 0].Value.ToString() == "Copiar")
                        {
                            row = dt.NewRow();
                            contCols = 0;
                            foreach (Cell c in ws.Cells.Rows[i])
                            {
                                row[contCols] = c.Value;
                                //row["ParentItem"] = "ParentItem " + i;
                                contCols++;
                            }
                            dt.Rows.Add(row);

                        }
                    }
                }
                dataGridView1.DataSource = dt;  
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

                var libro1 = new Workbook();//Creamos un nuevo libro de excel

                int index = libro1.Worksheets.Add();
                Worksheet hoja1 = libro1.Worksheets.Add("General");//Se agrega primera hoja(General)
                MySqlConnection sqlConexion = getConection(); //Se inicializa la conexion a la base

                try
                {
                    sqlConexion.Open();
                    //conexion.Text = "Conectados!!";
                    sqlConexion.Close();
                }
                catch (System.Exception ex)
                {
                    //conexion.Text = ex.Message;
                }
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
