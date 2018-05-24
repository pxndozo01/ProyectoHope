Imports System.Data.SqlClient

Module conexionGlobal
    Public servidor As String = "PRO"
    Public tipo As String
    Public primerLogin As Boolean = False
    Public conexionsql As New SqlConnection("Data Source ='" & servidor & "'; Initial Catalog = 'INVENTARIO_DB'; Integrated security = true; MultipleActiveResultSets=True")
    'Bandera para activar bandera de cerrar sesion


    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.
            Dim cont As Integer = 1

            For i As Integer = 0 To NCol - 1

                If (ElGrid.Columns(i).Visible = True) Then
                    exHoja.Cells.Item(1, cont) = ElGrid.Columns(i).HeaderText

                    cont += 1
                End If

            Next


            For Fila As Integer = 0 To NRow - 1
                Dim c As Integer = 0
                For Col As Integer = 0 To NCol - 1
                    If (ElGrid.Rows(0).Cells(Col).Visible) Then
                        exHoja.Cells.Item(Fila + 2, c + 1) = ElGrid.Item(Col, Fila).Value
                        c += 1
                    End If

                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function


End Module
